namespace Game_Rock_Paper_Sissors
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
            this.Rock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Paper = new System.Windows.Forms.Button();
            this.Sissors = new System.Windows.Forms.Button();
            this.paly = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.Computer = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Rock
            // 
            this.Rock.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Rock.Location = new System.Drawing.Point(78, 448);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(150, 150);
            this.Rock.TabIndex = 0;
            this.Rock.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Paper
            // 
            this.Paper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Paper.Location = new System.Drawing.Point(299, 448);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(150, 150);
            this.Paper.TabIndex = 3;
            this.Paper.UseVisualStyleBackColor = false;
            // 
            // Sissors
            // 
            this.Sissors.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sissors.Location = new System.Drawing.Point(505, 448);
            this.Sissors.Name = "Sissors";
            this.Sissors.Size = new System.Drawing.Size(150, 150);
            this.Sissors.TabIndex = 4;
            this.Sissors.UseVisualStyleBackColor = false;
            // 
            // paly
            // 
            this.paly.Location = new System.Drawing.Point(257, 335);
            this.paly.Name = "paly";
            this.paly.Size = new System.Drawing.Size(148, 39);
            this.paly.TabIndex = 5;
            this.paly.Text = "button1";
            this.paly.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(60, 74);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(63, 25);
            this.User.TabIndex = 6;
            this.User.Text = "USER";
            // 
            // Computer
            // 
            this.Computer.AutoSize = true;
            this.Computer.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Computer.Location = new System.Drawing.Point(307, 73);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(118, 25);
            this.Computer.TabIndex = 7;
            this.Computer.Text = "COMPUTER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 634);
            this.Controls.Add(this.Computer);
            this.Controls.Add(this.User);
            this.Controls.Add(this.paly);
            this.Controls.Add(this.Sissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Sissors;
        private System.Windows.Forms.Button paly;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label Computer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

