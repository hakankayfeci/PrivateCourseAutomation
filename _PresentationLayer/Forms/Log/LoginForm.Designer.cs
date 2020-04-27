namespace _PresentationLayer.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.lblFormAdi = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlSifre = new System.Windows.Forms.Panel();
            this.pnlKullanici = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxKullanici = new System.Windows.Forms.PictureBox();
            this.picBoxKilit = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
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
            this.txtUserName.Location = new System.Drawing.Point(63, 236);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 15);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "Kullanıcı Adı";
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
            this.pnlKontrol.Size = new System.Drawing.Size(309, 45);
            this.pnlKontrol.TabIndex = 14;
            this.pnlKontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlKontrol_MouseDown);
            // 
            // lblFormAdi
            // 
            this.lblFormAdi.AutoSize = true;
            this.lblFormAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormAdi.ForeColor = System.Drawing.Color.White;
            this.lblFormAdi.Location = new System.Drawing.Point(12, 15);
            this.lblFormAdi.Name = "lblFormAdi";
            this.lblFormAdi.Size = new System.Drawing.Size(83, 18);
            this.lblFormAdi.TabIndex = 2;
            this.lblFormAdi.Text = "Giriş Paneli";
            this.lblFormAdi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFormAdi_MouseDown);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.ImageKey = "login.png";
            this.btnLogin.ImageList = this.ImageList1;
            this.btnLogin.Location = new System.Drawing.Point(31, 376);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(231, 50);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "add.png");
            this.ImageList1.Images.SetKeyName(1, "delete.png");
            this.ImageList1.Images.SetKeyName(2, "update.png");
            this.ImageList1.Images.SetKeyName(3, "search.png");
            this.ImageList1.Images.SetKeyName(4, "login.png");
            // 
            // pnlSifre
            // 
            this.pnlSifre.BackColor = System.Drawing.Color.White;
            this.pnlSifre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSifre.ForeColor = System.Drawing.Color.White;
            this.pnlSifre.Location = new System.Drawing.Point(62, 317);
            this.pnlSifre.Name = "pnlSifre";
            this.pnlSifre.Size = new System.Drawing.Size(201, 2);
            this.pnlSifre.TabIndex = 21;
            // 
            // pnlKullanici
            // 
            this.pnlKullanici.BackColor = System.Drawing.Color.White;
            this.pnlKullanici.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlKullanici.ForeColor = System.Drawing.Color.White;
            this.pnlKullanici.Location = new System.Drawing.Point(62, 262);
            this.pnlKullanici.Name = "pnlKullanici";
            this.pnlKullanici.Size = new System.Drawing.Size(201, 2);
            this.pnlKullanici.TabIndex = 20;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(62, 291);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(201, 15);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Şifre";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::_PresentationLayer.Properties.Resources.Security;
            this.picBoxLogo.Location = new System.Drawing.Point(111, 89);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(75, 75);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 15;
            this.picBoxLogo.TabStop = false;
            // 
            // picBoxKullanici
            // 
            this.picBoxKullanici.Image = global::_PresentationLayer.Properties.Resources.kullanici;
            this.picBoxKullanici.Location = new System.Drawing.Point(31, 236);
            this.picBoxKullanici.Name = "picBoxKullanici";
            this.picBoxKullanici.Size = new System.Drawing.Size(26, 28);
            this.picBoxKullanici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxKullanici.TabIndex = 17;
            this.picBoxKullanici.TabStop = false;
            // 
            // picBoxKilit
            // 
            this.picBoxKilit.Image = global::_PresentationLayer.Properties.Resources.sifre;
            this.picBoxKilit.Location = new System.Drawing.Point(31, 291);
            this.picBoxKilit.Name = "picBoxKilit";
            this.picBoxKilit.Size = new System.Drawing.Size(26, 28);
            this.picBoxKilit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxKilit.TabIndex = 16;
            this.picBoxKilit.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(99, 429);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(163, 19);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hiç Kayıt Olmadıysanız...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(309, 493);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pnlKontrol);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlSifre);
            this.Controls.Add(this.pnlKullanici);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.picBoxKullanici);
            this.Controls.Add(this.picBoxKilit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlSifre;
        private System.Windows.Forms.Panel pnlKullanici;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picBoxKullanici;
        private System.Windows.Forms.PictureBox picBoxKilit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ImageList ImageList1;
    }
}