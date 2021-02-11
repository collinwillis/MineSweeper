namespace MineSweeperGUI
{
    partial class MineForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeTracker = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(87, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 1118);
            this.panel1.TabIndex = 0;
            // 
            // timeTracker
            // 
            this.timeTracker.AutoSize = true;
            this.timeTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTracker.Location = new System.Drawing.Point(87, 44);
            this.timeTracker.Name = "timeTracker";
            this.timeTracker.Size = new System.Drawing.Size(105, 31);
            this.timeTracker.TabIndex = 1;
            this.timeTracker.Text = "0:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1120, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(1208, 44);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(29, 31);
            this.lbl_score.TabIndex = 3;
            this.lbl_score.Text = "0";
            // 
            // MineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 1231);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeTracker);
            this.Controls.Add(this.panel1);
            this.Name = "MineForm";
            this.Text = "MineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeTracker;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_score;
    }
}