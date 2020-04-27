using System;
using System.Linq;
using System.Windows.Forms;
using System.Web.Security;
using System.Runtime.InteropServices;
using _BusinessLayer.Business;
using System.Drawing;
using _BusinessLayer.Facade;
using _PresentationLayer.Forms.FormAction;

namespace _PresentationLayer.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void txtYetkiNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBoxKullanici_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxKullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlKullanici_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBoxKilit_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlSifre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Facade facade = new Facade();
            string message = facade.Register(txtUserName.Text,txtPassword.Text,txtEmail.Text,cmbQuestion.SelectedItem.ToString(),txtSecurityAnswer.Text,Convert.ToInt32(txtAuthorize.Text));
            if (message=="Başarılı")
            {
                RegisterSuccessfuly rs = new RegisterSuccessfuly();
                rs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlKontrol_MouseDown(object sender, MouseEventArgs e)
        {
            /*Formu panel den tutup ekran üzerinde oynatabilmek için kullanılan kod.*/
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*Formu panel den veya herhangi biryerden tutup ekran üzerinde oynatabilmek için bu dll leri kullanıldı.*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnKucult_Click(object sender, EventArgs e)
        {
            /*Formu alt kısma almak için kullanılan kod.*/
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblFormAdi_MouseDown(object sender, MouseEventArgs e)
        {
            /*Formu panel den tutup ekran üzerinde oynatabilmek için kullanılan kod.*/
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Kullanıcı Adı")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.White;

            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Şifre")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtRptPassword_Enter(object sender, EventArgs e)
        {
            if (txtRptPassword.Text == "Tekrar Şifre")
            {
                txtRptPassword.Text = "";
                txtRptPassword.ForeColor = Color.White;
                txtRptPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-Mail")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.White;

            }
        }

        private void txtAuthorize_Enter(object sender, EventArgs e)
        {
            if (txtAuthorize.Text == "Yetkili Numarası")
            {
                txtAuthorize.Text = "";
                txtAuthorize.ForeColor = Color.White;

            }
        }

        private void txtSecurityAnswer_Enter(object sender, EventArgs e)
        {
            if (txtSecurityAnswer.Text == "Cevabı")
            {
                txtSecurityAnswer.Text = "";
                txtSecurityAnswer.ForeColor = Color.White;

            }
        }

        private void picBoxGeri_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            cmbQuestion.Items.Add("Annenizin kızlık soyadı nedir ?");
            cmbQuestion.Items.Add("İlk evcil hayvanınızın adı nedir ?");
            cmbQuestion.Items.Add("İlk aracınızın modeli nedir ?");
            cmbQuestion.Items.Add("Çocukluk lakabınız nedir ?");
            cmbQuestion.Items.Add("Hangi şehirde doğdunuz ?");
        }
    }
}
