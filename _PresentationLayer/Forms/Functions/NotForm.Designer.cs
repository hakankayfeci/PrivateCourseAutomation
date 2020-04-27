namespace _PresentationLayer.Forms.Functions
{
    partial class NotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFormAdi = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.lblLesson = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.pnlTc = new System.Windows.Forms.Panel();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.pnlSoyadi = new System.Windows.Forms.Panel();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cmbLesson = new System.Windows.Forms.ComboBox();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.dgvNotes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ExamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterNoteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Character = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormAdi
            // 
            this.lblFormAdi.AutoSize = true;
            this.lblFormAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormAdi.ForeColor = System.Drawing.Color.White;
            this.lblFormAdi.Location = new System.Drawing.Point(12, 15);
            this.lblFormAdi.Name = "lblFormAdi";
            this.lblFormAdi.Size = new System.Drawing.Size(90, 18);
            this.lblFormAdi.TabIndex = 2;
            this.lblFormAdi.Text = "Not İşlemleri";
            this.lblFormAdi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFormAdi_MouseDown);
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(735, 9);
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
            this.btnKucult.Location = new System.Drawing.Point(702, 3);
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
            this.pnlKontrol.Size = new System.Drawing.Size(775, 45);
            this.pnlKontrol.TabIndex = 224;
            this.pnlKontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlKontrol_MouseDown);
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLesson.ForeColor = System.Drawing.Color.White;
            this.lblLesson.Location = new System.Drawing.Point(33, 253);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(44, 18);
            this.lblLesson.TabIndex = 241;
            this.lblLesson.Text = "Ders:";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNo.ForeColor = System.Drawing.Color.White;
            this.lblStudentNo.Location = new System.Drawing.Point(33, 197);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(88, 18);
            this.lblStudentNo.TabIndex = 240;
            this.lblStudentNo.Text = "Öğrenci No:";
            // 
            // pnlTc
            // 
            this.pnlTc.BackColor = System.Drawing.Color.White;
            this.pnlTc.ForeColor = System.Drawing.Color.White;
            this.pnlTc.Location = new System.Drawing.Point(140, 214);
            this.pnlTc.Name = "pnlTc";
            this.pnlTc.Size = new System.Drawing.Size(202, 1);
            this.pnlTc.TabIndex = 238;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtStudentNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentNo.ForeColor = System.Drawing.Color.White;
            this.txtStudentNo.Location = new System.Drawing.Point(141, 193);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(202, 15);
            this.txtStudentNo.TabIndex = 236;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(33, 141);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 18);
            this.lblNote.TabIndex = 235;
            this.lblNote.Text = "Not:";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSection.ForeColor = System.Drawing.Color.White;
            this.lblSection.Location = new System.Drawing.Point(33, 85);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(61, 18);
            this.lblSection.TabIndex = 234;
            this.lblSection.Text = "Donem:";
            // 
            // pnlSoyadi
            // 
            this.pnlSoyadi.BackColor = System.Drawing.Color.White;
            this.pnlSoyadi.ForeColor = System.Drawing.Color.White;
            this.pnlSoyadi.Location = new System.Drawing.Point(140, 158);
            this.pnlSoyadi.Name = "pnlSoyadi";
            this.pnlSoyadi.Size = new System.Drawing.Size(202, 1);
            this.pnlSoyadi.TabIndex = 233;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNote.ForeColor = System.Drawing.Color.White;
            this.txtNote.Location = new System.Drawing.Point(140, 137);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(202, 15);
            this.txtNote.TabIndex = 231;
            // 
            // cmbLesson
            // 
            this.cmbLesson.FormattingEnabled = true;
            this.cmbLesson.Location = new System.Drawing.Point(140, 254);
            this.cmbLesson.Name = "cmbLesson";
            this.cmbLesson.Size = new System.Drawing.Size(200, 21);
            this.cmbLesson.TabIndex = 245;
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
            this.btSearch.Location = new System.Drawing.Point(36, 354);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(45, 37);
            this.btSearch.TabIndex = 283;
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(86, 369);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(34, 18);
            this.lblSearch.TabIndex = 282;
            this.lblSearch.Text = "Ara:";
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.White;
            this.pnl5.ForeColor = System.Drawing.Color.White;
            this.pnl5.Location = new System.Drawing.Point(149, 390);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(202, 1);
            this.pnl5.TabIndex = 281;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(149, 369);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 15);
            this.txtSearch.TabIndex = 280;
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
            this.btnDelete.Location = new System.Drawing.Point(443, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(301, 47);
            this.btnDelete.TabIndex = 285;
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
            this.btnAdd.Location = new System.Drawing.Point(443, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(301, 47);
            this.btnAdd.TabIndex = 284;
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
            this.BtnUpdate.Location = new System.Drawing.Point(443, 183);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(301, 47);
            this.BtnUpdate.TabIndex = 286;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dgvNotes
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotes.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvNotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNotes.ColumnHeadersHeight = 40;
            this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExamId,
            this.Session,
            this.Notu,
            this.StudentId,
            this.LessonId,
            this.CharacterNoteId,
            this.Firstname,
            this.LessonName,
            this.Character});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNotes.DoubleBuffered = true;
            this.dgvNotes.EnableHeadersVisualStyles = false;
            this.dgvNotes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dgvNotes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNotes.Location = new System.Drawing.Point(0, 403);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNotes.RowHeadersVisible = false;
            this.dgvNotes.RowTemplate.DividerHeight = 1;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(775, 289);
            this.dgvNotes.TabIndex = 287;
            this.dgvNotes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_RowEnter);
            // 
            // ExamId
            // 
            this.ExamId.DataPropertyName = "ExamId";
            this.ExamId.HeaderText = "Sınav No";
            this.ExamId.Name = "ExamId";
            // 
            // Session
            // 
            this.Session.DataPropertyName = "Session";
            this.Session.HeaderText = "Dönem";
            this.Session.Name = "Session";
            // 
            // Notu
            // 
            this.Notu.DataPropertyName = "Notu";
            this.Notu.HeaderText = "Not";
            this.Notu.Name = "Notu";
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            this.StudentId.Visible = false;
            // 
            // LessonId
            // 
            this.LessonId.DataPropertyName = "LessonId";
            this.LessonId.HeaderText = "LessonId";
            this.LessonId.Name = "LessonId";
            this.LessonId.Visible = false;
            // 
            // CharacterNoteId
            // 
            this.CharacterNoteId.DataPropertyName = "CharacterNoteId";
            this.CharacterNoteId.HeaderText = "CharacterNoteId";
            this.CharacterNoteId.Name = "CharacterNoteId";
            this.CharacterNoteId.Visible = false;
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "Öğrenci Adı";
            this.Firstname.Name = "Firstname";
            // 
            // LessonName
            // 
            this.LessonName.DataPropertyName = "LessonName";
            this.LessonName.HeaderText = "Ders Adı";
            this.LessonName.Name = "LessonName";
            // 
            // Character
            // 
            this.Character.DataPropertyName = "Character";
            this.Character.HeaderText = "Karakter Notu";
            this.Character.Name = "Character";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(138, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 1);
            this.panel1.TabIndex = 289;
            // 
            // txtSession
            // 
            this.txtSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSession.ForeColor = System.Drawing.Color.White;
            this.txtSession.Location = new System.Drawing.Point(138, 88);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(202, 15);
            this.txtSession.TabIndex = 288;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(286, 339);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 15);
            this.txtId.TabIndex = 290;
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
            this.btnPrint.Location = new System.Drawing.Point(626, 349);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 47);
            this.btnPrint.TabIndex = 321;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // NotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(775, 692);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbLesson);
            this.Controls.Add(this.lblLesson);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.pnlTc);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.pnlSoyadi);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.pnlKontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotForm";
            this.Text = "NotForm";
            this.Load += new System.EventHandler(this.NotForm_Load);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormAdi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Panel pnlKontrol;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Panel pnlTc;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Panel pnlSoyadi;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cmbLesson;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notu;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacterNoteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Character;
        private System.Windows.Forms.Button btnPrint;
    }
}