namespace PT4
{
    partial class ScreenEnd
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
            this.lblDeathComment = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblGameOverTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeathComment
            // 
            this.lblDeathComment.AutoSize = true;
            this.lblDeathComment.BackColor = System.Drawing.Color.Black;
            this.lblDeathComment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeathComment.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeathComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.lblDeathComment.Location = new System.Drawing.Point(322, 363);
            this.lblDeathComment.Name = "lblDeathComment";
            this.lblDeathComment.Size = new System.Drawing.Size(516, 33);
            this.lblDeathComment.TabIndex = 7;
            this.lblDeathComment.Text = "witty comment about players death (ha ha)";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(134)))), ((int)(((byte)(106)))));
            this.btnMainMenu.FlatAppearance.BorderSize = 2;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Felix Titling", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMainMenu.Location = new System.Drawing.Point(360, 512);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(435, 90);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblGameOverTitle
            // 
            this.lblGameOverTitle.AutoSize = true;
            this.lblGameOverTitle.BackColor = System.Drawing.Color.Black;
            this.lblGameOverTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGameOverTitle.Font = new System.Drawing.Font("Felix Titling", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.lblGameOverTitle.Location = new System.Drawing.Point(256, 245);
            this.lblGameOverTitle.Name = "lblGameOverTitle";
            this.lblGameOverTitle.Size = new System.Drawing.Size(634, 114);
            this.lblGameOverTitle.TabIndex = 5;
            this.lblGameOverTitle.Text = "Game Over";
            // 
            // ScreenEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PT4.Properties.Resources.endScreenBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblDeathComment);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lblGameOverTitle);
            this.Name = "ScreenEnd";
            this.Size = new System.Drawing.Size(1146, 840);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeathComment;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblGameOverTitle;
    }
}
