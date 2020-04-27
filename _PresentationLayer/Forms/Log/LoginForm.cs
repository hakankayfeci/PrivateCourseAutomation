using _BusinessLayer.Business;
using _BusinessLayer.Facade;
using _PresentationLayer.Forms.Functions;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Web.Security;
using System.Windows.Forms;

namespace _PresentationLayer.Forms
{
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Facade facade = new Facade();
                if (facade.Check(txtUserName.Text, txtPassword.Text))
                {

                    var user = Membership.GetUser(txtUserName.Text);
                    
                    SuccesfulyMessageForm smf = new SuccesfulyMessageForm(user);
                    smf.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamayı Kapatmak İstiyor Musunuz ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
            if (dialogResult==DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void lblFormAdi_MouseDown(object sender, MouseEventArgs e)
        {
            /*Formu panel den tutup ekran üzerinde oynatabilmek için kullanılan kod.*/
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
