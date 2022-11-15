using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQTCSDL.GUI
{
    public partial class frmDashboard : Form
    {
        private Form CustomerSubForm, CategorySubForm, ProductSubForm, StaffSubForm;

        public frmDashboard()
        {
            InitializeComponent();
            AddSubForm();
        }

        private void AddSubForm()
        {
            CustomerSubForm = new frmCustomerManagement() { AutoScroll = true, Dock = DockStyle.Fill, TopLevel = false };
            CategorySubForm = new frmCategoryManagement() { AutoScroll = true, Dock = DockStyle.Fill, TopLevel = false };
            ProductSubForm = new frmProductManagement() { AutoScroll = true, Dock = DockStyle.Fill, TopLevel = false };
            StaffSubForm = new frmStaffManagement() { AutoScroll = true, Dock = DockStyle.Fill, TopLevel = false };
            panelMain.Controls.Add(CustomerSubForm);
            panelMain.Controls.Add(CategorySubForm);
            panelMain.Controls.Add(ProductSubForm);
            panelMain.Controls.Add(StaffSubForm);
        }

        private void ShowSubForm(Form SubForm)
        {
            foreach (Control control in panelMain.Controls)
            {
                if (control != SubForm)
                {
                    control.Hide();
                }
                else
                {
                    control.Show();
                }
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ShowSubForm(CustomerSubForm);
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ShowSubForm(StaffSubForm);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ShowSubForm(ProductSubForm);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnBrand_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
