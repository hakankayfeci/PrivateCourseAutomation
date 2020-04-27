using _BusinessLayer.Repository.Concrete;
using _DataLayer.Entities;
using _PresentationLayer.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MExcel = Microsoft.Office.Interop.Excel;

namespace _PresentationLayer.Forms.Functions
{
    public partial class NotForm : Form
    {
        ExamResultBusiness esb = new ExamResultBusiness();
        LessonBusiness lb = new LessonBusiness();
        StudentBusiness sb = new StudentBusiness();
        CharacterNoteBusiness cnb = new CharacterNoteBusiness();



        public Student _student { get; set; }
        public NotForm(Student student)
        {
            _student = student;

            InitializeComponent();
        }

        private void NotForm_Load(object sender, EventArgs e)
        {
            cmbLesson.BindCombobox<Lesson>("LessonName", "LessonId", lb.GetLessons());
            txtStudentNo.Text = _student.StudentNo.ToString();
            dgvNotes.DataSource = esb.GetExamResultView();
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
        public ExamResult GetNote()
        {
            var student = sb.GetByStudentNo(Convert.ToInt32(txtStudentNo.Text));
            var result = new ExamResult
            {
                ExamId = Convert.ToInt32(txtId.Text),
                Session = Convert.ToInt16(txtSession.Text),
                Notu = Convert.ToInt32(txtNote.Text),
                CharacterNoteId = cnb.GetCharacter(Convert.ToInt32(txtNote.Text)),
                LessonId= Convert.ToInt32(cmbLesson.SelectedValue),
                StudentId= student.StudentId

            };
            return result;
        }
        private void dgvNotes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvNotes.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                txtId.Text = selectedRow.Cells["ExamId"].Value.ToString();
                txtNote.Text = selectedRow.Cells["Notu"].Value.ToString();
                txtSession.Text = selectedRow.Cells["Session"].Value.ToString();
                cmbLesson.Text = selectedRow.Cells["LessonName"].Value.ToString();
                var deger = selectedRow.Cells["StudentId"].Value.ToString();
                
                txtStudentNo.Text = sb.Get(Convert.ToInt32(deger)).StudentNo.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            esb.Delete(GetNote().ExamId);
            dgvNotes.DataSource = esb.GetExamResultView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            esb.Add(GetNote());
            dgvNotes.DataSource = esb.GetExamResultView();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            esb.Edit(GetNote());
            dgvNotes.DataSource = esb.GetExamResultView();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MExcel.Application ExcelApp = new MExcel.Application();
            MExcel.Workbook AlbumsBook = ExcelApp.Workbooks.Add(true);
            MExcel.Worksheet ExcelPage = (MExcel.Worksheet)ExcelApp.ActiveSheet;

            ExcelApp.Visible = true;
            int rowNumber = 1;
            ExcelPage.Cells[1, 1] = "Dönem";
            ExcelPage.Cells[1, 2] = "Not";
            ExcelPage.Cells[1, 3] = "Öğrenci Adı";
            ExcelPage.Cells[1, 4] = "Ders Adı";
            ExcelPage.Cells[1, 5] = "Karakter Notu";


            foreach (DataGridViewRow row in dgvNotes.Rows)
            {
                rowNumber++;
                ExcelPage.Cells[rowNumber, 1] = row.Cells["Session"].Value;
                ExcelPage.Cells[rowNumber, 2] = row.Cells["Notu"].Value;
                ExcelPage.Cells[rowNumber, 3] = row.Cells["Firstname"].Value;
                ExcelPage.Cells[rowNumber, 4] = row.Cells["LessonName"].Value;
                ExcelPage.Cells[rowNumber, 5] = row.Cells["Character"].Value;


            }
            ExcelApp.Quit();
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvNotes.DataSource = esb.GetExamResultView().Where(x => x.Firstname.Contains(txtSearch.Text)).ToList();
        }
    }
}
