using _BusinessLayer.Repository.Concrete;
using _DataLayer.Entities;
using _PresentationLayer.Extensions;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MExcel = Microsoft.Office.Interop.Excel;

namespace _PresentationLayer.Forms.Functions
{
    public partial class MaasForm : Form
    {
        RoleBusiness rb = new RoleBusiness();
        EmployeePaymentBusiness epb = new EmployeePaymentBusiness();
        public void PieChartGet()
        {
            pieChart1.LegendLocation = LiveCharts.LegendLocation.Bottom;
            pieChart1.InnerRadius = 100;
            SeriesCollection series = new SeriesCollection();

            foreach (var dr in epb.GetEmployeePayments())
            {
                series.Add(new PieSeries
                {
                    Title = dr.RoleId.ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dr.Maaslar) },
                    DataLabels = true
                });
            }

            pieChart1.Series = series;
        }
        public MaasForm()
        {
            InitializeComponent();
            PieChartGet();
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

        private void dgvSalarys_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = dgvSalarys.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                txtId.Text = selectedRow.Cells["EmployeePaymentId"].Value.ToString();
                txtPayment.Text = selectedRow.Cells["Maaslar"].Value.ToString();
                cmbRole.Text = selectedRow.Cells["RoleName"].Value.ToString();

            }
        }
        public EmployeePayment GetPayment()
        {
            var result = new EmployeePayment
            {
                EmployeePaymentId=Convert.ToInt32(txtId.Text),
                Maaslar= Convert.ToDecimal(txtPayment.Text),
                RoleId= Convert.ToInt32(cmbRole.SelectedValue)
            };
            return result;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            epb.Delete(GetPayment().EmployeePaymentId);
            dgvSalarys.DataSource = epb.GetViewEmployeePayments();
            PieChartGet();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            epb.Add(GetPayment());
            dgvSalarys.DataSource = epb.GetViewEmployeePayments();
            PieChartGet();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            epb.Edit(GetPayment());
            dgvSalarys.DataSource = epb.GetViewEmployeePayments();
            PieChartGet();

        }
        Func<ChartPoint, string> labelPoint = chartPoint =>
               string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
        private void MaasForm_Load(object sender, EventArgs e)
        {
            cmbRole.BindCombobox<Role>("RoleName", "RoleId",rb.GetRoles());
            dgvSalarys.DataSource = epb.GetViewEmployeePayments();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MExcel.Application ExcelApp = new MExcel.Application();
            MExcel.Workbook AlbumsBook = ExcelApp.Workbooks.Add(true);
            MExcel.Worksheet ExcelPage = (MExcel.Worksheet)ExcelApp.ActiveSheet;

            ExcelApp.Visible = true;
            int rowNumber = 1;
            ExcelPage.Cells[1, 1] = "Meslek";
            ExcelPage.Cells[1, 2] = "Maaş";
            


            foreach (DataGridViewRow row in dgvSalarys.Rows)
            {
                rowNumber++;
                ExcelPage.Cells[rowNumber, 1] = row.Cells["RoleName"].Value;
                ExcelPage.Cells[rowNumber, 2] = row.Cells["Maaslar"].Value;
                


            }
            ExcelApp.Quit();
        }
        PrivacyCourseDBEntities db = new PrivacyCourseDBEntities();
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvSalarys.DataSource = db.EmployeePayments.Where(x => x.EmployeePaymentId.ToString().Contains(txtSearch.Text)).ToList();
        }
    }
}
