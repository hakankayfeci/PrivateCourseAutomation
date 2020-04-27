namespace _PresentationLayer.Forms.Functions
{
    partial class DenemeSinavForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DenemeSinavForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFormAdi = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.dgvTrialExam = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TrialExamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrialExamDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrialExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlTc = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSections = new System.Windows.Forms.Label();
            this.lblTrialExamName = new System.Windows.Forms.Label();
            this.pnlSoyadi = new System.Windows.Forms.Panel();
            this.pnlAdi = new System.Windows.Forms.Panel();
            this.txtSections = new System.Windows.Forms.TextBox();
            this.txtTrialExamName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbLessonName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrialExam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormAdi
            // 
            this.lblFormAdi.AutoSize = true;
            this.lblFormAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormAdi.ForeColor = System.Drawing.Color.White;
            this.lblFormAdi.Location = new System.Drawing.Point(12, 15);
            this.lblFormAdi.Name = "lblFormAdi";
            this.lblFormAdi.Size = new System.Drawing.Size(165, 18);
            this.lblFormAdi.TabIndex = 2;
            this.lblFormAdi.Text = "Deneme Sınavı İşlemleri";
            this.lblFormAdi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFormAdi_MouseDown);
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(761, 6);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 30);
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
            this.btnKucult.Location = new System.Drawing.Point(728, 0);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(28, 30);
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
            this.pnlKontrol.Name = "pnlKontrol";
            this.pnlKontrol.Size = new System.Drawing.Size(799, 45);
            this.pnlKontrol.TabIndex = 224;
            this.pnlKontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlKontrol_MouseDown);
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
            this.btSearch.Location = new System.Drawing.Point(36, 394);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(45, 37);
            this.btSearch.TabIndex = 263;
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(86, 409);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(34, 18);
            this.lblSearch.TabIndex = 262;
            this.lblSearch.Text = "Ara:";
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.White;
            this.pnl5.ForeColor = System.Drawing.Color.White;
            this.pnl5.Location = new System.Drawing.Point(149, 430);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(202, 1);
            this.pnl5.TabIndex = 261;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(149, 409);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 15);
            this.txtSearch.TabIndex = 260;
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
            this.btnDelete.Location = new System.Drawing.Point(478, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(278, 47);
            this.btnDelete.TabIndex = 265;
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
            this.btnAdd.Location = new System.Drawing.Point(478, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(278, 47);
            this.btnAdd.TabIndex = 264;
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
            this.BtnUpdate.Location = new System.Drawing.Point(478, 181);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(278, 47);
            this.BtnUpdate.TabIndex = 266;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dgvTrialExam
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTrialExam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTrialExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrialExam.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrialExam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrialExam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTrialExam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrialExam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTrialExam.ColumnHeadersHeight = 40;
            this.dgvTrialExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrialExamId,
            this.Session,
            this.Time,
            this.TrialExamDescription,
            this.TrialExamName,
            this.LessonName,
            this.LessonId});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrialExam.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTrialExam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTrialExam.DoubleBuffered = true;
            this.dgvTrialExam.EnableHeadersVisualStyles = false;
            this.dgvTrialExam.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dgvTrialExam.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTrialExam.Location = new System.Drawing.Point(0, 448);
            this.dgvTrialExam.Name = "dgvTrialExam";
            this.dgvTrialExam.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTrialExam.RowHeadersVisible = false;
            this.dgvTrialExam.RowTemplate.DividerHeight = 1;
            this.dgvTrialExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrialExam.Size = new System.Drawing.Size(799, 289);
            this.dgvTrialExam.TabIndex = 286;
            this.dgvTrialExam.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrialExam_RowEnter);
            // 
            // TrialExamId
            // 
            this.TrialExamId.DataPropertyName = "TrialExamId";
            this.TrialExamId.HeaderText = "Id";
            this.TrialExamId.Name = "TrialExamId";
            // 
            // Session
            // 
            this.Session.DataPropertyName = "Session";
            this.Session.HeaderText = "Dönem";
            this.Session.Name = "Session";
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Zaman";
            this.Time.Name = "Time";
            // 
            // TrialExamDescription
            // 
            this.TrialExamDescription.DataPropertyName = "TrialExamDescription";
            this.TrialExamDescription.HeaderText = "Açıklama";
            this.TrialExamDescription.Name = "TrialExamDescription";
            // 
            // TrialExamName
            // 
            this.TrialExamName.DataPropertyName = "TrialExamName";
            this.TrialExamName.HeaderText = "Sınav Adı";
            this.TrialExamName.Name = "TrialExamName";
            // 
            // LessonName
            // 
            this.LessonName.DataPropertyName = "LessonName";
            this.LessonName.HeaderText = "Ders Adı";
            this.LessonName.Name = "LessonName";
            // 
            // LessonId
            // 
            this.LessonId.DataPropertyName = "LessonId";
            this.LessonId.HeaderText = "LessonId";
            this.LessonId.Name = "LessonId";
            this.LessonId.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(33, 246);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 18);
            this.lblTime.TabIndex = 309;
            this.lblTime.Text = "Zaman:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(33, 190);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 18);
            this.lblDescription.TabIndex = 308;
            this.lblDescription.Text = "Açıklama:";
            // 
            // pnlTc
            // 
            this.pnlTc.BackColor = System.Drawing.Color.White;
            this.pnlTc.ForeColor = System.Drawing.Color.White;
            this.pnlTc.Location = new System.Drawing.Point(140, 207);
            this.pnlTc.Name = "pnlTc";
            this.pnlTc.Size = new System.Drawing.Size(202, 1);
            this.pnlTc.TabIndex = 306;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(141, 186);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(202, 15);
            this.txtDescription.TabIndex = 304;
            // 
            // lblSections
            // 
            this.lblSections.AutoSize = true;
            this.lblSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSections.ForeColor = System.Drawing.Color.White;
            this.lblSections.Location = new System.Drawing.Point(33, 132);
            this.lblSections.Name = "lblSections";
            this.lblSections.Size = new System.Drawing.Size(61, 18);
            this.lblSections.TabIndex = 303;
            this.lblSections.Text = "Dönem:";
            // 
            // lblTrialExamName
            // 
            this.lblTrialExamName.AutoSize = true;
            this.lblTrialExamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrialExamName.ForeColor = System.Drawing.Color.White;
            this.lblTrialExamName.Location = new System.Drawing.Point(33, 73);
            this.lblTrialExamName.Name = "lblTrialExamName";
            this.lblTrialExamName.Size = new System.Drawing.Size(87, 18);
            this.lblTrialExamName.TabIndex = 302;
            this.lblTrialExamName.Text = "D.Sınav Adı:";
            // 
            // pnlSoyadi
            // 
            this.pnlSoyadi.BackColor = System.Drawing.Color.White;
            this.pnlSoyadi.ForeColor = System.Drawing.Color.White;
            this.pnlSoyadi.Location = new System.Drawing.Point(140, 149);
            this.pnlSoyadi.Name = "pnlSoyadi";
            this.pnlSoyadi.Size = new System.Drawing.Size(202, 1);
            this.pnlSoyadi.TabIndex = 301;
            // 
            // pnlAdi
            // 
            this.pnlAdi.BackColor = System.Drawing.Color.White;
            this.pnlAdi.ForeColor = System.Drawing.Color.White;
            this.pnlAdi.Location = new System.Drawing.Point(140, 90);
            this.pnlAdi.Name = "pnlAdi";
            this.pnlAdi.Size = new System.Drawing.Size(202, 1);
            this.pnlAdi.TabIndex = 300;
            // 
            // txtSections
            // 
            this.txtSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSections.ForeColor = System.Drawing.Color.White;
            this.txtSections.Location = new System.Drawing.Point(140, 128);
            this.txtSections.Name = "txtSections";
            this.txtSections.Size = new System.Drawing.Size(202, 15);
            this.txtSections.TabIndex = 299;
            // 
            // txtTrialExamName
            // 
            this.txtTrialExamName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtTrialExamName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrialExamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrialExamName.ForeColor = System.Drawing.Color.White;
            this.txtTrialExamName.Location = new System.Drawing.Point(141, 69);
            this.txtTrialExamName.Name = "txtTrialExamName";
            this.txtTrialExamName.Size = new System.Drawing.Size(202, 15);
            this.txtTrialExamName.TabIndex = 298;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(439, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 15);
            this.txtId.TabIndex = 313;
            this.txtId.Visible = false;
            // 
            // cmbLessonName
            // 
            this.cmbLessonName.FormattingEnabled = true;
            this.cmbLessonName.Location = new System.Drawing.Point(140, 294);
            this.cmbLessonName.Name = "cmbLessonName";
            this.cmbLessonName.Size = new System.Drawing.Size(200, 21);
            this.cmbLessonName.TabIndex = 315;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 314;
            this.label1.Text = "Ders Adı : ";
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(140, 244);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 20);
            this.dtpTime.TabIndex = 316;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.ImageKey = "print.png";
            this.btnPrint.ImageList = this.ImageList1;
            this.btnPrint.Location = new System.Drawing.Point(638, 389);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 47);
            this.btnPrint.TabIndex = 317;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // DenemeSinavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(799, 737);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.cmbLessonName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pnlTc);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblSections);
            this.Controls.Add(this.lblTrialExamName);
            this.Controls.Add(this.pnlSoyadi);
            this.Controls.Add(this.pnlAdi);
            this.Controls.Add(this.txtSections);
            this.Controls.Add(this.txtTrialExamName);
            this.Controls.Add(this.dgvTrialExam);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlKontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DenemeSinavForm";
            this.Text = "DenemeSınavForm";
            this.Load += new System.EventHandler(this.DenemeSinavForm_Load);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrialExam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormAdi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Panel pnlKontrol;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTrialExam;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlTc;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSections;
        private System.Windows.Forms.Label lblTrialExamName;
        private System.Windows.Forms.Panel pnlSoyadi;
        private System.Windows.Forms.Panel pnlAdi;
        private System.Windows.Forms.TextBox txtSections;
        private System.Windows.Forms.TextBox txtTrialExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrialExamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrialExamDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrialExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbLessonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnPrint;
    }
}