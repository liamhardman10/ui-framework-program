using System.Drawing;
using System.Windows.Forms;

namespace ui_framework_program
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.buttonGitHub = new System.Windows.Forms.Button();
            this.buttonMyLists = new System.Windows.Forms.Button();
            this.buttonNewList = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.Black;
            this.panelSideBar.BackgroundImage = global::ui_framework_program.Properties.Resources.sidebarbg;
            this.panelSideBar.Controls.Add(this.buttonGitHub);
            this.panelSideBar.Controls.Add(this.buttonMyLists);
            this.panelSideBar.Controls.Add(this.buttonNewList);
            this.panelSideBar.Controls.Add(this.buttonAbout);
            this.panelSideBar.Controls.Add(this.panelLogo);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.ForeColor = System.Drawing.Color.Black;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(175, 729);
            this.panelSideBar.TabIndex = 0;
            this.panelSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonGitHub
            // 
            this.buttonGitHub.BackColor = System.Drawing.Color.Transparent;
            this.buttonGitHub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonGitHub.FlatAppearance.BorderSize = 0;
            this.buttonGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGitHub.Image = global::ui_framework_program.Properties.Resources.github;
            this.buttonGitHub.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGitHub.Location = new System.Drawing.Point(0, 641);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(175, 45);
            this.buttonGitHub.TabIndex = 4;
            this.buttonGitHub.Text = "GitHub";
            this.buttonGitHub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGitHub.UseVisualStyleBackColor = false;
            // 
            // buttonMyLists
            // 
            this.buttonMyLists.BackColor = System.Drawing.Color.Transparent;
            this.buttonMyLists.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMyLists.FlatAppearance.BorderSize = 0;
            this.buttonMyLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyLists.Font = new System.Drawing.Font("Helvetica", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyLists.Location = new System.Drawing.Point(0, 145);
            this.buttonMyLists.Name = "buttonMyLists";
            this.buttonMyLists.Size = new System.Drawing.Size(175, 45);
            this.buttonMyLists.TabIndex = 3;
            this.buttonMyLists.Text = "+ saved lists (WIP)";
            this.buttonMyLists.UseVisualStyleBackColor = false;
            // 
            // buttonNewList
            // 
            this.buttonNewList.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNewList.FlatAppearance.BorderSize = 0;
            this.buttonNewList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewList.Font = new System.Drawing.Font("Helvetica", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewList.Location = new System.Drawing.Point(0, 100);
            this.buttonNewList.Name = "buttonNewList";
            this.buttonNewList.Size = new System.Drawing.Size(175, 45);
            this.buttonNewList.TabIndex = 2;
            this.buttonNewList.Text = "+ new list";
            this.buttonNewList.UseVisualStyleBackColor = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Helvetica", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.Black;
            this.buttonAbout.Location = new System.Drawing.Point(0, 686);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(175, 43);
            this.buttonAbout.TabIndex = 1;
            this.buttonAbout.Text = "about glace";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BackgroundImage = global::ui_framework_program.Properties.Resources.logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.Black;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(175, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChild
            // 
            this.panelChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChild.BackColor = System.Drawing.Color.Transparent;
            this.panelChild.BackgroundImage = global::ui_framework_program.Properties.Resources.mainbg;
            this.panelChild.Location = new System.Drawing.Point(175, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(833, 729);
            this.panelChild.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ui_framework_program.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelSideBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "mainForm";
            this.RightToLeftLayout = true;
            this.Text = "glace";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonNewList;
        private System.Windows.Forms.Button buttonMyLists;
        private System.Windows.Forms.Button buttonGitHub;
        private Panel panelChild;
    }
}

