namespace _PresentationLayer.Forms.Functions
{
    partial class DenemeNotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DenemeNotForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFormAdi = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.cmbTrialExamName = new System.Windows.Forms.ComboBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.pnlTc = new System.Windows.Forms.Panel();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblTrialExamName = new System.Windows.Forms.Label();
            this.pnlSoyadi = new System.Windows.Forms.Panel();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.dgvTrialExamNotes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TrialExamResultId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrialExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Character = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrialExamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterNoteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrialExamNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormAdi
            // 
            this.lblFormAdi.AutoSize = true;
            this.lblFormAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormAdi.ForeColor = System.Drawing.Color.White;
            this.lblFormAdi.Location = new System.Drawing.Point(12, 15);
            this.lblFormAdi.Name = "lblFormAdi";
            this.lblFormAdi.Size = new System.Drawing.Size(158, 18);
            this.lblFormAdi.TabIndex = 2;
            this.lblFormAdi.Text = "Deneme Notu İşlemleri";
            this.lblFormAdi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFormAdi_MouseDown);
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(730, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 27);
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
            this.btnKucult.Location = new System.Drawing.Point(697, 6);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(28, 27);
            this.btnKucult.TabIndex = 0;
            this.btnKucult.Text = "_";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.ImageKey = "delete.png";
            this.btnDelete.ImageList = this.ImageList1;
            this.btnDelete.Location = new System.Drawing.Point(436, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(289, 47);
            this.btnDelete.TabIndex = 221;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.ImageKey = "add.png";
            this.btnAdd.ImageList = this.ImageList1;
            this.btnAdd.Location = new System.Drawing.Point(436, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(289, 47);
            this.btnAdd.TabIndex = 219;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.pnlKontrol.Size = new System.Drawing.Size(761, 45);
            this.pnlKontrol.TabIndex = 218;
            this.pnlKontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlKontrol_MouseDown);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.ImageKey = "update.png";
            this.BtnUpdate.ImageList = this.ImageList1;
            this.BtnUpdate.Location = new System.Drawing.Point(436, 174);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(289, 47);
            this.BtnUpdate.TabIndex = 222;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // cmbTrialExamName
            // 
            this.cmbTrialExamName.FormattingEnabled = true;
            this.cmbTrialExamName.Location = new System.Drawing.Point(150, 98);
            this.cmbTrialExamName.Name = "cmbTrialExamName";
            this.cmbTrialExamName.Size = new System.Drawing.Size(200, 21);
            this.cmbTrialExamName.TabIndex = 254;
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNo.ForeColor = System.Drawing.Color.White;
            this.lblStudentNo.Location = new System.Drawing.Point(43, 213);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(88, 18);
            this.lblStudentNo.TabIndex = 252;
            this.lblStudentNo.Text = "Öğrenci No:";
            // 
            // pnlTc
            // 
            this.pnlTc.BackColor = System.Drawing.Color.White;
            this.pnlTc.ForeColor = System.Drawing.Color.White;
            this.pnlTc.Location = new System.Drawing.Point(150, 230);
            this.pnlTc.Name = "pnlTc";
            this.pnlTc.Size = new System.Drawing.Size(202, 1);
            this.pnlTc.TabIndex = 251;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtStudentNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentNo.ForeColor = System.Drawing.Color.White;
            this.txtStudentNo.Location = new System.Drawing.Point(151, 209);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(202, 15);
            this.txtStudentNo.TabIndex = 250;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(43, 157);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 18);
            this.lblNote.TabIndex = 249;
            this.lblNote.Text = "Not:";
            // 
            // lblTrialExamName
            // 
            this.lblTrialExamName.AutoSize = true;
            this.lblTrialExamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrialExamName.ForeColor = System.Drawing.Color.White;
            this.lblTrialExamName.Location = new System.Drawing.Point(43, 101);
            this.lblTrialExamName.Name = "lblTrialExamName";
            this.lblTrialExamName.Size = new System.Drawing.Size(87, 18);
            this.lblTrialExamName.TabIndex = 248;
            this.lblTrialExamName.Text = "D.Sınav Adı:";
            // 
            // pnlSoyadi
            // 
            this.pnlSoyadi.BackColor = System.Drawing.Color.White;
            this.pnlSoyadi.ForeColor = System.Drawing.Color.White;
            this.pnlSoyadi.Location = new System.Drawing.Point(150, 174);
            this.pnlSoyadi.Name = "pnlSoyadi";
            this.pnlSoyadi.Size = new System.Drawing.Size(202, 1);
            this.pnlSoyadi.TabIndex = 247;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNote.ForeColor = System.Drawing.Color.White;
            this.txtNote.Location = new System.Drawing.Point(150, 153);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(202, 15);
            this.txtNote.TabIndex = 246;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(84, 330);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(105, 18);
            this.lblSearch.TabIndex = 257;
            this.lblSearch.Text = "Id\'ye Göre Ara:";
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.White;
            this.pnl5.ForeColor = System.Drawing.Color.White;
            this.pnl5.Location = new System.Drawing.Point(205, 347);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(202, 1);
            this.pnl5.TabIndex = 256;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(205, 326);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 15);
            this.txtSearch.TabIndex = 255;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged_1);
            // 
            // btSearch
            // 
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.ImageKey = "search.png";
            this.btSearch.ImageList = this.ImageList1;
            this.btSearch.Location = new System.Drawing.Point(34, 315);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(45, 37);
            this.btSearch.TabIndex = 258;
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // dgvTrialExamNotes
            // 
            this.dgvTrialExamNotes.AllowUserToAddRows = false;
            this.dgvTrialExamNotes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTrialExamNotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTrialExamNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrialExamNotes.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrialExamNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrialExamNotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTrialExamNotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrialExamNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTrialExamNotes.ColumnHeadersHeight = 40;
            this.dgvTrialExamNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrialExamResultId,
            this.Notu,
            this.TrialExamName,
            this.Firstname,
            this.Character,
            this.TrialExamId,
            this.CharacterNoteId,
            this.StudentId});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrialExamNotes.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTrialExamNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTrialExamNotes.DoubleBuffered = true;
            this.dgvTrialExamNotes.EnableHeadersVisualStyles = false;
            this.dgvTrialExamNotes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dgvTrialExamNotes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTrialExamNotes.Location = new System.Drawing.Point(0, 371);
            this.dgvTrialExamNotes.Name = "dgvTrialExamNotes";
            this.dgvTrialExamNotes.ReadOnly = true;
            this.dgvTrialExamNotes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTrialExamNotes.RowHeadersVisible = false;
            this.dgvTrialExamNotes.RowTemplate.DividerHeight = 1;
            this.dgvTrialExamNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrialExamNotes.Size = new System.Drawing.Size(761, 289);
            this.dgvTrialExamNotes.TabIndex = 284;
            this.dgvTrialExamNotes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrialExamNotes_RowEnter);
            // 
            // TrialExamResultId
            // 
            this.TrialExamResultId.DataPropertyName = "TrialExamResultId";
            this.TrialExamResultId.HeaderText = "Id";
            this.TrialExamResultId.Name = "TrialExamResultId";
            this.TrialExamResultId.ReadOnly = true;
            // 
            // Notu
            // 
            this.Notu.DataPropertyName = "Notu";
            this.Notu.HeaderText = "Not";
            this.Notu.Name = "Notu";
            this.Notu.ReadOnly = true;
            // 
            // TrialExamName
            // 
            this.TrialExamName.DataPropertyName = "TrialExamName";
            this.TrialExamName.HeaderText = "Sınav Adı";
            this.TrialExamName.Name = "TrialExamName";
            this.TrialExamName.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "Öğrenci Adı";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Character
            // 
            this.Character.DataPropertyName = "Character";
            this.Character.HeaderText = "Karakter Notu";
            this.Character.Name = "Character";
            this.Character.ReadOnly = true;
            // 
            // TrialExamId
            // 
            this.TrialExamId.DataPropertyName = "TrialExamId";
            this.TrialExamId.HeaderText = "TrialExamId";
            this.TrialExamId.Name = "TrialExamId";
            this.TrialExamId.ReadOnly = true;
            this.TrialExamId.Visible = false;
            // 
            // CharacterNoteId
            // 
            this.CharacterNoteId.DataPropertyName = "CharacterNoteId";
            this.CharacterNoteId.HeaderText = "CharacterNoteId";
            this.CharacterNoteId.Name = "CharacterNoteId";
            this.CharacterNoteId.ReadOnly = true;
            this.CharacterNoteId.Visible = false;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(151, 61);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 15);
            this.txtId.TabIndex = 285;
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
            this.btnPrint.Location = new System.Drawing.Point(607, 305);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 47);
            this.btnPrint.TabIndex = 286;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // DenemeNotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(761, 660);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvTrialExamNotes);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbTrialExamName);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.pnlTc);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblTrialExamName);
            this.Controls.Add(this.pnlSoyadi);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlKontrol);
            this.Controls.Add(this.BtnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DenemeNotForm";
            this.Text = "DenemeNotForm";
            this.Load += new System.EventHandler(this.DenemeNotForm_Load);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrialExamNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormAdi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlKontrol;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.ComboBox cmbTrialExamName;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Panel pnlTc;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblTrialExamName;
        private System.Windows.Forms.Panel pnlSoyadi;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Button btSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTrialExamNotes;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrialExamResultId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrialExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Character;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrialExamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacterNoteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.Button btnPrint;
    }
}