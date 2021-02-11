namespace MineSweeperGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdeo_easy = new System.Windows.Forms.RadioButton();
            this.rdeo_medium = new System.Windows.Forms.RadioButton();
            this.rdeo_hard = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdeo_hard);
            this.groupBox1.Controls.Add(this.rdeo_medium);
            this.groupBox1.Controls.Add(this.rdeo_easy);
            this.groupBox1.Location = new System.Drawing.Point(125, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Difficulty";
            // 
            // rdeo_easy
            // 
            this.rdeo_easy.AutoSize = true;
            this.rdeo_easy.Location = new System.Drawing.Point(138, 94);
            this.rdeo_easy.Name = "rdeo_easy";
            this.rdeo_easy.Size = new System.Drawing.Size(91, 29);
            this.rdeo_easy.TabIndex = 0;
            this.rdeo_easy.TabStop = true;
            this.rdeo_easy.Text = "Easy";
            this.rdeo_easy.UseVisualStyleBackColor = true;
            // 
            // rdeo_medium
            // 
            this.rdeo_medium.AutoSize = true;
            this.rdeo_medium.Location = new System.Drawing.Point(138, 161);
            this.rdeo_medium.Name = "rdeo_medium";
            this.rdeo_medium.Size = new System.Drawing.Size(119, 29);
            this.rdeo_medium.TabIndex = 1;
            this.rdeo_medium.TabStop = true;
            this.rdeo_medium.Text = "Medium";
            this.rdeo_medium.UseVisualStyleBackColor = true;
            // 
            // rdeo_hard
            // 
            this.rdeo_hard.AutoSize = true;
            this.rdeo_hard.Location = new System.Drawing.Point(138, 231);
            this.rdeo_hard.Name = "rdeo_hard";
            this.rdeo_hard.Size = new System.Drawing.Size(89, 29);
            this.rdeo_hard.TabIndex = 2;
            this.rdeo_hard.TabStop = true;
            this.rdeo_hard.Text = "Hard";
            this.rdeo_hard.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(535, 455);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(149, 59);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start Game";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 526);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdeo_hard;
        private System.Windows.Forms.RadioButton rdeo_medium;
        private System.Windows.Forms.RadioButton rdeo_easy;
        private System.Windows.Forms.Button btn_start;
    }
}

