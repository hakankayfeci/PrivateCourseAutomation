using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using _DataLayer.Entities;
using LiveCharts;
using LiveCharts.Wpf;
using _BusinessLayer.Repository.Concrete;
using MExcel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Windows;

namespace _PresentationLayer.Forms.Functions
{
    public partial class GiderForm : Form
    {
        PrivacyCourseDBEntities db = new PrivacyCourseDBEntities();
        EmployeeExpensBusiness eeb = new EmployeeExpensBusiness();
        public GiderForm()
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
        Func<ChartPoint, string> labelPoint = chartPoint =>
               string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

        private void GiderForm_Load(object sender, EventArgs e)
        {
            List();
        }
        public EmployeeExpens GetExpens()
        {
            var result = new EmployeeExpens
            {
                EmployeeExpensesId= Convert.ToInt32(txtId.Text),
                Description=txtDescription.Text,
                Name=txtName.Text,
                Price=Convert.ToDecimal(txtPrice.Text),
                
            };
            return result;
        }
        public void List()
        {
            dgvExpenses.DataSource = eeb.GetEmployeeExpenss();
            pieChart1.LegendLocation = LiveCharts.LegendLocation.Bottom;
            pieChart1.InnerRadius = 100;
            SeriesCollection series = new SeriesCollection();

            foreach (var dr in eeb.GetEmployeeExpenss())
            {
                series.Add(new PieSeries
                {
                    Title = dr.Name.ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dr.Price) },
                    DataLabels = true,
                });
            }

            pieChart1.Series = series;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            eeb.Add(GetExpens());
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            eeb.Delete(GetExpens().EmployeeExpensesId);
            List();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            eeb.Edit(GetExpens());
            List();
        }

        private void dgvExpenses_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvExpenses.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                txtId.Text = selectedRow.Cells["EmployeeExpensesId"].Value.ToString();
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MExcel.Application ExcelApp = new MExcel.Application();
            MExcel.Workbook AlbumsBook = ExcelApp.Workbooks.Add(true);
            MExcel.Worksheet ExcelPage = (MExcel.Worksheet)ExcelApp.ActiveSheet;

            ExcelApp.Visible = true;
            int rowNumber = 1;
            ExcelPage.Cells[1, 1] = "İsim";
            ExcelPage.Cells[1, 2] = "Fiyat";
            ExcelPage.Cells[1, 3] = "Açıklama";
            


            foreach (DataGridViewRow row in dgvExpenses.Rows)
            {
                rowNumber++;
                ExcelPage.Cells[rowNumber, 1] = row.Cells["Name"].Value;
                ExcelPage.Cells[rowNumber, 2] = row.Cells["Price"].Value;
                ExcelPage.Cells[rowNumber, 3] = row.Cells["Description"].Value;
                


            }
            ExcelApp.Quit();
        }
        
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvExpenses.DataSource = db.EmployeeExpenses.Where(x => x.Name.Contains(txtSearch.Text)).ToList();
        }
    }
}
