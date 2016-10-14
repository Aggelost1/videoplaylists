namespace playlists16
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
            this.modifyBottun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifyBottun
            // 
            this.modifyBottun.Location = new System.Drawing.Point(2, 159);
            this.modifyBottun.Name = "modifyBottun";
            this.modifyBottun.Size = new System.Drawing.Size(75, 23);
            this.modifyBottun.TabIndex = 5;
            this.modifyBottun.Text = "modify";
            this.modifyBottun.UseVisualStyleBackColor = true;
            this.modifyBottun.Click += new System.EventHandler(this.modifyBottun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.modifyBottun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.modifyBottun, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyBottun;
    }
}