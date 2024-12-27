namespace AircraftShootingGameee
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
            this.components = new System.ComponentModel.Container();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyAircraft1 = new System.Windows.Forms.PictureBox();
            this.playerAircraft1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemyAircraft1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerAircraft1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Violet;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(99, 289);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 70);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Violet;
            this.lblScore.Location = new System.Drawing.Point(10, 10);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(88, 24);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Violet;
            this.lblGameOver.Location = new System.Drawing.Point(37, 221);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(299, 24);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Text = "Game Over!  Press R to Restart";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // enemyTimer
            // 
            this.enemyTimer.Interval = 2000;
            this.enemyTimer.Tick += new System.EventHandler(this.EnemyTimer_Tick);
            // 
            // enemyAircraft1
            // 
            this.enemyAircraft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.enemyAircraft1.Image = global::AircraftShootingGameee.Properties.Resources.enemyAircraft;
            this.enemyAircraft1.Location = new System.Drawing.Point(155, 22);
            this.enemyAircraft1.Name = "enemyAircraft1";
            this.enemyAircraft1.Size = new System.Drawing.Size(50, 50);
            this.enemyAircraft1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyAircraft1.TabIndex = 4;
            this.enemyAircraft1.TabStop = false;
            this.enemyAircraft1.Visible = false;
            // 
            // playerAircraft1
            // 
            this.playerAircraft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.playerAircraft1.Image = global::AircraftShootingGameee.Properties.Resources.playerAircraft;
            this.playerAircraft1.Location = new System.Drawing.Point(155, 494);
            this.playerAircraft1.Name = "playerAircraft1";
            this.playerAircraft1.Size = new System.Drawing.Size(60, 60);
            this.playerAircraft1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerAircraft1.TabIndex = 3;
            this.playerAircraft1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(381, 566);
            this.Controls.Add(this.enemyAircraft1);
            this.Controls.Add(this.playerAircraft1);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnRestart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.enemyAircraft1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerAircraft1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer enemyTimer;
        private System.Windows.Forms.PictureBox playerAircraft1;
        private System.Windows.Forms.PictureBox enemyAircraft1;
    }
}

