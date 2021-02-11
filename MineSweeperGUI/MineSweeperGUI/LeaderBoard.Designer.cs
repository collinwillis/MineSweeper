namespace MineSweeperGUI
{
    partial class LeaderBoard
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
            this.lst_easy = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lst_medium = new System.Windows.Forms.ListBox();
            this.lst_hard = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_easy
            // 
            this.lst_easy.FormattingEnabled = true;
            this.lst_easy.ItemHeight = 25;
            this.lst_easy.Location = new System.Drawing.Point(1, 88);
            this.lst_easy.Name = "lst_easy";
            this.lst_easy.Size = new System.Drawing.Size(316, 829);
            this.lst_easy.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 938);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 993);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lst_medium
            // 
            this.lst_medium.FormattingEnabled = true;
            this.lst_medium.ItemHeight = 25;
            this.lst_medium.Location = new System.Drawing.Point(353, 88);
            this.lst_medium.Name = "lst_medium";
            this.lst_medium.Size = new System.Drawing.Size(316, 829);
            this.lst_medium.TabIndex = 3;
            // 
            // lst_hard
            // 
            this.lst_hard.FormattingEnabled = true;
            this.lst_hard.ItemHeight = 25;
            this.lst_hard.Location = new System.Drawing.Point(707, 88);
            this.lst_hard.Name = "lst_hard";
            this.lst_hard.Size = new System.Drawing.Size(316, 829);
            this.lst_hard.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Easy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Medium";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(838, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hard";
            // 
            // LeaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 1060);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_hard);
            this.Controls.Add(this.lst_medium);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lst_easy);
            this.Name = "LeaderBoard";
            this.Text = "LeaderBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_easy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lst_medium;
        private System.Windows.Forms.ListBox lst_hard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}