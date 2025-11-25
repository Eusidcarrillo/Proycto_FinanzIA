using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FinanzIA
{
    public partial class Form1 : Form
    {
        private formDashboard dashboard;
        formSub1 sub1;
        formAbout about;
        formSetting setting;
        formSub2 sub2;

        private Button btnCloseChild;
        private Button btnMinimizeChild;
        private Button btnMaximizeChild;

        private Form activeForm = null;
        private Panel panelMain;

        // Estado y constantes para la animación del menú/sidebar
        private bool menuExpanded = false;
        private bool sidebarExpanded = true;
        private const int MENU_EXPANDED_HEIGHT = 185;
        private const int MENU_COLLAPSED_HEIGHT = 61;
        private const int SIDEBAR_EXPANDED_WIDTH = 216;
        private const int SIDEBAR_COLLAPSED_WIDTH = 70;
        private const int ANIMATION_STEP = 10;

        public Form1()
        {
            InitializeComponent();

            // Usaremos panelMain para incrustar los formularios (no MDI)
            this.IsMdiContainer = false;

            // Ajuste seguro para mdiProp (no fallará si no hay MdiClient)
            mdiProp();

            // Si el diseñador ya creó un panel llamado "panelMain", recupéralo.
            var existingPanel = this.Controls.Find("panelMain", true).FirstOrDefault() as Panel;
            if (existingPanel != null)
            {
                panelMain = existingPanel;
            }
            else if (panelMain == null)
            {
                // Crear panelMain solo si no existe en el diseñador
                panelMain = new Panel();
                panelMain.Name = "panelMain";
                panelMain.Dock = DockStyle.Fill;
                this.Controls.Add(panelMain);
                // Asegurar que los controles del diseñador (sidebar, panel1) queden por delante:
                panelMain.SendToBack();
            }

            // Inicializa los botones auxiliares si los vas a usar (ocultos en diseño)
            btnCloseChild = new Button();
            btnMinimizeChild = new Button();
            btnMaximizeChild = new Button();
            
            // Enlaza manejadores para los botones auxiliares (si se usan)
            btnCloseChild.Click += btnCloseChild_Click;
            btnMinimizeChild.Click += btnMinimizeChild_Click;
            btnMaximizeChild.Click += btnMaximizeChild_Click;

            // Enlaza manejadores de Click de forma segura por nombre (no falla si renombraste controles)
            WireClickIfExists("btnDashboard", btnDashboard_Click);
            WireClickIfExists("btnmenu", menu_Click);
            WireClickIfExists("btnSub1", submenu1_Click);
            WireClickIfExists("btnSub2", submenu2_Click);
            WireClickIfExists("button6", btnAbout_Click); // si renombraste "button6" ajústalo al nuevo nombre
            WireClickIfExists("btnset", btnSettings_Click);

            // Refuerzo: intenta enlazar directamente si los controles están anidados de forma inesperada
            // Forzar enlace explícito si no está en el diseñador (colócalo tras InitializeComponent())
            var bd = this.Controls.Find("btnDashboard", true).FirstOrDefault() as Button;
            if (bd != null)
            {
                bd.Click -= btnDashboard_Click;
                bd.Click += btnDashboard_Click;
            }

            var bs1 = this.Controls.Find("btnSub1", true).FirstOrDefault() as Button;
            if (bs1 != null)
            {
                // limpiar y asignar solo el handler deseado para evitar duplicados
                RemoveAllClickHandlers(bs1);
                bs1.Click += submenu1_Click;
            }

            // Sincronizar estado inicial del menú/sidebar con las constantes
            try { menuContainer.Height = MENU_COLLAPSED_HEIGHT; } catch { }
            try { sidebar.Width = SIDEBAR_EXPANDED_WIDTH; } catch { }

            // Busca todos los botones en el panel 'pnDashboar' (nombre real del diseñador) y les asigna un handler genérico
            WireButtonsInPnDashboard();

            // NOTA: los demás botones (btnDashboard, btnmenu, btnSub1, btnHam) ya están enlazados en el Designer.
        }

        private void mdiProp()
        {
            try
            {
                this.SetBevel(false);
            }
            catch { }

            var client = Controls.OfType<MdiClient>().FirstOrDefault();
            if (client != null)
                client.BackColor = Color.FromArgb(232, 234, 237);
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            // Animación de expansión/contracción del contenedor de submenú
            if (menuExpanded)
            {
                // colapsar
                if (menuContainer.Height > MENU_COLLAPSED_HEIGHT)
                    menuContainer.Height = Math.Max(MENU_COLLAPSED_HEIGHT, menuContainer.Height - ANIMATION_STEP);
                else
                {
                    menuTransition.Stop();
                    menuExpanded = false;
                }
            }
            else
            {
                // expandir
                if (menuContainer.Height < MENU_EXPANDED_HEIGHT)
                    menuContainer.Height = Math.Min(MENU_EXPANDED_HEIGHT, menuContainer.Height + ANIMATION_STEP);
                else
                {
                    menuTransition.Stop();
                    menuExpanded = true;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Animación de expansión/contracción del sidebar (anchura)
            if (sidebarExpanded)
            {
                // colapsar
                if (sidebar.Width > SIDEBAR_COLLAPSED_WIDTH)
                    sidebar.Width = Math.Max(SIDEBAR_COLLAPSED_WIDTH, sidebar.Width - ANIMATION_STEP);
                else
                {
                    sidebarTransition.Stop();
                    sidebarExpanded = false;
                }
            }
            else
            {
                // expandir
                if (sidebar.Width < SIDEBAR_EXPANDED_WIDTH)
                    sidebar.Width = Math.Min(SIDEBAR_EXPANDED_WIDTH, sidebar.Width + ANIMATION_STEP);
                else
                {
                    sidebarTransition.Stop();
                    sidebarExpanded = true;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Dashboard (ahora control renombrado a btnDashboard)
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                OpenChildForm(dashboard, panelMain);
            }
            else
            {
                dashboard.BringToFront();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void submenu1_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegurarse de que panelMain está inicializado (intento de recuperación si falta)
                if (panelMain == null)
                {
                    panelMain = this.Controls.Find("panelMain", true).FirstOrDefault() as Panel;
                }

                if (panelMain == null)
                {
                    MessageBox.Show("No se ha encontrado 'panelMain'. Comprueba que existe en el diseñador o crea un Panel llamado 'panelMain'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (sub1 == null)
                {
                    sub1 = new formSub1();
                    sub1.FormClosed += Sub1_FormClosed;
                    OpenChildForm(sub1, panelMain);
                }
                else
                {
                    sub1.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir SubMenu 1: {ex.Message}", "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sub1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub1 = null;
        }

        private void submenu2_Click(object sender, EventArgs e)
        {
            if (sub2 == null)
            {
                sub2 = new formSub2();
                sub2.FormClosed += Sub2_FormClosed;
                OpenChildForm(sub2, panelMain);
            }
            else
            {
                sub2.BringToFront();
            }
        }

        private void Sub2_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub2 = null;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new formAbout();
                about.FormClosed += About_FormClosed;
                OpenChildForm(about, panelMain);
            }
            else
            {
                about.BringToFront();
            }
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            about = null;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (setting == null)
            {
                setting = new formSetting();
                setting.FormClosed += Setting_FormClosed;
                OpenChildForm(setting, panelMain);
            }
            else
            {
                setting.BringToFront();
            }
        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            setting = null;
        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                return;
            }

            MessageBox.Show("No hay ventanas hijas abiertas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMinimizeChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizeChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.WindowState = activeForm.WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal
                    : FormWindowState.Maximized;
            }
        }

        private void OpenChildForm(Form childForm, Control container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container), "panelMain no está inicializado. Añádalo en el diseñador o cree el control antes de usarlo.");

            try
            {
                if (activeForm != null)
                    activeForm.Close();

                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                container.Controls.Clear();
                container.Controls.Add(childForm);
                container.Tag = childForm;

                // Asegurarse de que el contenedor y el childForm estén visibles y al frente
                container.Visible = true;
                container.BringToFront();

                childForm.BringToFront();
                childForm.Show();
                childForm.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo mostrar el formulario hijo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Mejora: enlaza de forma segura (evita múltiples añadidos y errores si no existe)
        private void WireClickIfExists(string controlName, EventHandler handler)
        {
            var ctrl = this.Controls.Find(controlName, true).FirstOrDefault();
            if (ctrl is Button b)
            {
                b.Click -= handler;
                b.Click += handler;
            }
        }

        // Busca todos los botones en el panel 'pnDashboard' y les asigna un handler genérico
        private void WireButtonsInPnDashboard()
        {
            // Intenta obtener la instancia real creada por el diseñador, y si no intenta buscar por nombre.
            var panel = this.pnDashboar ?? this.Controls.Find("pnDashboar", true).FirstOrDefault() as Panel;
            if (panel == null) return;

            foreach (var btn in panel.Controls.OfType<Button>())
            {
                // Evitar interceptar el evento del botón principal (btnDashboard) que ya tiene su handler
                if (string.Equals(btn.Name, "btnDashboard", StringComparison.OrdinalIgnoreCase))
                    continue;

                btn.Click -= PnDashboardButton_Click;
                btn.Click += PnDashboardButton_Click;
            }
        }

        private void PnDashboardButton_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            // respuesta según el nombre o Tag
            MessageBox.Show($"Pulsado: {b.Name}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Añade este método dentro de la clase Form1
        private void BtnInside_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón interno pulsado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Placeholder si el diseñador hace referencia a button1_Click que falta (evita CS1061)
        private void button1_Click(object sender, EventArgs e)
        {
            // Evita el CS1061 si el diseñador referencia este handler inesperadamente.
            // Redirígelo a la acción deseada (ejemplo: handler genérico ya presente)
            PnDashboardButton_Click(sender, e);
        }

        // Elimina todos los manejadores Click de un botón (usa reflexión en EventHandlerList)
private void RemoveAllClickHandlers(Button b)
{
    if (b == null) return;
    var eventsProp = typeof(Component).GetProperty("Events", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
    var list = (EventHandlerList)eventsProp.GetValue(b, null);
    var keyField = typeof(Control).GetField("EventClick", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
    var key = keyField.GetValue(null);
    list[key] = null;
}

// Método de depuración para ver qué manejadores Click están asignados (opcional)
private string DumpClickHandlers(Control c)
{
    if (c == null) return "(null)";
    var eventsProp = typeof(Component).GetProperty("Events", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
    var list = (EventHandlerList)eventsProp.GetValue(c, null);
    var keyField = typeof(Control).GetField("EventClick", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
    var key = keyField.GetValue(null);
    var d = list[key] as Delegate;
    if (d == null) return "No hay handlers Click";
    return string.Join(", ", d.GetInvocationList().Select(x => x.Method.DeclaringType.FullName + "." + x.Method.Name));
}

        private void pnAbout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
