using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace _PresentationLayer.Forms.Functions
{
    public partial class SuccesfulyMessageForm : Form
    {
        public MembershipUser _user  { get; set; }
        public SuccesfulyMessageForm(MembershipUser user)
        {
            _user = user;
            InitializeComponent();
        }

        private void SuccesfulyMessageForm_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            icon_delay.Start();
            icon.Enabled = true;
        }

        private void icon_delay_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            icon_delay.Stop();
            
            MainForm mf = new MainForm(_user);
            mf.Show();
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        }
    }
}
