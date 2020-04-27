namespace _PresentationLayer.Forms.Functions
{
    partial class RolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFormAdi = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.pnlTc = new System.Windows.Forms.Panel();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.dgvRoles = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorizedNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormAdi
            // 
            this.lblFormAdi.AutoSize = true;
            this.lblFormAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormAdi.ForeColor = System.Drawing.Color.White;
            this.lblFormAdi.Location = new System.Drawing.Point(16, 18);
            this.lblFormAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormAdi.Name = "lblFormAdi";
            this.lblFormAdi.Size = new System.Drawing.Size(112, 24);
            this.lblFormAdi.TabIndex = 2;
            this.lblFormAdi.Text = "Rol İşlemleri";
            this.lblFormAdi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFormAdi_MouseDown);
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(1027, 15);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(37, 37);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.FlatAppearance.BorderSize = 0;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKucult.ForeColor = System.Drawing.Color.White;
            this.btnKucult.Location = new System.Drawing.Point(983, 7);
            this.btnKucult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(37, 37);
            this.btnKucult.TabIndex = 0;
            this.btnKucult.Text = "_";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // pnlKontrol
            // 
            this.pnlKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlKontrol.Controls.Add(this.lblFormAdi);
            this.pnlKontrol.Controls.Add(this.btnKapat);
            this.pnlKontrol.Controls.Add(this.btnKucult);
            this.pnlKontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlKontrol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKontrol.Name = "pnlKontrol";
            this.pnlKontrol.Size = new System.Drawing.Size(1080, 55);
            this.pnlKontrol.TabIndex = 179;
            this.pnlKontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlKontrol_MouseDown);
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoleName.ForeColor = System.Drawing.Color.White;
            this.lblRoleName.Location = new System.Drawing.Point(36, 146);
            this.lblRoleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(91, 24);
            this.lblRoleName.TabIndex = 191;
            this.lblRoleName.Text = "Rol İsmi : ";
            // 
            // pnlTc
            // 
            this.pnlTc.BackColor = System.Drawing.Color.White;
            this.pnlTc.ForeColor = System.Drawing.Color.White;
            this.pnlTc.Location = new System.Drawing.Point(179, 167);
            this.pnlTc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTc.Name = "pnlTc";
            this.pnlTc.Size = new System.Drawing.Size(269, 1);
            this.pnlTc.TabIndex = 189;
            // 
            // txtRoleName
            // 
            this.txtRoleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtRoleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRoleName.ForeColor = System.Drawing.Color.White;
            this.txtRoleName.Location = new System.Drawing.Point(180, 142);
            this.txtRoleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(269, 19);
            this.txtRoleName.TabIndex = 187;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "add.png");
            this.ImageList1.Images.SetKeyName(1, "delete.png");
            this.ImageList1.Images.SetKeyName(2, "update.png");
            this.ImageList1.Images.SetKeyName(3, "search.png");
            this.ImageList1.Images.SetKeyName(4, "print.png");
            // 
            // btSearch
            // 
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.ImageKey = "search.png";
            this.btSearch.ImageList = this.ImageList1;
            this.btSearch.Location = new System.Drawing.Point(20, 358);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(60, 46);
            this.btSearch.TabIndex = 293;
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(87, 377);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 24);
            this.lblSearch.TabIndex = 292;
            this.lblSearch.Text = "Ara:";
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.White;
            this.pnl5.ForeColor = System.Drawing.Color.White;
            this.pnl5.Location = new System.Drawing.Point(171, 402);
            this.pnl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(269, 1);
            this.pnl5.TabIndex = 291;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(171, 377);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(269, 19);
            this.txtSearch.TabIndex = 290;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.ImageKey = "delete.png";
            this.btnDelete.ImageList = this.ImageList1;
            this.btnDelete.Location = new System.Drawing.Point(685, 261);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(335, 58);
            this.btnDelete.TabIndex = 296;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.ImageKey = "add.png";
            this.btnAdd.ImageList = this.ImageList1;
            this.btnAdd.Location = new System.Drawing.Point(685, 129);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(335, 58);
            this.btnAdd.TabIndex = 295;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.ImageKey = "update.png";
            this.BtnUpdate.ImageList = this.ImageList1;
            this.BtnUpdate.Location = new System.Drawing.Point(685, 196);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(335, 58);
            this.BtnUpdate.TabIndex = 297;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dgvRoles
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoles.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoles.ColumnHeadersHeight = 40;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleId,
            this.EmployeePayments,
            this.Employees,
            this.AuthorizedNumbers,
            this.RoleName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRoles.DoubleBuffered = true;
            this.dgvRoles.EnableHeadersVisualStyles = false;
            this.dgvRoles.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dgvRoles.HeaderForeColor = System.Drawing.Color.White;
            this.dgvRoles.Location = new System.Drawing.Point(0, 458);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRoles.RowHeadersVisible = false;
            this.dgvRoles.RowTemplate.DividerHeight = 1;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(1080, 356);
            this.dgvRoles.TabIndex = 298;
            this.dgvRoles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_RowEnter);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(179, 235);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(269, 19);
            this.txtId.TabIndex = 299;
            this.txtId.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.ImageKey = "print.png";
            this.btnPrint.ImageList = this.ImageList1;
            this.btnPrint.Location = new System.Drawing.Point(863, 393);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(157, 58);
            this.btnPrint.TabIndex = 324;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // RoleId
            // 
            this.RoleId.DataPropertyName = "RoleId";
            this.RoleId.HeaderText = "Id";
            this.RoleId.Name = "RoleId";
            // 
            // EmployeePayments
            // 
            this.EmployeePayments.DataPropertyName = "EmployeePayments";
            this.EmployeePayments.HeaderText = "EmployeePayments";
            this.EmployeePayments.Name = "EmployeePayments";
            this.EmployeePayments.Visible = false;
            // 
            // Employees
            // 
            this.Employees.DataPropertyName = "Employees";
            this.Employees.HeaderText = "Employees";
            this.Employees.Name = "Employees";
            this.Employees.Visible = false;
            // 
            // AuthorizedNumbers
            // 
            this.AuthorizedNumbers.DataPropertyName = "AuthorizedNumbers";
            this.AuthorizedNumbers.HeaderText = "AuthorizedNumbers";
            this.AuthorizedNumbers.Name = "AuthorizedNumbers";
            this.AuthorizedNumbers.Visible = false;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "Rol İsmi";
            this.RoleName.Name = "RoleName";
            // 
            // RolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1080, 814);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlKontrol);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.pnlTc);
            this.Controls.Add(this.txtRoleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RolForm";
            this.Text = "RolForm";
            this.Load += new System.EventHandler(this.RolForm_Load);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFormAdi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Panel pnlKontrol;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Panel pnlTc;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRoles;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeePayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorizedNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
    }
}