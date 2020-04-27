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
    public partial class YoklamaForm : Form
    {
        RollCallBusiness rcb = new RollCallBusiness();
        StudentBusiness sb = new StudentBusiness();

        public Student _student;
        public YoklamaForm(Student student)
        {
            _student = student;
            InitializeComponent();
        }
        public void List()
        {
           dgvInspections.DataSource = rcb.GetRollCallViewModels();
        }
        private void YoklamaForm_Load(object sender, EventArgs e)
        {
                List();
        }

        private void pnlKontrol_Paint(object sender, PaintEventArgs e)
        {

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

        private void dgvInspections_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvInspections.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                txtid.Text = selectedRow.Cells["RollCallId"].Value.ToString();
                txtNumberOfDays.Text = selectedRow.Cells["NumberOfDays"].Value.ToString();
                var studentid = selectedRow.Cells["StudentId"].Value.ToString();
                txtStudentNo.Text =sb.Get(Convert.ToInt32(studentid)).StudentNo.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            rcb.More(Convert.ToInt32(txtid.Text),Convert.ToInt32(txtNumberOfDays.Text));
            List();

        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            rcb.Less(Convert.ToInt32(txtid.Text), Convert.ToInt32(txtNumberOfDays.Text));
            List();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MExcel.Application ExcelApp = new MExcel.Application();
            MExcel.Workbook AlbumsBook = ExcelApp.Workbooks.Add(true);
            MExcel.Worksheet ExcelPage = (MExcel.Worksheet)ExcelApp.ActiveSheet;

            ExcelApp.Visible = true;
            int rowNumber = 1;
            ExcelPage.Cells[1, 1] = "Gün Sayısı";
            ExcelPage.Cells[1, 2] = "Öğrenci Adı";
            


            foreach (DataGridViewRow row in dgvInspections.Rows)
            {
                rowNumber++;
                ExcelPage.Cells[rowNumber, 1] = row.Cells["NumberOfDays"].Value;
                ExcelPage.Cells[rowNumber, 2] = row.Cells["Firstname"].Value;
            }
            ExcelApp.Quit();
        }
        PrivacyCourseDBEntities db = new PrivacyCourseDBEntities();
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvInspections.DataSource = db.RollCalls.Where(x => x.RollCallId.ToString().Contains(txtSearch.Text)).ToList();
        }
        
    }
}
