namespace PT4
{
    partial class MainForm
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
            this.screenCombat = new PT4.ScreenCombat();
            this.screenStart = new PT4.ScreenStart();
            this.screenInventory = new PT4.ScreenInventory();
            this.screenEnd1 = new PT4.ScreenEnd();
            this.SuspendLayout();
            // 
            // screenCombat
            // 
            this.screenCombat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenCombat.Form = null;
            this.screenCombat.Location = new System.Drawing.Point(0, 0);
            this.screenCombat.Name = "screenCombat";
            this.screenCombat.Size = new System.Drawing.Size(1153, 833);
            this.screenCombat.TabIndex = 1;
            // 
            // screenStart
            // 
            this.screenStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenStart.Location = new System.Drawing.Point(0, 0);
            this.screenStart.Name = "screenStart";
            this.screenStart.Size = new System.Drawing.Size(1153, 833);
            this.screenStart.TabIndex = 0;
            // 
            // screenInventory
            // 
            this.screenInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenInventory.Location = new System.Drawing.Point(0, 0);
            this.screenInventory.Name = "screenInventory";
            this.screenInventory.Size = new System.Drawing.Size(1153, 833);
            this.screenInventory.TabIndex = 4;
            // 
            // screenEnd1
            // 
            this.screenEnd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenEnd1.Location = new System.Drawing.Point(0, 0);
            this.screenEnd1.Name = "screenEnd1";
            this.screenEnd1.Size = new System.Drawing.Size(1153, 833);
            this.screenEnd1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 833);
            this.Controls.Add(this.screenEnd1);
            this.Controls.Add(this.screenInventory);
            this.Controls.Add(this.screenCombat);
            this.Controls.Add(this.screenStart);
            this.Name = "MainForm";
            this.Text = "Roguelite";
            this.ResumeLayout(false);

        }

        #endregion

        private ScreenStart screenStart;
        private ScreenCombat screenCombat;
        private ScreenInventory screenInventory;
        private ScreenEnd screenEnd1;
    }
}