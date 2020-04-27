namespace _PresentationLayer.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.lblFormAdi = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlSifre = new System.Windows.Forms.Panel();
            this.pnlKullanici = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRptPassword = new System.Windows.Forms.TextBox();
            this.txtAuthorize = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.picBoxGeri = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBoxKullanici = new System.Windows.Forms.PictureBox();
            this.picBoxKilit = new System.Windows.Forms.PictureBox();
            this.cmbQuestion = new System.Windows.Forms.ComboBox();
            this.pnlKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKilit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(269, 9);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(27, 30);
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
            this.btnKucult.Location = new System.Drawing.Point(237, 6);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(27, 30);
            this.btnKucult.TabIndex = 0;
            this.btnKucult.Text = "_";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(66, 87);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 15);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Kullanıcı Adı";
            this.txtUserName.TextChanged += new System.EventHandler(this.txtBoxKullanici_TextChanged);
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
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
            this.pnlKontrol.Size = new System.Drawing.Size(303, 45);
            this.pnlKontrol.TabIndex = 23;
            this.pnlKontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlKontrol_MouseDown);
            // 
            // lblFormAdi
            // 
            this.lblFormAdi.AutoSize = true;
            this.lblFormAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormAdi.ForeColor = System.Drawing.Color.White;
            this.lblFormAdi.Location = new System.Drawing.Point(12, 15);
            this.lblFormAdi.Name = "lblFormAdi";
            this.lblFormAdi.Size = new System.Drawing.Size(84, 18);
            this.lblFormAdi.TabIndex = 2;
            this.lblFormAdi.Text = "Kayıt Paneli";
            this.lblFormAdi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFormAdi_MouseDown);
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(35, 482);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(231, 29);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnlSifre
            // 
            this.pnlSifre.BackColor = System.Drawing.Color.White;
            this.pnlSifre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSifre.ForeColor = System.Drawing.Color.White;
            this.pnlSifre.Location = new System.Drawing.Point(65, 168);
            this.pnlSifre.Name = "pnlSifre";
            this.pnlSifre.Size = new System.Drawing.Size(201, 2);
            this.pnlSifre.TabIndex = 30;
            this.pnlSifre.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSifre_Paint);
            // 
            // pnlKullanici
            // 
            this.pnlKullanici.BackColor = System.Drawing.Color.White;
            this.pnlKullanici.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlKullanici.ForeColor = System.Drawing.Color.White;
            this.pnlKullanici.Location = new System.Drawing.Point(65, 113);
            this.pnlKullanici.Name = "pnlKullanici";
            this.pnlKullanici.Size = new System.Drawing.Size(201, 2);
            this.pnlKullanici.TabIndex = 29;
            this.pnlKullanici.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKullanici_Paint);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(65, 142);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(201, 15);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Şifre";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtBoxSifre_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(65, 247);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 15);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "E-Mail";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(66, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 2);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(64, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 2);
            this.panel2.TabIndex = 36;
            // 
            // txtRptPassword
            // 
            this.txtRptPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtRptPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRptPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRptPassword.ForeColor = System.Drawing.Color.White;
            this.txtRptPassword.Location = new System.Drawing.Point(66, 196);
            this.txtRptPassword.Name = "txtRptPassword";
            this.txtRptPassword.Size = new System.Drawing.Size(201, 15);
            this.txtRptPassword.TabIndex = 2;
            this.txtRptPassword.Text = "Tekrar Şifre";
            this.txtRptPassword.TextChanged += new System.EventHandler(this.txtSifreTekrar_TextChanged);
            this.txtRptPassword.Enter += new System.EventHandler(this.txtRptPassword_Enter);
            // 
            // txtAuthorize
            // 
            this.txtAuthorize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtAuthorize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthorize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAuthorize.ForeColor = System.Drawing.Color.White;
            this.txtAuthorize.Location = new System.Drawing.Point(65, 299);
            this.txtAuthorize.Name = "txtAuthorize";
            this.txtAuthorize.Size = new System.Drawing.Size(201, 15);
            this.txtAuthorize.TabIndex = 4;
            this.txtAuthorize.Text = "Yetkili Numarası";
            this.txtAuthorize.TextChanged += new System.EventHandler(this.txtYetkiNo_TextChanged);
            this.txtAuthorize.Enter += new System.EventHandler(this.txtAuthorize_Enter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(64, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 2);
            this.panel3.TabIndex = 40;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(66, 422);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 2);
            this.panel5.TabIndex = 46;
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSecurityAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecurityAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecurityAnswer.ForeColor = System.Drawing.Color.White;
            this.txtSecurityAnswer.Location = new System.Drawing.Point(66, 396);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(201, 15);
            this.txtSecurityAnswer.TabIndex = 6;
            this.txtSecurityAnswer.Text = "Cevabı";
            this.txtSecurityAnswer.Enter += new System.EventHandler(this.txtSecurityAnswer_Enter);
            // 
            // picBoxGeri
            // 
            this.picBoxGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxGeri.Image = global::_PresentationLayer.Properties.Resources.geri;
            this.picBoxGeri.Location = new System.Drawing.Point(1, 51);
            this.picBoxGeri.Name = "picBoxGeri";
            this.picBoxGeri.Size = new System.Drawing.Size(26, 28);
            this.picBoxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxGeri.TabIndex = 47;
            this.picBoxGeri.TabStop = false;
            this.picBoxGeri.Click += new System.EventHandler(this.picBoxGeri_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::_PresentationLayer.Properties.Resources.sifre;
            this.pictureBox5.Location = new System.Drawing.Point(35, 396);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 44;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_PresentationLayer.Properties.Resources.question;
            this.pictureBox4.Location = new System.Drawing.Point(33, 349);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_PresentationLayer.Properties.Resources.YetkiliNo;
            this.pictureBox3.Location = new System.Drawing.Point(33, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_PresentationLayer.Properties.Resources.Mail1;
            this.pictureBox1.Location = new System.Drawing.Point(33, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_PresentationLayer.Properties.Resources.sifre;
            this.pictureBox2.Location = new System.Drawing.Point(35, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picBoxKullanici
            // 
            this.picBoxKullanici.Image = global::_PresentationLayer.Properties.Resources.kullanici;
            this.picBoxKullanici.Location = new System.Drawing.Point(34, 87);
            this.picBoxKullanici.Name = "picBoxKullanici";
            this.picBoxKullanici.Size = new System.Drawing.Size(26, 28);
            this.picBoxKullanici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxKullanici.TabIndex = 26;
            this.picBoxKullanici.TabStop = false;
            this.picBoxKullanici.Click += new System.EventHandler(this.picBoxKullanici_Click);
            // 
            // picBoxKilit
            // 
            this.picBoxKilit.Image = global::_PresentationLayer.Properties.Resources.sifre;
            this.picBoxKilit.Location = new System.Drawing.Point(34, 142);
            this.picBoxKilit.Name = "picBoxKilit";
            this.picBoxKilit.Size = new System.Drawing.Size(26, 28);
            this.picBoxKilit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxKilit.TabIndex = 25;
            this.picBoxKilit.TabStop = false;
            this.picBoxKilit.Click += new System.EventHandler(this.picBoxKilit_Click);
            // 
            // cmbQuestion
            // 
            this.cmbQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cmbQuestion.ForeColor = System.Drawing.Color.White;
            this.cmbQuestion.FormattingEnabled = true;
            this.cmbQuestion.Items.AddRange(new object[] {
            "Seçiniz"});
            this.cmbQuestion.Location = new System.Drawing.Point(64, 356);
            this.cmbQuestion.Name = "cmbQuestion";
            this.cmbQuestion.Size = new System.Drawing.Size(198, 21);
            this.cmbQuestion.TabIndex = 48;
            this.cmbQuestion.Text = "Güvenlik Sorusu";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(303, 571);
            this.Controls.Add(this.cmbQuestion);
            this.Controls.Add(this.picBoxGeri);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtSecurityAnswer);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtAuthorize);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtRptPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pnlKontrol);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pnlSifre);
            this.Controls.Add(this.pnlKullanici);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.picBoxKullanici);
            this.Controls.Add(this.picBoxKilit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKilit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel pnlKontrol;
        private System.Windows.Forms.Label lblFormAdi;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlSifre;
        private System.Windows.Forms.Panel pnlKullanici;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picBoxKullanici;
        private System.Windows.Forms.PictureBox picBoxKilit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRptPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtAuthorize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picBoxGeri;
        private System.Windows.Forms.ComboBox cmbQuestion;
    }
}