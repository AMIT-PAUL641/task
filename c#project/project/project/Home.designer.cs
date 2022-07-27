namespace project
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.buttonsignin = new System.Windows.Forms.Button();
            this.buttonsignup = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(172, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Shop Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(233, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Password :";
            // 
            // textId
            // 
            this.textId.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(389, 145);
            this.textId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(130, 28);
            this.textId.TabIndex = 3;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // textpass
            // 
            this.textpass.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpass.Location = new System.Drawing.Point(389, 202);
            this.textpass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textpass.Name = "textpass";
            this.textpass.PasswordChar = '*';
            this.textpass.Size = new System.Drawing.Size(130, 28);
            this.textpass.TabIndex = 4;
            this.textpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonsignin
            // 
            this.buttonsignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsignin.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsignin.Location = new System.Drawing.Point(389, 275);
            this.buttonsignin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonsignin.Name = "buttonsignin";
            this.buttonsignin.Size = new System.Drawing.Size(87, 31);
            this.buttonsignin.TabIndex = 5;
            this.buttonsignin.Text = "Sign In";
            this.buttonsignin.UseVisualStyleBackColor = true;
            this.buttonsignin.Click += new System.EventHandler(this.buttonsignin_Click);
            // 
            // buttonsignup
            // 
            this.buttonsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsignup.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsignup.Location = new System.Drawing.Point(389, 333);
            this.buttonsignup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonsignup.Name = "buttonsignup";
            this.buttonsignup.Size = new System.Drawing.Size(87, 31);
            this.buttonsignup.TabIndex = 6;
            this.buttonsignup.Text = "Sign Up";
            this.buttonsignup.UseVisualStyleBackColor = true;
            this.buttonsignup.Click += new System.EventHandler(this.buttonsignup_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(766, 452);
            this.Controls.Add(this.buttonsignup);
            this.Controls.Add(this.buttonsignin);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHome";
            this.Text = " Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Button buttonsignin;
        private System.Windows.Forms.Button buttonsignup;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

