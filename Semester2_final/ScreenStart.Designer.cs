namespace PT4
{
    partial class ScreenStart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbPlaySelectedIcon = new System.Windows.Forms.PictureBox();
            this.pbLoadSelectedIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaySelectedIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadSelectedIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.FlatAppearance.BorderSize = 0;
            this.btnLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadGame.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.btnLoadGame.Location = new System.Drawing.Point(960, 743);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(183, 64);
            this.btnLoadGame.TabIndex = 5;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            this.btnLoadGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLoadGame_MouseDown);
            this.btnLoadGame.MouseEnter += new System.EventHandler(this.btnLoadGame_MouseEnter);
            this.btnLoadGame.MouseLeave += new System.EventHandler(this.btnLoadGame_MouseLeave);
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Felix Titling", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.lblGameTitle.Location = new System.Drawing.Point(81, 615);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(585, 112);
            this.lblGameTitle.TabIndex = 3;
            this.lblGameTitle.Text = "Roguelite";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.btnPlay.Location = new System.Drawing.Point(949, 662);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(188, 75);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPlay_MouseDown);
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnPlay_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            // 
            // pbPlaySelectedIcon
            // 
            this.pbPlaySelectedIcon.BackgroundImage = global::PT4.Properties.Resources.startScreenSelected;
            this.pbPlaySelectedIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlaySelectedIcon.Location = new System.Drawing.Point(936, 679);
            this.pbPlaySelectedIcon.Name = "pbPlaySelectedIcon";
            this.pbPlaySelectedIcon.Size = new System.Drawing.Size(33, 38);
            this.pbPlaySelectedIcon.TabIndex = 6;
            this.pbPlaySelectedIcon.TabStop = false;
            // 
            // pbLoadSelectedIcon
            // 
            this.pbLoadSelectedIcon.BackgroundImage = global::PT4.Properties.Resources.startScreenSelected;
            this.pbLoadSelectedIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLoadSelectedIcon.Location = new System.Drawing.Point(936, 760);
            this.pbLoadSelectedIcon.Name = "pbLoadSelectedIcon";
            this.pbLoadSelectedIcon.Size = new System.Drawing.Size(33, 38);
            this.pbLoadSelectedIcon.TabIndex = 7;
            this.pbLoadSelectedIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PT4.Properties.Resources.gameTitleUnderline;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(14, 708);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 47);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ScreenStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::PT4.Properties.Resources.startScreenBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbLoadSelectedIcon);
            this.Controls.Add(this.pbPlaySelectedIcon);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblGameTitle);
            this.DoubleBuffered = true;
            this.Name = "ScreenStart";
            this.Size = new System.Drawing.Size(1151, 848);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaySelectedIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadSelectedIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.PictureBox pbPlaySelectedIcon;
        private System.Windows.Forms.PictureBox pbLoadSelectedIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
