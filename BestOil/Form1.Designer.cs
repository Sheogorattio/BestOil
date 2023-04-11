namespace BestOil
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
            this.PetrolButton = new System.Windows.Forms.Button();
            this.CafeButton = new System.Windows.Forms.Button();
            this.TotalButton = new System.Windows.Forms.Button();
            this.EditData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PetrolButton
            // 
            this.PetrolButton.Location = new System.Drawing.Point(64, 40);
            this.PetrolButton.Name = "PetrolButton";
            this.PetrolButton.Size = new System.Drawing.Size(196, 76);
            this.PetrolButton.TabIndex = 0;
            this.PetrolButton.Text = "Petrol station";
            this.PetrolButton.UseVisualStyleBackColor = true;
            this.PetrolButton.Click += new System.EventHandler(this.PetrolButton_Click);
            // 
            // CafeButton
            // 
            this.CafeButton.Location = new System.Drawing.Point(64, 122);
            this.CafeButton.Name = "CafeButton";
            this.CafeButton.Size = new System.Drawing.Size(196, 76);
            this.CafeButton.TabIndex = 0;
            this.CafeButton.Text = "Cafe";
            this.CafeButton.UseVisualStyleBackColor = true;
            this.CafeButton.Click += new System.EventHandler(this.CafeButton_Click);
            // 
            // TotalButton
            // 
            this.TotalButton.Location = new System.Drawing.Point(64, 204);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(196, 76);
            this.TotalButton.TabIndex = 0;
            this.TotalButton.Text = "Get Total";
            this.TotalButton.UseVisualStyleBackColor = true;
            this.TotalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // EditData
            // 
            this.EditData.Location = new System.Drawing.Point(120, 305);
            this.EditData.Name = "EditData";
            this.EditData.Size = new System.Drawing.Size(75, 23);
            this.EditData.TabIndex = 1;
            this.EditData.Text = "Edit Data";
            this.EditData.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(345, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.exitToolStripMenuItem.Text = "About";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 340);
            this.Controls.Add(this.EditData);
            this.Controls.Add(this.TotalButton);
            this.Controls.Add(this.CafeButton);
            this.Controls.Add(this.PetrolButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PetrolButton;
        private System.Windows.Forms.Button CafeButton;
        private System.Windows.Forms.Button TotalButton;
        private System.Windows.Forms.Button EditData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

