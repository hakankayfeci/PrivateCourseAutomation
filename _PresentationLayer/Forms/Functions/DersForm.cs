using _BusinessLayer.Business;
using _BusinessLayer.Repository.Concrete;
using _DataLayer.Entities;
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
    public partial class DersForm : Form
    {
        LessonBusiness lb = new LessonBusiness();
        TrialExamBusiness teb = new TrialExamBusiness();
        ExamResultBusiness erb = new ExamResultBusiness();
        ClassBusiness cb = new ClassBusiness();

        public DersForm()
        {
            InitializeComponent();
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
        public Lesson GetClass()
        {
            var result = new Lesson
            {
                LessonId=Convert.ToInt32(txtId.Text),
                LessonName=txtLessonName.Text,
                //Classes=cb.GetClasss(),
                //ExamResults=erb.GetExamResults(),
                //TrialExams=teb.GetTrialExams()
            };
            return result;
        }
        private void dgvLessons_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvLessons.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                txtId.Text = selectedRow.Cells["LessonId"].Value.ToString();
                txtLessonName.Text = selectedRow.Cells["LessonName"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lb.Add(GetClass());
            dgvLessons.DataSource = lb.GetLessons();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lb.Delete(GetClass().LessonId);
            dgvLessons.DataSource = lb.GetLessons();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            lb.Edit(GetClass());
            dgvLessons.DataSource = lb.GetLessons();

        }

        private void DersForm_Load(object sender, EventArgs e)
        {
           dgvLessons.DataSource = lb.GetLessons();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MExcel.Application ExcelApp = new MExcel.Application();
            MExcel.Workbook AlbumsBook = ExcelApp.Workbooks.Add(true);
            MExcel.Worksheet ExcelPage = (MExcel.Worksheet)ExcelApp.ActiveSheet;

            ExcelApp.Visible = true;
            int rowNumber = 1;
            ExcelPage.Cells[1, 1] = "Ders Adı";
            
            


            foreach (DataGridViewRow row in dgvLessons.Rows)
            {
                rowNumber++;
                ExcelPage.Cells[rowNumber, 1] = row.Cells["LessonName"].Value;
                
                


            }
            ExcelApp.Quit();
        }
        PrivacyCourseDBEntities db = new PrivacyCourseDBEntities();
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvLessons.DataSource = db.Lessons.Where(x => x.LessonName.Contains(txtSearch.Text)).ToList();
        }
    }
}
