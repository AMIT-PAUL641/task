namespace project
{
    partial class AddEmployee
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
            this.labelVill = new System.Windows.Forms.Label();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.textBoxnid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.textBoxPhn = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVill
            // 
            this.labelVill.AutoSize = true;
            this.labelVill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVill.Location = new System.Drawing.Point(382, 44);
            this.labelVill.Name = "labelVill";
            this.labelVill.Size = new System.Drawing.Size(96, 25);
            this.labelVill.TabIndex = 19;
            this.labelVill.Text = "Address :";
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(387, 82);
            this.textBoxAdd.Multiline = true;
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(185, 109);
            this.textBoxAdd.TabIndex = 18;
            // 
            // textBoxnid
            // 
            this.textBoxnid.Location = new System.Drawing.Point(148, 160);
            this.textBoxnid.Multiline = true;
            this.textBoxnid.Name = "textBoxnid";
            this.textBoxnid.Size = new System.Drawing.Size(185, 31);
            this.textBoxnid.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "NID Number :";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(26, 112);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(114, 25);
            this.labelNum.TabIndex = 15;
            this.labelNum.Text = "M.Number :";
            // 
            // textBoxPhn
            // 
            this.textBoxPhn.Location = new System.Drawing.Point(148, 112);
            this.textBoxPhn.Multiline = true;
            this.textBoxPhn.Name = "textBoxPhn";
            this.textBoxPhn.Size = new System.Drawing.Size(185, 31);
            this.textBoxPhn.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(148, 66);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(185, 31);
            this.textBoxName.TabIndex = 13;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(65, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 25);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name :";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelAdd.Location = new System.Drawing.Point(215, 3);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(169, 34);
            this.labelAdd.TabIndex = 11;
            this.labelAdd.Text = "Add Employee";
            this.labelAdd.Click += new System.EventHandler(this.labelAdd_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Red;
            this.buttonAdd.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(303, 213);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 34);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelVill);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.textBoxnid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.textBoxPhn);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(590, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVill;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.TextBox textBoxnid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textBoxPhn;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Button buttonAdd;
    }
}
