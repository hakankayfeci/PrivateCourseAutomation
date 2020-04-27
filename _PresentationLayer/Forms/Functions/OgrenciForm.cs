using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using _BusinessLayer.Repository.Concrete;
using _DataLayer.Entities;
using _PresentationLayer.Forms.Functions;
using System.Linq;
using MExcel = Microsoft.Office.Interop.Excel;
using _PresentationLayer.Extensions;

namespace _PresentationLayer.Forms
{
    public partial class Ogrenci : Form
    {
        StudentBusiness sb = new StudentBusiness();
        public Ogrenci()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
           dgvStudents.DataSource =  sb.GetStudents();
        }

        private void pnlKontrol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            /*Formu alt kısma almak için kullanılan kod.*/
            this.WindowState = FormWindowState.Minimized;
        }
        /*Formu panel den veya herhangi biryerden tutup ekran üzerinde oynatabilmek için bu dll leri kullanıldı.*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void lblFormAdi_MouseDown(object sender, MouseEventArgs e)
        {
            /*Formu panel den tutup ekran üzerinde oynatabilmek için kullanılan kod.*/
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlKontrol_MouseDown(object sender, MouseEventArgs e)
        {
            /*Formu panel den tutup ekran üzerinde oynatabilmek için kullanılan kod.*/
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public Student GetOgrenci()
        {
            Random rnd = new Random();
            string numara = "";
            for (int i = 0; i < 3; i++)
            {
                var deger = rnd.Next(1, 10);
                numara += deger.ToString();
            }
            var student = new Student
            {
                StudentId = Convert.ToInt32(txtId.Text),
                StudentNo = Convert.ToInt32(numara),
                Birthday = dtpBirthday.Value,
                Firstname = txtName.Text,
                Lastname = txtLastName.Text,
                Phone = txtPhone.Text,
                IdentityNo = txtTc.Text,
                Email = txtEmail.Text,
                LowerEmail = txtEmail.Text.ToLower(),
            };
            return student;
        }
        public ExamResult _examResult { get; set; }
        private void dgvStudents_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvStudents.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                txtId.Text = selectedRow.Cells["StudentId"].Value.ToString();
                txtName.Text = selectedRow.Cells["Firstname"].Value.ToString();
                txtLastName.Text = selectedRow.Cells["Lastname"].Value.ToString();
                txtTc.Text = selectedRow.Cells["IdentityNo"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                dtpBirthday.Text = selectedRow.Cells["Birthday"].Value.ToString();
                //_examResult = selectedRow.Cells["ExamResults"].Value.ToString();
                //dtpBirthday.Text = selectedRow.Cells["IntegrationClasses"].Value.ToString();
                //dtpBirthday.Text = selectedRow.Cells["RollCalls"].Value.ToString();
                //dtpBirthday.Text = selectedRow.Cells["TrialExamResults"].Value.ToString();
                dgvStudents.HideColumns(9);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sb.Add(GetOgrenci());  
           dgvStudents.DataSource =  sb.GetStudents();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sb.Delete(GetOgrenci().StudentId);
            dgvStudents.DataSource = sb.GetStudents();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            sb.Edit(GetOgrenci());
            dgvStudents.DataSource = sb.GetStudents();

        }

        private void btnTrial_Click(object sender, EventArgs e)
        {
            DenemeNotForm ogrenci = new DenemeNotForm(GetOgrenci());
            ogrenci.Show();
            this.Close();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            NotForm notForm = new NotForm(GetOgrenci());
            notForm.Show();
            this.Hide();
        }

        private void btnRollCall_Click(object sender, EventArgs e)
        {
            YoklamaForm yoklamaForm = new YoklamaForm(GetOgrenci());
            yoklamaForm.Show();
            this.Hide();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MExcel.Application ExcelApp = new MExcel.Application();
            MExcel.Workbook AlbumsBook = ExcelApp.Workbooks.Add(true);
            MExcel.Worksheet ExcelPage = (MExcel.Worksheet)ExcelApp.ActiveSheet;

            ExcelApp.Visible = true;
            int rowNumber = 1;
            ExcelPage.Cells[1, 1] = "Öğrenci No";
            ExcelPage.Cells[1, 2] = "İsim";
            ExcelPage.Cells[1, 3] = "Soyisim";
            ExcelPage.Cells[1, 4] = "Doğum Tarihi";
            ExcelPage.Cells[1, 5] = "Tel";
            ExcelPage.Cells[1, 6] = "TC";
            ExcelPage.Cells[1, 7] = "Email";


            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                rowNumber++;
                ExcelPage.Cells[rowNumber, 1] = row.Cells["StudentNo"].Value;
                ExcelPage.Cells[rowNumber, 2] = row.Cells["Firstname"].Value;
                ExcelPage.Cells[rowNumber, 3] = row.Cells["Lastname"].Value;
                ExcelPage.Cells[rowNumber, 4] = row.Cells["Birthday"].Value;
                ExcelPage.Cells[rowNumber, 5] = row.Cells["Phone"].Value;
                ExcelPage.Cells[rowNumber, 6] = row.Cells["IdentityNo"].Value;
                ExcelPage.Cells[rowNumber, 7] = row.Cells["Email"].Value;


            }
            ExcelApp.Quit();
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStudents.DataSource = sb.GetStudents().Where(x => x.Firstname.Contains(txtSearch.Text)).ToList();
        }
    }
}
