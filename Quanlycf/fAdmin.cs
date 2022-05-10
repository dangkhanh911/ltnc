﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycf
{
    public partial class fAdmin : Form
    {
        public DateTime startTime;
        public DateTime endTime;
        public fAdmin()
        {
            InitializeComponent();
            startTime = DateTime.Now;
            endTime = startTime;
            updategridMainView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addNV_Click(object sender, EventArgs e)
        {

        }

        private void Statistic_Click(object sender, EventArgs e)
        {

        }

        private void Filter_Click(object sender, EventArgs e)
        {

        }

        private void ViewOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void OrderDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addNV_Click_1(object sender, EventArgs e)
        {
            fAddNV temp = new fAddNV();

            temp.ShowDialog();
        }

        private void addMenu_Click_1(object sender, EventArgs e)
        {
            fAddMenu temp = new fAddMenu();

            temp.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updategridMainView();
        }
        private void updategridMainView()
        {
            Class.Function.Connect();
            dvgUser.DataSource = null;
            string sql = "SELECT [dbo].[tblUser].id,[dbo].[tblRole].role_name, [dbo].[tblUser].deleted, [dbo].[tblUser].passwordNV, tblUser.fullname, [dbo].[tblUser].sex, [dbo].[tblUser].dob, [dbo].[tblUser].addressU, [dbo].[tblUser].phone"
                       + " FROM[dbo].[tblUser], [dbo].[tblRole]"
                       + " WHERE[dbo].[tblUser].role_id = [dbo].[tblRole].id;";
            DataTable tblCL = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng

            dvgUser.DataSource = tblCL; //Nguồn dữ liệu            
            //dvgUser.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);


            dvgUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dvgUser.AllowUserToOrderColumns = true;
            //dvgUser.AllowUserToResizeColumns = true;
            // dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            dvgUser.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dvgUser.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Đổi tên header columns
            dvgUser.AllowUserToResizeColumns = true;
            dvgUser.Columns["id"].HeaderText = "ID";
            dvgUser.Columns["role_name"].HeaderText = "Chức vụ";
            dvgUser.Columns["passwordNV"].HeaderText = "Mật khẩu";
            dvgUser.Columns["deleted"].HeaderText = "Xóa?";
            dvgUser.Columns["fullname"].HeaderText = "Họ và tên";
            dvgUser.Columns["dob"].HeaderText = "Năm sinh";
            dvgUser.Columns["addressU"].HeaderText = "Địa chỉ";
            dvgUser.Columns["phone"].HeaderText = "Điện thoại";

            //ID
            dvgUser.Columns[0].Width = 40;
            //Chức vụ
            dvgUser.Columns[1].Width = 80;
            //deleted
            dvgUser.Columns[2].Width = 40;
            //name
            dvgUser.Columns[4].Width = 170;
            //sex
            dvgUser.Columns[5].Width = 40;
            dvgUser.Columns[7].Width = 150;
            dvgUser.Columns[8].Width = 120;

            dvgUser.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgUser.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgUser.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgUser.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Menu
            dvgMenu.DataSource = null;
            sql = "SELECT [dbo].[tblProduct].id,[dbo].[tblProduct].category_id, [dbo].[tblProduct].deleted, [dbo].[tblProduct].title, [dbo].[tblProduct].descriptionP, [dbo].[tblProduct].thumbnail, [dbo].[tblProduct].price, [dbo].[tblProduct].discount"
                       + " FROM[dbo].[tblProduct];";
            tblCL = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng

            dvgMenu.DataSource = tblCL; //Nguồn dữ liệu            
            //dvgMenu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);


            dvgMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dvgMenu.AllowUserToOrderColumns = true;
            //dvgMenu.AllowUserToResizeColumns = true;
            // dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            dvgMenu.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dvgMenu.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Đổi tên header columns
            dvgMenu.AllowUserToResizeColumns = true;
            dvgMenu.Columns["id"].HeaderText = "ID";
            dvgMenu.Columns["category_id"].HeaderText = "Danh mục";
            dvgMenu.Columns["title"].HeaderText = "Tên";
            dvgMenu.Columns["deleted"].HeaderText = "Xóa?";
            dvgMenu.Columns["descriptionP"].HeaderText = "Mô tả";
            dvgMenu.Columns["thumbnail"].HeaderText = "Thumbnail";
            dvgMenu.Columns["price"].HeaderText = "Giá";
            dvgMenu.Columns["discount"].HeaderText = "Giảm giá";

            dvgMenu.Columns[0].Width = 40;
            dvgMenu.Columns[1].Width = 40;
            dvgMenu.Columns[2].Width = 40;
            dvgMenu.Columns[4].Width = 170;
            dvgMenu.Columns[5].Width = 150;
            dvgMenu.Columns[7].Width = 80;
            dvgMenu.Columns[6].Width = 80;

            dvgMenu.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgMenu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgMenu.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgMenu.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tương tự như ở trên
            OrderView.DataSource = null;
            sql = "SELECT [dbo].[tblOrders].id, [dbo].[tblOrders].id_nv, [dbo].[tblUser].fullname, [dbo].[tblOrders].total_money, [dbo].[tblOrders].statusOrder, [dbo].[tblOrders].ngay_ban " +
                "FROM[dbo].[tblOrders], [dbo].[tblUser] " +
                "WHERE[dbo].[tblOrders].id_nv = [dbo].[tblUser].id; ";
            tblCL = Class.Function.GetDataToTable(sql);
            OrderView.DataSource = tblCL;
            OrderView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            OrderView.AllowUserToAddRows = false;
            OrderView.EditMode = DataGridViewEditMode.EditProgrammatically;
            OrderView.AllowUserToResizeColumns = true;
            Count.Text = tblCL.Rows.Count.ToString();
            int sum = 0;
            for (int i = 0; i < tblCL.Rows.Count; i++)
            {
                sum += (int)tblCL.Rows[i][3];
            }
            TotalMoney.Text = sum.ToString();
            //DateDetail.
            if (tblCL.Rows.Count <= 1)
            {
                DateDetail.Visible = false;
            }
            else
            {
                DateTime minTime = (DateTime)tblCL.Rows[0][5];
                DateTime maxTime = minTime;
                for (int i = 0; i < tblCL.Rows.Count; i++)
                {
                    if (DateTime.Compare(minTime, (DateTime)tblCL.Rows[i][5]) > 0)
                    {
                        minTime = (DateTime)tblCL.Rows[i][5];
                    }
                    if (DateTime.Compare(maxTime, (DateTime)tblCL.Rows[i][5]) < 0)
                    {
                        maxTime = (DateTime)tblCL.Rows[i][5];
                    }
                }
                startTime = minTime;
                endTime = maxTime;
                DateDetail.Text = "Từ: " + startTime.Date.ToString("dd/MM/yyyy") + ", Đến: " + endTime.Date.ToString("dd/MM/yyyy");
                DateDetail.Visible = true;
            }

            OrderView.Columns["id"].HeaderText = "Mã đơn hàng";
            OrderView.Columns["id_nv"].HeaderText = "Mã nhân viên";
            OrderView.Columns["fullname"].HeaderText = "Tên nhân viên";
            OrderView.Columns["total_money"].HeaderText = "Tổng hóa đơn";
            OrderView.Columns["statusOrder"].HeaderText = "Trạng thái thanh toán";
            OrderView.Columns["ngay_ban"].HeaderText = "Ngày bán";
            OrderView.Columns[2].Width = 180;
            OrderView.Columns[4].Width = 100;

            // Alingment column at middle Center
            OrderView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            OrderView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            OrderView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            OrderView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            OrderView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Class.Function.Disconnect();
        }

        private void editNV_Click(object sender, EventArgs e)
        {
            fEditAdmin temp = new fEditAdmin();
            temp.ShowDialog();
        }

        private void editMenu_Click(object sender, EventArgs e)
        {
            fEditMenu temp = new fEditMenu();
            temp.ShowDialog();
        }

        private void deleteNV_Click(object sender, EventArgs e)
        {
            fDeleteNV temp = new fDeleteNV();
            temp.ShowDialog();
        }

        private void deleteMenu_Click(object sender, EventArgs e)
        {
            fDeleteMenu temp = new fDeleteMenu();
            temp.ShowDialog();
        }

        private void OrderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewOrderButton_Click_1(object sender, EventArgs e)
        {
            fViewDetail temp = new fViewDetail();
            temp.ShowDialog();
        }

        private void Filter_Click_1(object sender, EventArgs e)
        {
            fFilter temp = new fFilter();
            temp.ShowDialog();
            Class.Function.Connect();
            string sql = temp.sql;
            if (sql == "")
            {
                return;
            }
            MessageBox.Show("Thời gian hợp lệ!", "Message", MessageBoxButtons.OK);
            DataTable tblCL = Class.Function.GetDataToTable(sql);
            OrderView.DataSource = tblCL;
            OrderView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            OrderView.AllowUserToAddRows = false;
            OrderView.EditMode = DataGridViewEditMode.EditProgrammatically;
            OrderView.AllowUserToResizeColumns = true;
            Count.Text = tblCL.Rows.Count.ToString();
            int sum = 0;
            for (int i = 0; i < tblCL.Rows.Count; i++)
            {
                sum += (int)tblCL.Rows[i][3];
            }
            TotalMoney.Text = sum.ToString();
            //DateDetail.
            if (tblCL.Rows.Count <= 1)
            {
                DateDetail.Visible = false;
            }
            else
            {
                DateTime minTime = (DateTime)tblCL.Rows[0][5];
                DateTime maxTime = minTime;
                for (int i = 0; i < tblCL.Rows.Count; i++)
                {
                    if (DateTime.Compare(minTime, (DateTime)tblCL.Rows[i][5]) > 0)
                    {
                        minTime = (DateTime)tblCL.Rows[i][5];
                    }
                    if (DateTime.Compare(maxTime, (DateTime)tblCL.Rows[i][5]) < 0)
                    {
                        maxTime = (DateTime)tblCL.Rows[i][5];
                    }
                }
                startTime = minTime;
                endTime = maxTime;
                DateDetail.Text = "Từ: " + startTime.Date.ToString("dd/MM/yyyy") + ", Đến: " + endTime.Date.ToString("dd/MM/yyyy");
                DateDetail.Visible = true;
            }
            OrderView.Columns["id"].HeaderText = "Mã đơn hàng";
            OrderView.Columns["id_nv"].HeaderText = "Mã nhân viên";
            OrderView.Columns["fullname"].HeaderText = "Tên nhân viên";
            OrderView.Columns["total_money"].HeaderText = "Tổng hóa đơn";
            OrderView.Columns["statusOrder"].HeaderText = "Trạng thái thanh toán";
            OrderView.Columns["ngay_ban"].HeaderText = "Ngày bán";
            Class.Function.Disconnect();
        }

        private void Statistic_Click_1(object sender, EventArgs e)
        {
            fChart chart = new fChart(startTime, endTime);
            chart.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updategridMainView();
            MessageBox.Show("Cập nhật thành công!", "Message", MessageBoxButtons.OK);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
