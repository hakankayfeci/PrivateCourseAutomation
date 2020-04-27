using _BusinessLayer.Business;
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
    public partial class PersonelForm : Form
    {
        EmployeeBusiness eb = new EmployeeBusiness();
        RoleBusiness rb = new RoleBusiness();
        AuthorizedNumberBusiness an = new AuthorizedNumberBusiness();
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            cmbJobs.BindCombobox<Role>("RoleName", "RoleId", rb.GetRoles());
            dgvPersonels.DataSource = eb.GetPersonelViewModel();
        }

        private void pnlKontrol_MouseDown(object sender, MouseEventArgs e)
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
        public Employee GetEmployees()
        {
            var yetki = an.GetByAuthorizeNumber(Convert.ToInt32(txtAuthorizeNo.Text));
            var result = new Employee
            {
                Firstname=txtName.Text,
                Lastname=txtLastName.Text,
                IdentityNo=txtTc.Text,
                AuthorizeNumberId=yetki.AuthorizeNumberId,
                Email=txtemail.Text,
                Birthday=dtpBirthday.Value,
                EmployeeId=Convert.ToInt32(txtId.Text),
                RoleId= Convert.ToInt32(cmbJobs.SelectedValue),
                Phone=txtPhone.Text,
                LowerEmail=txtemail.Text.ToLower()
            };
            return result;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            eb.Add(GetEmployees());
            dgvPersonels.DataSource = eb.GetPersonelViewModel();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            eb.Edit(GetEmployees());

            dgvPersonels.DataSource = eb.GetPersonelViewModel();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            eb.Delete(GetEmployees().EmployeeId);
            dgvPersonels.DataSource = eb.GetPersonelViewModel();

        }

        private void dgvPersonels_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvPersonels.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                txtId.Text = selectedRow.Cells["EmployeeId"].Value.ToString();
                txtName.Text = selectedRow.Cells["Firstname"].Value.ToString();
                txtLastName.Text = selectedRow.Cells["Lastname"].Value.ToString();
                txtTc.Text = selectedRow.Cells["IdentityNo"].Value.ToString();
                txtAuthorizeNo.Text = selectedRow.Cells["AuthorizeNumber"].Value.ToString();
                txtemail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                dtpBirthday.Text = selectedRow.Cells["Birthday"].Value.ToString();
                cmbJobs.Text = selectedRow.Cells["RoleName"].Value.ToString();
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
            ExcelPage.Cells[1, 2] = "Soyisim";
            ExcelPage.Cells[1, 3] = "Doğum Tarihi";
            ExcelPage.Cells[1, 4] = "Tel";
            ExcelPage.Cells[1, 5] = "TC";
            ExcelPage.Cells[1, 6] = "Email";
            ExcelPage.Cells[1, 7] = "Mesleği";


            foreach (DataGridViewRow row in dgvPersonels.Rows)
            {
                rowNumber++;
                ExcelPage.Cells[rowNumber, 1] = row.Cells["Firstname"].Value;
                ExcelPage.Cells[rowNumber, 2] = row.Cells["Lastname"].Value;
                ExcelPage.Cells[rowNumber, 3] = row.Cells["Birthday"].Value;
                ExcelPage.Cells[rowNumber, 4] = row.Cells["Phone"].Value;
                ExcelPage.Cells[rowNumber, 5] = row.Cells["IdentityNo"].Value;
                ExcelPage.Cells[rowNumber, 6] = row.Cells["Email"].Value;
                ExcelPage.Cells[rowNumber, 7] = row.Cells["RoleName"].Value;


            }
            ExcelApp.Quit();
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvPersonels.DataSource = eb.GetPersonelViewModel().Where(x => x.Firstname.Contains(txtSearch.Text)).ToList();
        }
    }
}
