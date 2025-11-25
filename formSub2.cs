using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzIA
{
    public partial class formSub2 : Form
    {
        public formSub2()
        {
            InitializeComponent();
        }

        private void formSubmenu2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeChild_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizeChild_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void formSub2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
