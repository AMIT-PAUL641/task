namespace project
{
    partial class Formsign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formsign));
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonsign = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(325, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please , Sign Up";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Red;
            this.labelName.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(253, 128);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(141, 34);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "User Name :";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.BackColor = System.Drawing.Color.Red;
            this.labelMobile.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobile.Location = new System.Drawing.Point(209, 240);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(185, 34);
            this.labelMobile.TabIndex = 2;
            this.labelMobile.Text = "Mobile Number :";
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.BackColor = System.Drawing.Color.Red;
            this.labeladdress.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdress.Location = new System.Drawing.Point(174, 296);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(220, 34);
            this.labeladdress.TabIndex = 3;
            this.labeladdress.Text = "Parmanent Address :";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxName.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(449, 128);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(210, 38);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxNum
            // 
            this.textBoxNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNum.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum.Location = new System.Drawing.Point(449, 240);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(210, 38);
            this.textBoxNum.TabIndex = 5;
            this.textBoxNum.TextChanged += new System.EventHandler(this.textBoxNum_TextChanged);
            this.textBoxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum_KeyPress);
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.BackColor = System.Drawing.Color.Red;
            this.Pass.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(217, 182);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(177, 34);
            this.Pass.TabIndex = 6;
            this.Pass.Text = "User Password :";
            // 
            // textBoxpass
            // 
            this.textBoxpass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxpass.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpass.Location = new System.Drawing.Point(449, 182);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.PasswordChar = '*';
            this.textBoxpass.Size = new System.Drawing.Size(210, 38);
            this.textBoxpass.TabIndex = 7;
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAdd.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdd.Location = new System.Drawing.Point(449, 296);
            this.textBoxAdd.Multiline = true;
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(327, 111);
            this.textBoxAdd.TabIndex = 8;
            // 
            // buttonsign
            // 
            this.buttonsign.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonsign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsign.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsign.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonsign.Location = new System.Drawing.Point(449, 426);
            this.buttonsign.Name = "buttonsign";
            this.buttonsign.Size = new System.Drawing.Size(117, 40);
            this.buttonsign.TabIndex = 9;
            this.buttonsign.Text = "Sign Up";
            this.buttonsign.UseVisualStyleBackColor = false;
            this.buttonsign.Click += new System.EventHandler(this.buttonsign_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Red;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(449, 488);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 41);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Formsign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1050, 619);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonsign);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Name = "Formsign";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.sign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonsign;
        private System.Windows.Forms.Button buttonBack;
    }
}