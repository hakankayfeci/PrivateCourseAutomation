namespace _PresentationLayer.Forms.Functions
{
    partial class YoklamaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoklamaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFormAdi = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.pnlTc = new System.Windows.Forms.Panel();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumberOfDays = new System.Windows.Forms.TextBox();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvInspections = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.RoleCallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnLess = new System.Windows.Forms.Button();
            this.pnlKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspections)).BeginInit();
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
            this.lblFormAdi.Size = new System.Drawing.Size(156, 24);
            this.lblFormAdi.TabIndex = 2;
            this.lblFormAdi.Text = "Yoklama İşlemleri";
            this.lblFormAdi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFormAdi_MouseDown);
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(892, 11);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnKucult.Location = new System.Drawing.Point(848, 4);
            this.btnKucult.Margin = new System.Windows.Forms.Padding(4);
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
            this.pnlKontrol.Margin = new System.Windows.Forms.Padding(4);
            this.pnlKontrol.Name = "pnlKontrol";
            this.pnlKontrol.Size = new System.Drawing.Size(933, 55);
            this.pnlKontrol.TabIndex = 209;
            this.pnlKontrol.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKontrol_Paint);
            this.pnlKontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlKontrol_MouseDown);
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNo.ForeColor = System.Drawing.Color.White;
            this.lblStudentNo.Location = new System.Drawing.Point(43, 101);
            this.lblStudentNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(108, 24);
            this.lblStudentNo.TabIndex = 223;
            this.lblStudentNo.Text = "OgrenciNo:";
            // 
            // pnlTc
            // 
            this.pnlTc.BackColor = System.Drawing.Color.White;
            this.pnlTc.ForeColor = System.Drawing.Color.White;
            this.pnlTc.Location = new System.Drawing.Point(196, 122);
            this.pnlTc.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTc.Name = "pnlTc";
            this.pnlTc.Size = new System.Drawing.Size(269, 1);
            this.pnlTc.TabIndex = 222;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtStudentNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentNo.ForeColor = System.Drawing.Color.White;
            this.txtStudentNo.Location = new System.Drawing.Point(197, 96);
            this.txtStudentNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(269, 19);
            this.txtStudentNo.TabIndex = 221;
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumberOfDays.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfDays.Location = new System.Drawing.Point(43, 154);
            this.lblNumberOfDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(104, 24);
            this.lblNumberOfDays.TabIndex = 226;
            this.lblNumberOfDays.Text = "Gün Sayısı:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(196, 175);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 1);
            this.panel1.TabIndex = 225;
            // 
            // txtNumberOfDays
            // 
            this.txtNumberOfDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtNumberOfDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumberOfDays.ForeColor = System.Drawing.Color.White;
            this.txtNumberOfDays.Location = new System.Drawing.Point(197, 149);
            this.txtNumberOfDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberOfDays.Name = "txtNumberOfDays";
            this.txtNumberOfDays.Size = new System.Drawing.Size(269, 19);
            this.txtNumberOfDays.TabIndex = 224;
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
            this.btSearch.Location = new System.Drawing.Point(47, 295);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(60, 46);
            this.btSearch.TabIndex = 303;
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(113, 314);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 24);
            this.lblSearch.TabIndex = 302;
            this.lblSearch.Text = "Ara:";
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.White;
            this.pnl5.ForeColor = System.Drawing.Color.White;
            this.pnl5.Location = new System.Drawing.Point(197, 340);
            this.pnl5.Margin = new System.Windows.Forms.Padding(4);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(269, 1);
            this.pnl5.TabIndex = 301;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(197, 314);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(269, 19);
            this.txtSearch.TabIndex = 300;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.ImageKey = "add.png";
            this.btnAdd.ImageList = this.ImageList1;
            this.btnAdd.Location = new System.Drawing.Point(579, 129);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(307, 58);
            this.btnAdd.TabIndex = 304;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvInspections
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInspections.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInspections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInspections.BackgroundColor = System.Drawing.Color.White;
            this.dgvInspections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInspections.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInspections.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInspections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInspections.ColumnHeadersHeight = 40;
            this.dgvInspections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleCallId,
            this.NumberOfDays,
            this.Firstname,
            this.StudentId});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInspections.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInspections.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInspections.DoubleBuffered = true;
            this.dgvInspections.EnableHeadersVisualStyles = false;
            this.dgvInspections.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dgvInspections.HeaderForeColor = System.Drawing.Color.White;
            this.dgvInspections.Location = new System.Drawing.Point(0, 355);
            this.dgvInspections.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInspections.Name = "dgvInspections";
            this.dgvInspections.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInspections.RowHeadersVisible = false;
            this.dgvInspections.RowTemplate.DividerHeight = 1;
            this.dgvInspections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInspections.Size = new System.Drawing.Size(933, 356);
            this.dgvInspections.TabIndex = 305;
            // 
            // RoleCallId
            // 
            this.RoleCallId.DataPropertyName = "RoleCallId";
            this.RoleCallId.HeaderText = "Id";
            this.RoleCallId.Name = "RoleCallId";
            // 
            // NumberOfDays
            // 
            this.NumberOfDays.DataPropertyName = "NumberOfDays";
            this.NumberOfDays.HeaderText = "Gün Sayısı";
            this.NumberOfDays.Name = "NumberOfDays";
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "Öğrenci Id";
            this.StudentId.Name = "StudentId";
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.ImageKey = "print.png";
            this.btnPrint.ImageList = this.ImageList1;
            this.btnPrint.Location = new System.Drawing.Point(728, 283);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(157, 58);
            this.btnPrint.TabIndex = 326;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.ForeColor = System.Drawing.Color.White;
            this.txtid.Location = new System.Drawing.Point(509, 74);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(269, 19);
            this.txtid.TabIndex = 327;
            // 
            // btnLess
            // 
            this.btnLess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLess.ForeColor = System.Drawing.Color.White;
            this.btnLess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLess.ImageKey = "delete.png";
            this.btnLess.ImageList = this.ImageList1;
            this.btnLess.Location = new System.Drawing.Point(578, 195);
            this.btnLess.Margin = new System.Windows.Forms.Padding(4);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(307, 58);
            this.btnLess.TabIndex = 328;
            this.btnLess.Text = "Çıkar";
            this.btnLess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLess.UseVisualStyleBackColor = true;
            this.btnLess.Click += new System.EventHandler(this.btnLess_Click);
            // 
            // YoklamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(933, 711);
            this.Controls.Add(this.btnLess);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvInspections);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblNumberOfDays);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNumberOfDays);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.pnlTc);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.pnlKontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YoklamaForm";
            this.Text = "YoklamaForm";
            this.Load += new System.EventHandler(this.YoklamaForm_Load);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormAdi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Panel pnlKontrol;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Panel pnlTc;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumberOfDays;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvInspections;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnLess;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleCallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
    }
}