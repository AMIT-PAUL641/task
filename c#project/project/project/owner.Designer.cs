namespace project
{
    partial class FormOwner
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.dataGridViewmanager = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmanager)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.productToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 51);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allManagerToolStripMenuItem,
            this.deleteManagerToolStripMenuItem,
            this.deleteManagerToolStripMenuItem1});
            this.managerToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(139, 47);
            this.managerToolStripMenuItem.Text = "Manager";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // allManagerToolStripMenuItem
            // 
            this.allManagerToolStripMenuItem.Name = "allManagerToolStripMenuItem";
            this.allManagerToolStripMenuItem.Size = new System.Drawing.Size(295, 48);
            this.allManagerToolStripMenuItem.Text = "All Manager";
            this.allManagerToolStripMenuItem.Click += new System.EventHandler(this.allManagerToolStripMenuItem_Click);
            // 
            // deleteManagerToolStripMenuItem
            // 
            this.deleteManagerToolStripMenuItem.Name = "deleteManagerToolStripMenuItem";
            this.deleteManagerToolStripMenuItem.Size = new System.Drawing.Size(295, 48);
            this.deleteManagerToolStripMenuItem.Text = "Add Manager";
            this.deleteManagerToolStripMenuItem.Click += new System.EventHandler(this.deleteManagerToolStripMenuItem_Click);
            // 
            // deleteManagerToolStripMenuItem1
            // 
            this.deleteManagerToolStripMenuItem1.Name = "deleteManagerToolStripMenuItem1";
            this.deleteManagerToolStripMenuItem1.Size = new System.Drawing.Size(295, 48);
            this.deleteManagerToolStripMenuItem1.Text = "Delete Manager";
            this.deleteManagerToolStripMenuItem1.Click += new System.EventHandler(this.deleteManagerToolStripMenuItem1_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem1});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(151, 47);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(307, 48);
            this.addEmployeeToolStripMenuItem.Text = "All Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(307, 48);
            this.deleteEmployeeToolStripMenuItem.Text = "Add Employee";
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem1
            // 
            this.deleteEmployeeToolStripMenuItem1.Name = "deleteEmployeeToolStripMenuItem1";
            this.deleteEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(307, 48);
            this.deleteEmployeeToolStripMenuItem1.Text = "Delete Employee";
            this.deleteEmployeeToolStripMenuItem1.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem1_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProductToolStripMenuItem});
            this.productToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(73, 47);
            this.productToolStripMenuItem.Text = "Car";
            // 
            // allProductToolStripMenuItem
            // 
            this.allProductToolStripMenuItem.Name = "allProductToolStripMenuItem";
            this.allProductToolStripMenuItem.Size = new System.Drawing.Size(186, 48);
            this.allProductToolStripMenuItem.Text = "All Car";
            this.allProductToolStripMenuItem.Click += new System.EventHandler(this.allProductToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(89, 47);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Location = new System.Drawing.Point(580, 54);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(590, 247);
            this.panelAdd.TabIndex = 2;
            this.panelAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdd_Paint);
            // 
            // panelDelete
            // 
            this.panelDelete.Location = new System.Drawing.Point(580, 307);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(590, 231);
            this.panelDelete.TabIndex = 3;
            this.panelDelete.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDelete_Paint);
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
            this.dataGridViewmanager.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewmanager.Name = "dataGridViewmanager";
            this.dataGridViewmanager.RowTemplate.Height = 24;
            this.dataGridViewmanager.Size = new System.Drawing.Size(562, 554);
            this.dataGridViewmanager.TabIndex = 4;
            // 
            // FormOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 609);
            this.Controls.Add(this.dataGridViewmanager);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOwner";
            this.Text = "Owner";
            this.Load += new System.EventHandler(this.FormOwner_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmanager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteManagerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridViewmanager;
    }
}