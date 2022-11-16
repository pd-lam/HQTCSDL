using HQTCSDL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQTCSDL.Util
{
    public class Utils
    {
        public DataTable CreateStaffTable(List<Nhan_Vien> StaffList)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MNV", typeof(int));
            dataTable.Columns.Add("Họ", typeof(string));
            dataTable.Columns.Add("Tên", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("SĐT", typeof(string));
            dataTable.Columns.Add("Trạng thái", typeof(int));
            dataTable.Columns.Add("MCH", typeof(int));
            dataTable.Columns.Add("MNQL", typeof(int));

            foreach (var staff in StaffList)
            {
                DataRow r = dataTable.NewRow();
                r["MNV"] = staff.Ma_Nhan_Vien;
                r["Họ"] = staff.Ho;
                r["Tên"] = staff.Ten;
                r["Email"] = staff.Email;
                r["SĐT"] = staff.SDT;
                r["Trạng thái"] = staff.Trang_Thai_HD;
                r["MCH"] = staff.Ma_Cua_Hang;
                if (staff.Ma_Nguoi_Quan_Ly == null)
                {
                    r["MNQL"] = DBNull.Value;
                }
                else
                {
                    r["MNQL"] = staff.Ma_Nguoi_Quan_Ly;
                }
                dataTable.Rows.Add(r);
            }
            return dataTable;
        }

        public DataTable CreateOrderItemByStaffIdTable(List<view_ThongTinGiaoHang> OrderItemList)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã KH", typeof(int));
                dataTable.Columns.Add("Tên KH", typeof(string));
                dataTable.Columns.Add("Mã ĐH", typeof(int));
                dataTable.Columns.Add("Trạng thái", typeof(int));
                dataTable.Columns.Add("Ngày đặt", typeof(DateTime));
                dataTable.Columns.Add("Ngày giao", typeof(DateTime));
                dataTable.Columns.Add("Tên SP", typeof(string));
                dataTable.Columns.Add("Giá SP", typeof(float));

                foreach (var order_item in OrderItemList)
                {
                    DataRow r = dataTable.NewRow();
                    r["Mã KH"] = order_item.Ma_KH;
                    r["Tên KH"] = "";
                    r["Mã ĐH"] = order_item.Ma_Don_Hang;
                    r["Trạng thái"] = order_item.Trang_Thai_Giao_Hang;
                    r["Ngày đặt"] = order_item.Ngay_Dat_Hang;
                    r["Ngày giao"] = order_item.Ngay_Van_Chuyen;
                    r["Tên SP"] = order_item.Ten_San_Pham;
                    r["Giá SP"] = order_item.Gia_SP;
                    dataTable.Rows.Add(r);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public void ShowAllStaff(DataGridView dataGridView)
        {
            using (var context = new BikeStoreEntities())
            {
                var StaffList = context.sp_FindAllEmployee().ToList();
                DataTable dataTable = CreateStaffTable(StaffList);
                dataGridView.DataSource = dataTable;
            }
        }

        public void ShowStaffByName(DataGridView dataGridView, string name)
        {
            using (var context = new BikeStoreEntities())
            {
                var StaffList = context.sp_FindEmployeeByName(name).ToList();
                DataTable dataTable = CreateStaffTable(StaffList);
                dataGridView.DataSource = dataTable;
            }
        }

        public void ShowOrderItemStaffId(DataGridView dataGridView) 
        {
            using (var context = new BikeStoreEntities())
            {
                var OrderItemList = context.sp_FindBillEmployee(1).ToList();
                dataGridView.DataSource = CreateOrderItemByStaffIdTable(OrderItemList);
            }
        }
    }
}
