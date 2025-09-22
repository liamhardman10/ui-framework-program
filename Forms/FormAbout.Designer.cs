namespace ui_framework_program
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.panelTextBox = new System.Windows.Forms.Panel();
            this.labelAboutInfo = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.panelTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTextBox
            // 
            this.panelTextBox.BackColor = System.Drawing.Color.Transparent;
            this.panelTextBox.Controls.Add(this.labelAboutInfo);
            this.panelTextBox.Location = new System.Drawing.Point(12, 384);
            this.panelTextBox.Name = "panelTextBox";
            this.panelTextBox.Size = new System.Drawing.Size(809, 169);
            this.panelTextBox.TabIndex = 1;
            // 
            // labelAboutInfo
            // 
            this.labelAboutInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAboutInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAboutInfo.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutInfo.ForeColor = System.Drawing.Color.Linen;
            this.labelAboutInfo.Location = new System.Drawing.Point(0, 0);
            this.labelAboutInfo.Name = "labelAboutInfo";
            this.labelAboutInfo.Size = new System.Drawing.Size(809, 169);
            this.labelAboutInfo.TabIndex = 0;
            this.labelAboutInfo.Text = resources.GetString("labelAboutInfo.Text");
            this.labelAboutInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAboutInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BackgroundImage = global::ui_framework_program.Properties.Resources.logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Location = new System.Drawing.Point(18, 147);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(809, 243);
            this.panelLogo.TabIndex = 2;
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonReturn.Font = new System.Drawing.Font("Helvetica", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(387, 556);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(64, 23);
            this.buttonReturn.TabIndex = 3;
            this.buttonReturn.Text = "back";
            this.buttonReturn.UseVisualStyleBackColor = false;
            // 
            // FormAbout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::ui_framework_program.Properties.Resources.listformbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 729);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "about";
            this.panelTextBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTextBox;
        private System.Windows.Forms.Label labelAboutInfo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonReturn;
    }
}