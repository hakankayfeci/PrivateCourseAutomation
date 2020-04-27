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
    public partial class RolForm : Form
    {
        RoleBusiness rb = new RoleBusiness();

        public RolForm()
        {
            InitializeComponent();
        }

        private void RolForm_Load(object sender, EventArgs e)
        {
            dgvRoles.DataSource = rb.GetRoles();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            /*Formu alt kısma almak için kullanılan kod.*/
            this.WindowState = FormWindowState.Minimized;
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
        public Role GetRole()
        {
            var role = new Role
            {
                RoleId=Convert.ToInt32(txtId.Text),
                RoleName=txtRoleName.Text
            };
            return role;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            rb.Add(GetRole());
            dgvRoles.DataSource = rb.GetRoles();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            rb.Edit(GetRole());
            dgvRoles.DataSource = rb.GetRoles();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            rb.Delete(GetRole().RoleId);
            dgvRoles.DataSource = rb.GetRoles();

        }

        private void dgvRoles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvRoles.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                txtId.Text = selectedRow.Cells["RoleId"].Value.ToString();
                txtRoleName.Text = selectedRow.Cells["RoleName"].Value.ToString();

            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MExcel.Application ExcelApp = new MExcel.Application();
            MExcel.Workbook AlbumsBook = ExcelApp.Workbooks.Add(true);
            MExcel.Worksheet ExcelPage = (MExcel.Worksheet)ExcelApp.ActiveSheet;

            ExcelApp.Visible = true;
            int rowNumber = 1;
            ExcelPage.Cells[1, 1] = "Mesleği";
            


            foreach (DataGridViewRow row in dgvRoles.Rows)
            {
                rowNumber++;
                ExcelPage.Cells[rowNumber, 1] = row.Cells["RoleName"].Value;
                


            }
            ExcelApp.Quit();
        }
        PrivacyCourseDBEntities db = new PrivacyCourseDBEntities();
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvRoles.DataSource = db.Roles.Where(x => x.RoleName.Contains(txtSearch.Text)).ToList();
        }
    }
}
