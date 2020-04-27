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
    public partial class DenemeSinavForm : Form
    {
        TrialExamBusiness teb = new TrialExamBusiness();
        LessonBusiness lb = new LessonBusiness();

        public DenemeSinavForm()
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
        public TrialExam GetExam()
        {
            var Id = teb.Get(txtId.Text);
            var result = new TrialExam
            {
                TrialExamId=Convert.ToInt32(txtId.Text),
                Session=Convert.ToInt16(txtSections.Text),
                Time=dtpTime.Value,
                TrialExamName=txtTrialExamName.Text,
                TrialExamDescription=txtDescription.Text,
                LessonId=Convert.ToInt32(cmbLessonName.SelectedValue)
            };
            return result;
        }
        private void DenemeSinavForm_Load(object sender, EventArgs e)
        {
            cmbLessonName.BindCombobox<Lesson>("LessonName", "LessonId", lb.GetLessons());
            dgvTrialExam.DataSource = teb.GetViewTrialExam();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            teb.Add(GetExam());
            dgvTrialExam.DataSource = teb.GetViewTrialExam();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            teb.Delete(GetExam().TrialExamId);
            dgvTrialExam.DataSource = teb.GetViewTrialExam();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            teb.Edit(GetExam());
            dgvTrialExam.DataSource = teb.GetViewTrialExam();
        }

        private void dgvTrialExam_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvTrialExam.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                txtId.Text = selectedRow.Cells["TrialExamId"].Value.ToString();
                txtTrialExamName.Text = selectedRow.Cells["TrialExamName"].Value.ToString();
                txtSections.Text = selectedRow.Cells["Session"].Value.ToString();
                dtpTime.Text = selectedRow.Cells["Time"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["TrialExamDescription"].Value.ToString();
                cmbLessonName.Text = selectedRow.Cells["LessonName"].Value.ToString();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MExcel.Application ExcelApp = new MExcel.Application();
            MExcel.Workbook AlbumsBook = ExcelApp.Workbooks.Add(true);
            MExcel.Worksheet ExcelPage = (MExcel.Worksheet)ExcelApp.ActiveSheet;

            ExcelApp.Visible = true;
            int rowNumber = 1;
            ExcelPage.Cells[1, 1] = "Dönem";
            ExcelPage.Cells[1, 2] = "Zaman";
            ExcelPage.Cells[1, 3] = "Açıklama";
            ExcelPage.Cells[1, 4] = "Sınav Adı";
            ExcelPage.Cells[1, 5] = "Ders Adı";


            foreach (DataGridViewRow row in dgvTrialExam.Rows)
            {
                rowNumber++;
                ExcelPage.Cells[rowNumber, 1] = row.Cells["Session"].Value;
                ExcelPage.Cells[rowNumber, 2] = row.Cells["Time"].Value;
                ExcelPage.Cells[rowNumber, 3] = row.Cells["TrialExamDescription"].Value;
                ExcelPage.Cells[rowNumber, 4] = row.Cells["TrialExamName"].Value;
                ExcelPage.Cells[rowNumber, 5] = row.Cells["LessonName"].Value;


            }
            ExcelApp.Quit();
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvTrialExam.DataSource = teb.GetViewTrialExam().Where(x => x.TrialExamName.ToString().Contains(txtSearch.Text)).ToList();
        }
    }
}
