using _BusinessLayer.Repository.Concrete;
using _DataLayer.Entities;
using _PresentationLayer.Extensions;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MExcel = Microsoft.Office.Interop.Excel;


namespace _PresentationLayer.Forms.Functions
{
    public partial class DenemeNotForm : Form
    {
        public Student _student;
        public DenemeNotForm(Student student)
        {
            _student = student;
            InitializeComponent();
        }
        TrialExamBusiness teb = new TrialExamBusiness();
        TrialExamResultBusiness terb = new TrialExamResultBusiness();
        StudentBusiness sb = new StudentBusiness();
        CharacterNoteBusiness cnb = new CharacterNoteBusiness();



        private void DenemeNotForm_Load(object sender, EventArgs e)
        {
            cmbTrialExamName.BindCombobox<TrialExam>("TrialExamName", "TrialExamId", teb.GetTrialExams());
            dgvTrialExamNotes.DataSource = terb.GetViewTrialExamResult();
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

        private void btnKucult_Click(object sender, EventArgs e)
        {
            /*Formu alt kısma almak için kullanılan kod.*/
            this.WindowState = FormWindowState.Minimized;
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
        public TrialExamResult GetTrialExamNote()
        {
            var Id = teb.Get(Convert.ToInt32(cmbTrialExamName.SelectedValue));
           var student = sb.GetByStudentNo(Convert.ToInt32(txtStudentNo.Text));
            var result = new TrialExamResult
            {
                TrialExamResultId = Convert.ToInt32(txtId.Text),
                Notu = Convert.ToInt32(txtNote.Text),
                StudentId = student.StudentId,
                TrialExamId = Id.TrialExamId,
                CharacterNoteId = cnb.GetCharacter(Convert.ToInt32(txtNote.Text)),
            };
            return result;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            terb.Delete(GetTrialExamNote().TrialExamResultId);
            dgvTrialExamNotes.DataSource = terb.GetViewTrialExamResult();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            terb.Add(GetTrialExamNote());
            dgvTrialExamNotes.DataSource = terb.GetViewTrialExamResult();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            terb.Edit(GetTrialExamNote());
            dgvTrialExamNotes.DataSource = terb.GetViewTrialExamResult();
        }

        private void dgvTrialExamNotes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvTrialExamNotes.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                txtId.Text = selectedRow.Cells["TrialExamResultId"].Value.ToString();
                txtNote.Text = selectedRow.Cells["Notu"].Value.ToString();
                var ogrenciId = selectedRow.Cells["StudentId"].Value.ToString();

                var ogrenci = sb.Get(Convert.ToInt32(ogrenciId));
                txtStudentNo.Text = ogrenci.StudentNo.ToString();
                
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //using (var db = new PrivacyCourseDBEntities())
            //{
            //    var result = from ter in db.TrialExamResults
            //                 where ter.StudentId as
            //                 select new
            //                 {
            //                     c.ClassId,
            //                     c.ClassName,
            //                     c.LessonId,
            //                     l.LessonName
            //                 };
            //    /* where FirstName like '"+txt_SearchName.Text+"%;*/

            //}
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MExcel.Application ExcelApp = new MExcel.Application();
            MExcel.Workbook AlbumsBook = ExcelApp.Workbooks.Add(true);
            MExcel.Worksheet ExcelPage = (MExcel.Worksheet)ExcelApp.ActiveSheet;

            ExcelApp.Visible = true;
            int rowNumber = 1;
            ExcelPage.Cells[1, 1] = "Not";
            ExcelPage.Cells[1, 2] = "Sınav Adı";
            ExcelPage.Cells[1, 3] = "Öğrenci Adı";
            ExcelPage.Cells[1, 4] = "Karakter Notu";
            
            
            foreach (DataGridViewRow row in dgvTrialExamNotes.Rows)
            {
                rowNumber++;
                ExcelPage.Cells[rowNumber, 1] = row.Cells["Notu"].Value;
                ExcelPage.Cells[rowNumber, 2] = row.Cells["TrialExamName"].Value;
                ExcelPage.Cells[rowNumber, 3] = row.Cells["Firstname"].Value;
                ExcelPage.Cells[rowNumber, 4] = row.Cells["Character"].Value;
               
                
            }
            ExcelApp.Quit();
        }
        private void TxtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dgvTrialExamNotes.DataSource = terb.GetViewTrialExamResult().Where(x => x.TrialExamResultId.ToString().Contains(txtSearch.Text)).ToList();
        }
    }
}
