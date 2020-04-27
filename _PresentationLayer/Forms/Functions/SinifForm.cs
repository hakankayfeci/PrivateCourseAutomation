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
    public partial class SinifForm : Form
    {
        ClassBusiness cb = new ClassBusiness();
        LessonBusiness lb = new LessonBusiness();

        public SinifForm()
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
        public Class GetClass()
        {
            var result = new Class
            {
                ClassId= Convert.ToInt32(txtId.Text),
                ClassName=txtClassName.Text,
                LessonId=Convert.ToInt32(cmbLesson.SelectedValue)
            };
            return result;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cb.Add(GetClass());
            dgvClasses.DataSource = cb.GetClassViewModel();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cb.Delete(GetClass().ClassId);
            dgvClasses.DataSource = cb.GetClassViewModel();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            cb.Edit(GetClass());
            dgvClasses.DataSource = cb.GetClassViewModel();
        }

        private void SinifForm_Load(object sender, EventArgs e)
        {
           cmbLesson.BindCombobox<Lesson>("LessonName", "LessonId", lb.GetLessons());
           dgvClasses.DataSource =  cb.GetClassViewModel();
        }

        private void dgvInspections_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvClasses.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                txtId.Text = selectedRow.Cells["ClassId"].Value.ToString();
                txtClassName.Text = selectedRow.Cells["ClassName"].Value.ToString();
                cmbLesson.Text = selectedRow.Cells["LessonName"].Value.ToString();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MExcel.Application ExcelApp = new MExcel.Application();
            MExcel.Workbook AlbumsBook = ExcelApp.Workbooks.Add(true);
            MExcel.Worksheet ExcelPage = (MExcel.Worksheet)ExcelApp.ActiveSheet;

            ExcelApp.Visible = true;
            int rowNumber = 1;
            ExcelPage.Cells[1, 1] = "Sınıf Adı";
            ExcelPage.Cells[1, 2] = "Ders Adı";
            


            foreach (DataGridViewRow row in dgvClasses.Rows)
            {
                rowNumber++;
                ExcelPage.Cells[rowNumber, 1] = row.Cells["ClassName"].Value;
                ExcelPage.Cells[rowNumber, 2] = row.Cells["LessonName"].Value;

            }
            ExcelApp.Quit();
        }
        private void TxtSearch_TabStopChanged(object sender, EventArgs e)
        {
            dgvClasses.DataSource = cb.GetClassViewModel().Where(x => x.ClassName.Contains(txtSearch.Text)).ToList();
        }
    }
}
