namespace matchingGame
{
    partial class Victory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Victory));
            this.restart_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restart_button
            // 
            this.restart_button.Location = new System.Drawing.Point(407, 430);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(171, 39);
            this.restart_button.TabIndex = 0;
            this.restart_button.Text = "RESTART";
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // Victory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(967, 502);
            this.Controls.Add(this.restart_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Victory";
            this.Text = "Victory";
            this.ResumeLayout(false);
            this.CenterToScreen();

        }

        #endregion

        private System.Windows.Forms.Button restart_button;
    }
}