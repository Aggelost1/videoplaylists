namespace playlists16
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.renameTextBox = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.modifyOff = new System.Windows.Forms.Button();
            this.saveAs = new System.Windows.Forms.Button();
            this.videolist = new System.Windows.Forms.ListBox();
            this.split = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "rename list";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "check";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // renameTextBox
            // 
            this.renameTextBox.Location = new System.Drawing.Point(429, 41);
            this.renameTextBox.Name = "renameTextBox";
            this.renameTextBox.Size = new System.Drawing.Size(120, 25);
            this.renameTextBox.TabIndex = 3;
            this.renameTextBox.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "video1",
            "video2",
            "video3",
            "video4",
            "video5",
            "video6",
            "video7",
            "video8",
            "video9",
            "video10",
            "video11",
            "video12",
            "video13",
            "video14",
            "video15",
            "video16",
            "video17",
            "video18",
            "video19",
            "video20"});
            this.checkedListBox1.Location = new System.Drawing.Point(429, 72);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 404);
            this.checkedListBox1.TabIndex = 6;
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(288, 164);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 56);
            this.button6.TabIndex = 7;
            this.button6.Text = "rename videos";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // modifyOff
            // 
            this.modifyOff.Location = new System.Drawing.Point(2, 159);
            this.modifyOff.Name = "modifyOff";
            this.modifyOff.Size = new System.Drawing.Size(75, 60);
            this.modifyOff.TabIndex = 8;
            this.modifyOff.Text = "revert to normal";
            this.modifyOff.UseVisualStyleBackColor = true;
            this.modifyOff.Click += new System.EventHandler(this.modifyOff_Click_1);
            // 
            // saveAs
            // 
            this.saveAs.Location = new System.Drawing.Point(288, 226);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(75, 60);
            this.saveAs.TabIndex = 9;
            this.saveAs.Text = "list save as";
            this.saveAs.UseVisualStyleBackColor = true;
            // 
            // videolist
            // 
            this.videolist.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.videolist.FormattingEnabled = true;
            this.videolist.ItemHeight = 20;
            this.videolist.Items.AddRange(new object[] {
            "video1",
            "video2",
            "video3",
            "video4",
            "video5",
            "video6",
            "video7",
            "video8",
            "video9",
            "video10",
            "video11",
            "video12",
            "video13",
            "video14",
            "video15",
            "video16",
            "video17",
            "video18",
            "video19",
            "video20"});
            this.videolist.Location = new System.Drawing.Point(429, 72);
            this.videolist.Name = "videolist";
            this.videolist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.videolist.Size = new System.Drawing.Size(173, 404);
            this.videolist.TabIndex = 10;
            // 
            // split
            // 
            this.split.Location = new System.Drawing.Point(288, 292);
            this.split.Name = "split";
            this.split.Size = new System.Drawing.Size(75, 81);
            this.split.TabIndex = 11;
            this.split.Text = "split into 20 item lists";
            this.split.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 515);
            this.Controls.Add(this.split);
            this.Controls.Add(this.videolist);
            this.Controls.Add(this.saveAs);
            this.Controls.Add(this.modifyOff);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.renameTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.renameTextBox, 0);
            this.Controls.SetChildIndex(this.checkedListBox1, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.modifyOff, 0);
            this.Controls.SetChildIndex(this.saveAs, 0);
            this.Controls.SetChildIndex(this.videolist, 0);
            this.Controls.SetChildIndex(this.split, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox renameTextBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button modifyOff;
        private System.Windows.Forms.Button saveAs;
        private System.Windows.Forms.ListBox videolist;
        private System.Windows.Forms.Button split;
    }
}