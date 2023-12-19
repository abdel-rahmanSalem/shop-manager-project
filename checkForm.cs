using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopManager
{
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();

            // Ensure that the entire application is closed when MyForm is closed
            this.FormClosed += (sender, e) => Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomepageForm home = new HomepageForm();
            this.Hide();
            home.Show();

        }
    }
}
