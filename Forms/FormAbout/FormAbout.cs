using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_framework_program
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
        }

        private void textBoxAbout_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }
    }
}
