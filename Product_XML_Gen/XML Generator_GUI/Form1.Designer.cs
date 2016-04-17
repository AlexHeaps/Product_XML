namespace XML_Generator_GUI
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
            this.Server_Input = new System.Windows.Forms.TextBox();
            this.Database_Input = new System.Windows.Forms.TextBox();
            this.Username_Input = new System.Windows.Forms.TextBox();
            this.Password_Input = new System.Windows.Forms.TextBox();
            this.Server_Name = new System.Windows.Forms.Label();
            this.DB_Name_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Server_Input
            // 
            this.Server_Input.Location = new System.Drawing.Point(145, 62);
            this.Server_Input.Name = "Server_Input";
            this.Server_Input.Size = new System.Drawing.Size(278, 22);
            this.Server_Input.TabIndex = 0;
            // 
            // Database_Input
            // 
            this.Database_Input.Location = new System.Drawing.Point(145, 100);
            this.Database_Input.Name = "Database_Input";
            this.Database_Input.Size = new System.Drawing.Size(278, 22);
            this.Database_Input.TabIndex = 1;
            // 
            // Username_Input
            // 
            this.Username_Input.Location = new System.Drawing.Point(145, 138);
            this.Username_Input.Name = "Username_Input";
            this.Username_Input.Size = new System.Drawing.Size(278, 22);
            this.Username_Input.TabIndex = 2;
            // 
            // Password_Input
            // 
            this.Password_Input.Location = new System.Drawing.Point(145, 178);
            this.Password_Input.Name = "Password_Input";
            this.Password_Input.Size = new System.Drawing.Size(278, 22);
            this.Password_Input.TabIndex = 3;
            // 
            // Server_Name
            // 
            this.Server_Name.AutoSize = true;
            this.Server_Name.Location = new System.Drawing.Point(27, 62);
            this.Server_Name.Name = "Server_Name";
            this.Server_Name.Size = new System.Drawing.Size(82, 17);
            this.Server_Name.TabIndex = 4;
            this.Server_Name.Text = "Server URL";
            // 
            // DB_Name_Label
            // 
            this.DB_Name_Label.AutoSize = true;
            this.DB_Name_Label.Location = new System.Drawing.Point(27, 100);
            this.DB_Name_Label.Name = "DB_Name_Label";
            this.DB_Name_Label.Size = new System.Drawing.Size(110, 17);
            this.DB_Name_Label.TabIndex = 5;
            this.DB_Name_Label.Text = "Database Name";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(27, 138);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(73, 17);
            this.Username_Label.TabIndex = 6;
            this.Username_Label.Text = "Username";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(27, 178);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(69, 17);
            this.Password_Label.TabIndex = 7;
            this.Password_Label.Text = "Password";
            // 
            // Connect_btn
            // 
            this.Connect_btn.Location = new System.Drawing.Point(186, 221);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(160, 42);
            this.Connect_btn.TabIndex = 8;
            this.Connect_btn.Text = "Connect";
            this.Connect_btn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 311);
            this.Controls.Add(this.Connect_btn);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.DB_Name_Label);
            this.Controls.Add(this.Server_Name);
            this.Controls.Add(this.Password_Input);
            this.Controls.Add(this.Username_Input);
            this.Controls.Add(this.Database_Input);
            this.Controls.Add(this.Server_Input);
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

        private System.Windows.Forms.TextBox Server_Input;
        private System.Windows.Forms.TextBox Database_Input;
        private System.Windows.Forms.TextBox Username_Input;
        private System.Windows.Forms.TextBox Password_Input;
        private System.Windows.Forms.Label Server_Name;
        private System.Windows.Forms.Label DB_Name_Label;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

