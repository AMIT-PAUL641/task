namespace project
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewmanager = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.availabletextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVill = new System.Windows.Forms.Label();
            this.detailstextbox = new System.Windows.Forms.TextBox();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.buttonBook = new System.Windows.Forms.Button();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmanager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 49);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 45);
            this.toolStripMenuItem1.Text = "Car List";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Red;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(96, 45);
            this.toolStripMenuItem2.Text = "Back";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // dataGridViewmanager
            // 
            this.dataGridViewmanager.AllowUserToDeleteRows = false;
            this.dataGridViewmanager.AllowUserToResizeColumns = false;
            this.dataGridViewmanager.AllowUserToResizeRows = false;
            this.dataGridViewmanager.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewmanager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewmanager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmanager.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridViewmanager.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewmanager.Name = "dataGridViewmanager";
            this.dataGridViewmanager.RowTemplate.Height = 24;
            this.dataGridViewmanager.Size = new System.Drawing.Size(562, 507);
            this.dataGridViewmanager.TabIndex = 5;
            this.dataGridViewmanager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewmanager_CellContentClick);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.Red;
            this.Name.Location = new System.Drawing.Point(674, 9);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(164, 34);
            this.Name.TabIndex = 6;
            this.Name.Text = "Search Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(868, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 30);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(704, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(868, 57);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 30);
            this.textBox2.TabIndex = 9;
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(1065, 9);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(75, 30);
            this.buttonsearch.TabIndex = 10;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1065, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // availabletextbox
            // 
            this.availabletextbox.Location = new System.Drawing.Point(904, 508);
            this.availabletextbox.Multiline = true;
            this.availabletextbox.Name = "availabletextbox";
            this.availabletextbox.Size = new System.Drawing.Size(185, 31);
            this.availabletextbox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Available :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(755, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // labelVill
            // 
            this.labelVill.AutoSize = true;
            this.labelVill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVill.Location = new System.Drawing.Point(989, 447);
            this.labelVill.Name = "labelVill";
            this.labelVill.Size = new System.Drawing.Size(82, 25);
            this.labelVill.TabIndex = 44;
            this.labelVill.Text = "Details :";
            // 
            // detailstextbox
            // 
            this.detailstextbox.Location = new System.Drawing.Point(1087, 428);
            this.detailstextbox.Multiline = true;
            this.detailstextbox.Name = "detailstextbox";
            this.detailstextbox.Size = new System.Drawing.Size(185, 56);
            this.detailstextbox.TabIndex = 43;
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(702, 441);
            this.pricetextbox.Multiline = true;
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(185, 31);
            this.pricetextbox.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(614, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Price :";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(614, 382);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(75, 25);
            this.labelNum.TabIndex = 40;
            this.labelNum.Text = "Name :";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(702, 386);
            this.nametextbox.Multiline = true;
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(185, 31);
            this.nametextbox.TabIndex = 39;
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.Red;
            this.buttonBook.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBook.Location = new System.Drawing.Point(904, 560);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(139, 34);
            this.buttonBook.TabIndex = 38;
            this.buttonBook.Text = "Booked";
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(1087, 386);
            this.idtextBox.Multiline = true;
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(185, 31);
            this.idtextBox.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1029, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "ID :";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 606);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.availabletextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelVill);
            this.Controls.Add(this.detailstextbox);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.dataGridViewmanager);
            this.Controls.Add(this.menuStrip1);
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmanager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridViewmanager;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox availabletextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelVill;
        private System.Windows.Forms.TextBox detailstextbox;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label label4;

    }
}