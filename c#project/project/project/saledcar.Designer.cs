namespace project
{
    partial class soldcar
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
            this.buttonSold = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSold
            // 
            this.buttonSold.BackColor = System.Drawing.Color.Red;
            this.buttonSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSold.Location = new System.Drawing.Point(280, 118);
            this.buttonSold.Name = "buttonSold";
            this.buttonSold.Size = new System.Drawing.Size(117, 37);
            this.buttonSold.TabIndex = 15;
            this.buttonSold.Text = "Sold";
            this.buttonSold.UseVisualStyleBackColor = false;
            this.buttonSold.Click += new System.EventHandler(this.buttonSold_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(280, 64);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(184, 34);
            this.textBoxId.TabIndex = 14;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(3, 64);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(241, 34);
            this.labelId.TabIndex = 13;
            this.labelId.Text = "User Phone Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(199, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sell Car";
            // 
            // soldcar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSold);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label1);
            this.Name = "soldcar";
            this.Size = new System.Drawing.Size(504, 185);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSold;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label1;
    }
}
