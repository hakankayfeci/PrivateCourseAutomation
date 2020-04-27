namespace _PresentationLayer.Forms
{
    partial class Ogrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.pnlMemleket = new System.Windows.Forms.Panel();
            this.pnlTc = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblFormAdi = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlSoyadi = new System.Windows.Forms.Panel();
            this.pnlAdi = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnTrial = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvStudents = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnPrint = new System.Windows.Forms.Button();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentityNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(177, 423);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(265, 22);
            this.dtpBirthday.TabIndex = 127;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirthday.ForeColor = System.Drawing.Color.White;
            this.lblBirthday.Location = new System.Drawing.Point(35, 426);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(139, 24);
            this.lblBirthday.TabIndex = 125;
            this.lblBirthday.Text = "Doğum Tarihi : ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(35, 305);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(89, 24);
            this.lblPhone.TabIndex = 124;
            this.lblPhone.Text = "Telefon : ";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.ForeColor = System.Drawing.Color.White;
            this.lblTc.Location = new System.Drawing.Point(35, 236);
            this.lblTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(134, 24);
            this.lblTc.TabIndex = 123;
            this.lblTc.Text = "TC Kimlik No : ";
            // 
            // pnlMemleket
            // 
            this.pnlMemleket.BackColor = System.Drawing.Color.White;
            this.pnlMemleket.ForeColor = System.Drawing.Color.White;
            this.pnlMemleket.Location = new System.Drawing.Point(177, 326);
            this.pnlMemleket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMemleket.Name = "pnlMemleket";
            this.pnlMemleket.Size = new System.Drawing.Size(269, 1);
            this.pnlMemleket.TabIndex = 122;
            // 
            // pnlTc
            // 
            this.pnlTc.BackColor = System.Drawing.Color.White;
            this.pnlTc.ForeColor = System.Drawing.Color.White;
            this.pnlTc.Location = new System.Drawing.Point(177, 257);
            this.pnlTc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTc.Name = "pnlTc";
            this.pnlTc.Size = new System.Drawing.Size(269, 1);
            this.pnlTc.TabIndex = 121;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(177, 300);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(269, 19);
            this.txtPhone.TabIndex = 120;
            // 
            // txtTc
            // 
            this.txtTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.ForeColor = System.Drawing.Color.White;
            this.txtTc.Location = new System.Drawing.Point(179, 231);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(269, 19);
            this.txtTc.TabIndex = 119;
            // 
            // lblFormAdi
            // 
            this.lblFormAdi.AutoSize = true;
            this.lblFormAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormAdi.ForeColor = System.Drawing.Color.White;
            this.lblFormAdi.Location = new System.Drawing.Point(16, 18);
            this.lblFormAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormAdi.Name = "lblFormAdi";
            this.lblFormAdi.Size = new System.Drawing.Size(152, 24);
            this.lblFormAdi.TabIndex = 2;
            this.lblFormAdi.Text = "Öğrenci İşlemleri";
            this.lblFormAdi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFormAdi_MouseDown);
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(949, 10);
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
            this.btnKucult.Location = new System.Drawing.Point(905, 4);
            this.btnKucult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(37, 37);
            this.btnKucult.TabIndex = 0;
            this.btnKucult.Text = "_";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastname.ForeColor = System.Drawing.Color.White;
            this.lblLastname.Location = new System.Drawing.Point(35, 165);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(78, 24);
            this.lblLastname.TabIndex = 118;
            this.lblLastname.Text = "Soyad : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(35, 92);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 24);
            this.lblName.TabIndex = 117;
            this.lblName.Text = "Ad : ";
            // 
            // pnlSoyadi
            // 
            this.pnlSoyadi.BackColor = System.Drawing.Color.White;
            this.pnlSoyadi.ForeColor = System.Drawing.Color.White;
            this.pnlSoyadi.Location = new System.Drawing.Point(177, 186);
            this.pnlSoyadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSoyadi.Name = "pnlSoyadi";
            this.pnlSoyadi.Size = new System.Drawing.Size(269, 1);
            this.pnlSoyadi.TabIndex = 114;
            // 
            // pnlAdi
            // 
            this.pnlAdi.BackColor = System.Drawing.Color.White;
            this.pnlAdi.ForeColor = System.Drawing.Color.White;
            this.pnlAdi.Location = new System.Drawing.Point(177, 113);
            this.pnlAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAdi.Name = "pnlAdi";
            this.pnlAdi.Size = new System.Drawing.Size(269, 1);
            this.pnlAdi.TabIndex = 113;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(177, 160);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(269, 19);
            this.txtLastName.TabIndex = 112;
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
            this.pnlKontrol.Size = new System.Drawing.Size(997, 55);
            this.pnlKontrol.TabIndex = 110;
            this.pnlKontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlKontrol_MouseDown);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(179, 87);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 19);
            this.txtName.TabIndex = 111;
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
            this.btSearch.Location = new System.Drawing.Point(24, 509);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(60, 46);
            this.btSearch.TabIndex = 288;
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(91, 527);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 24);
            this.lblSearch.TabIndex = 287;
            this.lblSearch.Text = "Ara:";
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.White;
            this.pnl5.ForeColor = System.Drawing.Color.White;
            this.pnl5.Location = new System.Drawing.Point(175, 553);
            this.pnl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(269, 1);
            this.pnl5.TabIndex = 286;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(175, 527);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(269, 19);
            this.txtSearch.TabIndex = 285;
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
            this.btnDelete.Location = new System.Drawing.Point(609, 222);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(333, 58);
            this.btnDelete.TabIndex = 290;
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
            this.btnAdd.Location = new System.Drawing.Point(609, 74);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(333, 58);
            this.btnAdd.TabIndex = 289;
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
            this.BtnUpdate.Location = new System.Drawing.Point(609, 146);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(333, 58);
            this.BtnUpdate.TabIndex = 291;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnExam
            // 
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExam.ForeColor = System.Drawing.Color.White;
            this.btnExam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExam.ImageKey = "add.png";
            this.btnExam.ImageList = this.ImageList1;
            this.btnExam.Location = new System.Drawing.Point(609, 388);
            this.btnExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(333, 58);
            this.btnExam.TabIndex = 292;
            this.btnExam.Text = "Sınav Notu Ekle";
            this.btnExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnTrial
            // 
            this.btnTrial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrial.ForeColor = System.Drawing.Color.White;
            this.btnTrial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrial.ImageKey = "add.png";
            this.btnTrial.ImageList = this.ImageList1;
            this.btnTrial.Location = new System.Drawing.Point(609, 311);
            this.btnTrial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrial.Name = "btnTrial";
            this.btnTrial.Size = new System.Drawing.Size(333, 58);
            this.btnTrial.TabIndex = 293;
            this.btnTrial.Text = "Deneme Notu Ekle";
            this.btnTrial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrial.UseVisualStyleBackColor = true;
            this.btnTrial.Click += new System.EventHandler(this.btnTrial_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(40, 475);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(269, 19);
            this.txtId.TabIndex = 294;
            this.txtId.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(36, 370);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 24);
            this.lblEmail.TabIndex = 297;
            this.lblEmail.Text = "E-Mail : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(179, 391);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 1);
            this.panel1.TabIndex = 296;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(179, 366);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 19);
            this.txtEmail.TabIndex = 295;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvStudents.ColumnHeadersHeight = 40;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentNo,
            this.Firstname,
            this.Lastname,
            this.Birthday,
            this.Phone,
            this.IdentityNo,
            this.Email,
            this.LowerEmail});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudents.DoubleBuffered = true;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dgvStudents.HeaderForeColor = System.Drawing.Color.White;
            this.dgvStudents.Location = new System.Drawing.Point(0, 646);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowTemplate.DividerHeight = 1;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(997, 319);
            this.dgvStudents.TabIndex = 298;
            this.dgvStudents.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_RowEnter);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.ImageKey = "print.png";
            this.btnPrint.ImageList = this.ImageList1;
            this.btnPrint.Location = new System.Drawing.Point(785, 497);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(157, 58);
            this.btnPrint.TabIndex = 322;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "Id";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // StudentNo
            // 
            this.StudentNo.DataPropertyName = "StudentNo";
            this.StudentNo.HeaderText = "Öğrenci No";
            this.StudentNo.Name = "StudentNo";
            this.StudentNo.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "İsim";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.DataPropertyName = "Lastname";
            this.Lastname.HeaderText = "Soyisim";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "Doğum Tarihi";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Tel";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // IdentityNo
            // 
            this.IdentityNo.DataPropertyName = "IdentityNo";
            this.IdentityNo.HeaderText = "TC";
            this.IdentityNo.Name = "IdentityNo";
            this.IdentityNo.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // LowerEmail
            // 
            this.LowerEmail.DataPropertyName = "LowerEmail";
            this.LowerEmail.HeaderText = "Küçük Harf Email";
            this.LowerEmail.Name = "LowerEmail";
            this.LowerEmail.ReadOnly = true;
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(997, 965);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnTrial);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.pnlMemleket);
            this.Controls.Add(this.pnlTc);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlSoyadi);
            this.Controls.Add(this.pnlAdi);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.pnlKontrol);
            this.Controls.Add(this.txtName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ogrenci";
            this.Text = "OgrenciForm";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Panel pnlMemleket;
        private System.Windows.Forms.Panel pnlTc;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label lblFormAdi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlSoyadi;
        private System.Windows.Forms.Panel pnlAdi;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Panel pnlKontrol;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnTrial;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvStudents;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowerEmail;
    }
}