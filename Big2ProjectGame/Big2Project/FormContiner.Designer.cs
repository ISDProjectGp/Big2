using System.Windows.Forms;

namespace Big2GameApplication
{
    partial class FormContiner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContiner));
            this.uc = new Big2GameApplication.UserControl1();
            this.SuspendLayout();
            // 
            // uc
            // 
            this.uc.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.uc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uc.BackgroundImage")));
            this.uc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc.Location = new System.Drawing.Point(0, 0);
            this.uc.Name = "uc";
            this.uc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uc.Size = new System.Drawing.Size(1914, 1045);
            this.uc.TabIndex = 0;
            this.uc.Load += new System.EventHandler(this.PageLoad);
            // 
            // FormContiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1045);
            this.Controls.Add(this.uc);
            this.Name = "FormContiner";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

    }
}