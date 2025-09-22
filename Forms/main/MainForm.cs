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
            this.buttonNewList.Click += new System.EventHandler(this.buttonNewList_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        #region Main form-specific button events
        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            // cannot find a solution to the button's inoperability. i have tried 3 different solutions with no success.
            // will come back to this at a later time.
            // update a little while later : i hadn't wired my buttons to the event handlers.
            // fixed now, but keeping comment for debugging purposes.

            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/liamhardman10/ui-framework-program",
                UseShellExecute = true
            });
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            if (!(activeForm is FormAbout))
            {
                var aboutForm = new FormAbout();
                aboutForm.FormClosed += (s, args) =>
                {
                    buttonAbout.Enabled = true;
                    activeForm = null;
                };
                openChildForm(aboutForm);
                buttonAbout.Enabled = false;
            }
        }

        private void buttonNewList_Click(object sender, EventArgs e)
        {
            if (!(activeForm is FormNewList))
            {
                var listForm = new FormNewList();
                listForm.FormClosed += (s, args) =>
                {
                    buttonNewList.Enabled = true;
                    activeForm = null;
                };
                openChildForm(listForm);
                buttonNewList.Enabled = false;
            }
        }

        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
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
