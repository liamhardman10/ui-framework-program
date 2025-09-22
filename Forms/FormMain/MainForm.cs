using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_framework_program
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            
            this.buttonGitHub.Click += new System.EventHandler(this.buttonGitHub_Click);
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            // cannot find a solution to the button's inoperability. i have tried 3 different solutions with no success.
            // will come back to this at a later time.
            // update a little while later : i hadn't wired my buttons to the event handlers.
            // fixed now, but keeping comment for debugging purposes.

            Process.Start(new ProcessStartInfo
            {
                FileName = "http://www.github.com/liamhardman10",
                UseShellExecute = true
            });
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // Only open if not already active
            if (!(activeForm is FormAbout))
            {
                openChildForm(new FormAbout());
                buttonAbout.Enabled = false; // Disable after opening
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        { 
            if (activeForm != null) // this needs to be fixed in the morning.
                buttonAbout.Enabled = true; // re-enable the button if FormAbout is closed
            activeForm.Close();  
        }


        private void buttonNewList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormNewList());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                // If closing FormAbout, re-enable the button
                if (activeForm is FormAbout)
                    buttonAbout.Enabled = true;

                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }






        private void customizeDesign()
        {
            // panelListSubMenu.Visible = false;
        
        }
    }
}
