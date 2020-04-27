using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PresentationLayer.Forms.FormAction
{
    public partial class RegisterSuccessfuly : Form
    {
        public RegisterSuccessfuly()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }

        private void icon_delay_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            icon_delay.Stop();
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void icon_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            icon_delay.Start();
            icon.Enabled = true;
        }

        private void RegisterSuccessfuly_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }
    }
}
