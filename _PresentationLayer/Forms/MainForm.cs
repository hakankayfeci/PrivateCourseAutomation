using _PresentationLayer.Forms.Functions;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Web.Security;
using _BusinessLayer.Business;

namespace _PresentationLayer.Forms
{
    public partial class MainForm : Form
    {
        UserAuthorizedBusiness rb = new UserAuthorizedBusiness();
        AuthorizedNumberBusiness anb = new AuthorizedNumberBusiness();
        public MembershipUser _yetkili;
        public MainForm(MembershipUser yetkili)
        {
            _yetkili = yetkili;
            InitializeComponent();
        }

        /*Formu panel den veya herhangi biryerden tutup ekran üzerinde oynatabilmek için bu dll leri kullanıldı.*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void MainForm_Load(object sender, EventArgs e)
        {
            var authorize = rb.GetByUserId(new Guid(_yetkili.ProviderUserKey.ToString()));
            var auth = anb.GetByAuthorizeNumber(Convert.ToInt32(authorize.AuthorizedNumber.AuthorizeNumber));
            tstbtnLeave.Text = _yetkili.UserName.ToString();

            if (auth.RoleId == 2)
            {
                DdbtnPayment.Visible = false;
                DdbtnEmployee.Visible = false;
                DdbtnRole.Visible = false;
            }
            else if (auth.RoleId == 3)
            {
                DdbtnPayment.Visible = false;
                DdbtnExtend.Visible = false;
                DdbtnEmployee.Visible = false;
                DdbtnClass.Visible = false;
                DdbtnRole.Visible = false;
                DdbtnTrialExam.Visible = false;
            }
        }


        private void pnlKontrol_MouseDown(object sender, MouseEventArgs e)
        {
            /*Formu panel den tutup ekran üzerinde oynatabilmek için kullanılan kod.*/
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            /*Formu form Menü den tutup ekran üzerinde oynatabilmek için kullanılan kod.*/
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlKontrol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            /*Formu alt kısma almak için kullanılan kod.*/
            this.WindowState = FormWindowState.Minimized;
        }

        private void SubitemStudent_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.MdiParent = this;
            ogrenci.Show();
        }

        private void SubitemExam_Click(object sender, EventArgs e)
        {
            NotForm not = new NotForm(new _DataLayer.Entities.Student());
            not.MdiParent = this;
            not.Show();
        }

        private void SubitemExtend_Click(object sender, EventArgs e)
        {
            GiderForm gider = new GiderForm();
            gider.MdiParent = this;
            gider.Show();
        }

        private void SubitemPayment_Click(object sender, EventArgs e)
        {
            MaasForm maas = new MaasForm();
            maas.MdiParent = this;
            maas.Show();
        }

        private void SubitemLesson_Click(object sender, EventArgs e)
        {
            DersForm ders = new DersForm();
            ders.MdiParent = this;
            ders.Show();
        }

        private void SubitemRole_Click(object sender, EventArgs e)
        {
            RolForm rol = new RolForm();
            rol.MdiParent = this;
            rol.Show();
        }

        private void SubitemClass_Click(object sender, EventArgs e)
        {
            SinifForm sinif = new SinifForm();
            sinif.MdiParent = this;
            sinif.Show();
        }

        private void SubitemEmployee_Click(object sender, EventArgs e)
        {
            PersonelForm personel = new PersonelForm();
            personel.MdiParent = this;
            personel.Show();
        }

        private void SubitemTrialExam_Click(object sender, EventArgs e)
        {
            DenemeSinavForm denemesinavform = new DenemeSinavForm();
            denemesinavform.MdiParent = this;
            denemesinavform.Show();
        }

        private void SubitemTrialExamNote_Click(object sender, EventArgs e)
        {
            DenemeNotForm denemenotform = new DenemeNotForm(new _DataLayer.Entities.Student());
            denemenotform.MdiParent = this;
            denemenotform.Show();
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            /*Formu panel den tutup ekran üzerinde oynatabilmek için kullanılan kod.*/
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Leavelblts_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            

        }
        private void MainForm_Resize(object sender, EventArgs e)
        {

        }
    }
}
