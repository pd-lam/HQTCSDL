using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastMember;
using HQTCSDL.Entity;
using HQTCSDL.Util;

namespace HQTCSDL.GUI
{
    public partial class frmStaffManagement : Form
    {
        Utils utils = new Utils();
        public frmStaffManagement()
        {
            InitializeComponent();
            utils.ShowAllStaff(dataGridView);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            utils.ShowStaffByName(dataGridView, tbSearch.Text);
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Form StaffDetail = new frmStaffDetail();
            StaffDetail.ShowDialog();
        }
    }
}
