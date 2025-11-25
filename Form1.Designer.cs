namespace FinanzIA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDashboar = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnSub1 = new System.Windows.Forms.Button();
            this.btnSub2 = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.btnset = new System.Windows.Forms.Button();
            this.pnAbout = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnDashboar.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.pnAbout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "FINANZIA | MODERN SIDEBAR";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(6, 3);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(45, 40);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 0;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.pnDashboar);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.pnAbout);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Controls.Add(this.pnSettings);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 46);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(216, 481);
            this.sidebar.TabIndex = 1;
            // 
            // pnDashboar
            // 
            this.pnDashboar.Controls.Add(this.btnDashboard);
            this.pnDashboar.Location = new System.Drawing.Point(3, 33);
            this.pnDashboar.Name = "pnDashboar";
            this.pnDashboar.Size = new System.Drawing.Size(213, 44);
            this.pnDashboar.TabIndex = 3;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Black;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-5, -7);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(229, 61);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "        Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.Black;
            this.menuContainer.Controls.Add(this.btnmenu);
            this.menuContainer.Controls.Add(this.btnSub1);
            this.menuContainer.Controls.Add(this.btnSub2);
            this.menuContainer.Location = new System.Drawing.Point(3, 83);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(213, 185);
            this.menuContainer.TabIndex = 5;
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.Black;
            this.btnmenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.ForeColor = System.Drawing.Color.White;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenu.Location = new System.Drawing.Point(0, 0);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnmenu.Size = new System.Drawing.Size(229, 61);
            this.btnmenu.TabIndex = 7;
            this.btnmenu.Text = "        Menu";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.menu_Click);
            // 
            // btnSub1
            // 
            this.btnSub1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSub1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub1.ForeColor = System.Drawing.Color.White;
            this.btnSub1.Image = ((System.Drawing.Image)(resources.GetObject("btnSub1.Image")));
            this.btnSub1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSub1.Location = new System.Drawing.Point(0, 61);
            this.btnSub1.Margin = new System.Windows.Forms.Padding(0);
            this.btnSub1.Name = "btnSub1";
            this.btnSub1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSub1.Size = new System.Drawing.Size(229, 61);
            this.btnSub1.TabIndex = 6;
            this.btnSub1.Text = "        Sub Menu 1";
            this.btnSub1.UseVisualStyleBackColor = false;
            this.btnSub1.Click += new System.EventHandler(this.submenu1_Click);
            // 
            // btnSub2
            // 
            this.btnSub2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSub2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub2.ForeColor = System.Drawing.Color.White;
            this.btnSub2.Image = ((System.Drawing.Image)(resources.GetObject("btnSub2.Image")));
            this.btnSub2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSub2.Location = new System.Drawing.Point(0, 122);
            this.btnSub2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSub2.Size = new System.Drawing.Size(229, 61);
            this.btnSub2.TabIndex = 7;
            this.btnSub2.Text = "        Sub Menu 2";
            this.btnSub2.UseVisualStyleBackColor = false;
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(3, 374);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(213, 44);
            this.pnLogout.TabIndex = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-8, -9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(229, 61);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "        Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnSettings
            // 
            this.pnSettings.Controls.Add(this.btnset);
            this.pnSettings.Location = new System.Drawing.Point(3, 424);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(213, 44);
            this.pnSettings.TabIndex = 9;
            // 
            // btnset
            // 
            this.btnset.BackColor = System.Drawing.Color.Black;
            this.btnset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnset.ForeColor = System.Drawing.Color.White;
            this.btnset.Image = ((System.Drawing.Image)(resources.GetObject("btnset.Image")));
            this.btnset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnset.Location = new System.Drawing.Point(-8, -6);
            this.btnset.Name = "btnset";
            this.btnset.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnset.Size = new System.Drawing.Size(229, 61);
            this.btnset.TabIndex = 2;
            this.btnset.Text = "        Settings";
            this.btnset.UseVisualStyleBackColor = false;
            // 
            // pnAbout
            // 
            this.pnAbout.Controls.Add(this.button6);
            this.pnAbout.Location = new System.Drawing.Point(3, 274);
            this.pnAbout.Name = "pnAbout";
            this.pnAbout.Size = new System.Drawing.Size(213, 44);
            this.pnAbout.TabIndex = 8;
            this.pnAbout.Paint += new System.Windows.Forms.PaintEventHandler(this.pnAbout_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-9, -8);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(229, 61);
            this.button6.TabIndex = 6;
            this.button6.Text = "        About";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 44);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-9, -7);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(229, 61);
            this.button1.TabIndex = 10;
            this.button1.Text = "        About";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnDashboar.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.pnAbout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnDashboar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Button btnSub2;
        private System.Windows.Forms.Button btnSub1;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Panel pnAbout;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}