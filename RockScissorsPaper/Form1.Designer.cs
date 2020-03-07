namespace RockScissorsPaper
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
            this.labPlayer = new System.Windows.Forms.Label();
            this.labComputer = new System.Windows.Forms.Label();
            this.labPlayerScore = new System.Windows.Forms.Label();
            this.picBoxPlayer = new System.Windows.Forms.PictureBox();
            this.picBoxComp = new System.Windows.Forms.PictureBox();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.btnCredits = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labComputerScore = new System.Windows.Forms.Label();
            this.labDraw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComp)).BeginInit();
            this.SuspendLayout();
            // 
            // labPlayer
            // 
            this.labPlayer.AutoSize = true;
            this.labPlayer.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlayer.Location = new System.Drawing.Point(55, 49);
            this.labPlayer.Name = "labPlayer";
            this.labPlayer.Size = new System.Drawing.Size(179, 85);
            this.labPlayer.TabIndex = 0;
            this.labPlayer.Text = "Player";
            // 
            // labComputer
            // 
            this.labComputer.AutoSize = true;
            this.labComputer.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labComputer.Location = new System.Drawing.Point(488, 49);
            this.labComputer.Name = "labComputer";
            this.labComputer.Size = new System.Drawing.Size(245, 85);
            this.labComputer.TabIndex = 1;
            this.labComputer.Text = "Computer";
            // 
            // labPlayerScore
            // 
            this.labPlayerScore.AutoSize = true;
            this.labPlayerScore.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlayerScore.Location = new System.Drawing.Point(268, 9);
            this.labPlayerScore.Name = "labPlayerScore";
            this.labPlayerScore.Size = new System.Drawing.Size(67, 75);
            this.labPlayerScore.TabIndex = 2;
            this.labPlayerScore.Text = "0";
            // 
            // picBoxPlayer
            // 
            this.picBoxPlayer.Image = global::RockScissorsPaper.Properties.Resources.stringReady;
            this.picBoxPlayer.Location = new System.Drawing.Point(50, 146);
            this.picBoxPlayer.Name = "picBoxPlayer";
            this.picBoxPlayer.Size = new System.Drawing.Size(244, 170);
            this.picBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayer.TabIndex = 3;
            this.picBoxPlayer.TabStop = false;
            // 
            // picBoxComp
            // 
            this.picBoxComp.Image = global::RockScissorsPaper.Properties.Resources.stringReady;
            this.picBoxComp.Location = new System.Drawing.Point(489, 146);
            this.picBoxComp.Name = "picBoxComp";
            this.picBoxComp.Size = new System.Drawing.Size(244, 170);
            this.picBoxComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxComp.TabIndex = 4;
            this.picBoxComp.TabStop = false;
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(94, 350);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(127, 50);
            this.btnRock.TabIndex = 5;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(324, 350);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(127, 50);
            this.btnScissors.TabIndex = 6;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(548, 350);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(127, 50);
            this.btnPaper.TabIndex = 7;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labResult.Location = new System.Drawing.Point(357, 181);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(0, 44);
            this.labResult.TabIndex = 8;
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(703, 415);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(85, 23);
            this.btnCredits.TabIndex = 9;
            this.btnCredits.Text = "Images author";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(357, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = ":";
            // 
            // labComputerScore
            // 
            this.labComputerScore.AutoSize = true;
            this.labComputerScore.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labComputerScore.Location = new System.Drawing.Point(415, 9);
            this.labComputerScore.Name = "labComputerScore";
            this.labComputerScore.Size = new System.Drawing.Size(67, 75);
            this.labComputerScore.TabIndex = 11;
            this.labComputerScore.Text = "0";
            // 
            // labDraw
            // 
            this.labDraw.AutoSize = true;
            this.labDraw.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDraw.Location = new System.Drawing.Point(315, 249);
            this.labDraw.Name = "labDraw";
            this.labDraw.Size = new System.Drawing.Size(0, 46);
            this.labDraw.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labDraw);
            this.Controls.Add(this.labComputerScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.picBoxComp);
            this.Controls.Add(this.picBoxPlayer);
            this.Controls.Add(this.labPlayerScore);
            this.Controls.Add(this.labComputer);
            this.Controls.Add(this.labPlayer);
            this.Name = "Form1";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPlayer;
        private System.Windows.Forms.Label labComputer;
        private System.Windows.Forms.Label labPlayerScore;
        private System.Windows.Forms.PictureBox picBoxPlayer;
        private System.Windows.Forms.PictureBox picBoxComp;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labComputerScore;
        private System.Windows.Forms.Label labDraw;
    }
}

