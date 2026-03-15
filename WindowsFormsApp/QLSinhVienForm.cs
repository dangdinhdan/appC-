using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class QLSinhVienForm : Form
    {
        DataClassesDataContext db;

        public QLSinhVienForm()
        {
            db = new DataClassesDataContext();
            InitializeComponent();
            LoadForm();
            LoadMaLop();
            txt_GioiTinh.DataSource = new List<string>()
            {
                "Nam",
                "Nu",
                "Khac"
            };
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            db = new DataClassesDataContext();
            var qr = db.tbl_SinhViens.Where(o => o.Email == txt_Email.Text).FirstOrDefault();
            if (qr != null)
            {
                MessageBox.Show("Sinh viên đã tồn tại");
            }
            else
            {

                tbl_SinhVien new_sinhvien = new tbl_SinhVien();
                new_sinhvien.TenSV = txt_HoTen.Text;
                new_sinhvien.NgaySinh = txt_NgaySinh.Value;
                new_sinhvien.Email = txt_Email.Text;
                new_sinhvien.GioiTinh = txt_GioiTinh.SelectedItem.ToString();
                new_sinhvien.MaLop = cb_MaLop.SelectedValue.ToString();
                new_sinhvien.create_at = DateTime.Now;

                db.tbl_SinhViens.InsertOnSubmit(new_sinhvien);
                db.SubmitChanges();
                LoadForm();
            }
            
        }

        private void txt_MaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_HoTen.Text = dgvsinhvien.Rows[e.RowIndex].Cells["MaSv"].Value.ToString();
                txt_NgaySinh.Text = dgvsinhvien.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                txt_GioiTinh.Text = dgvsinhvien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                txt_Email.Text = dgvsinhvien.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                cb_MaLop.Text = dgvsinhvien.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();


            }
        }

        private void LoadForm()
        {
            string keyword = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                var dssinhvien = db.tbl_SinhViens
                          .Where(o => o.isDelete == false || o.isDelete == null)
                          .Select(o => new
                          {
                              o.MaSV,
                              o.TenSV,
                              o.NgaySinh,
                              o.GioiTinh,
                              o.Email,
                              o.MaLop

                          })
                          .ToList();
                dgvsinhvien.DataSource = dssinhvien;
            }
            else {
                var dssinhvien = db.tbl_SinhViens.Where(o=> o.MaSV==int.Parse(keyword)||o.TenSV.Contains(keyword) ||o.Email.Contains(keyword) ||o.MaLop.Contains(keyword)|| o.GioiTinh.Contains(keyword) && (o.isDelete == false || o.isDelete == null))
                              .Select(o => new
                              {
                                  o.MaSV,
                                  o.TenSV,
                                  o.NgaySinh,
                                  o.GioiTinh,
                                  o.Email,
                                  o.MaLop

                              })
                              .ToList();
                dgvsinhvien.DataSource = dssinhvien;
            }
            

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_GioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void LoadMaLop()
        {
            cb_MaLop.DataSource = db.tbl_LopQLs
                      .Where(x => x.isDelete == false || x.isDelete == null)
                      .ToList();
            cb_MaLop.DisplayMember = "MaLop";
            cb_MaLop.ValueMember = "MaLop";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            db = new DataClassesDataContext();
            var qr = db.tbl_SinhViens.Where(o => o.Email == txt_Email.Text && (o.isDelete==false||o.isDelete==null)).FirstOrDefault();
            if (qr == null)
            {
                MessageBox.Show("không tìm thấy sinh viên cần sửa!!");
            }
            else
            {

                tbl_SinhVien old_sinhvien = qr;
                old_sinhvien.TenSV = txt_HoTen.Text;
                old_sinhvien.NgaySinh = txt_NgaySinh.Value;
                old_sinhvien.Email = txt_Email.Text;
                old_sinhvien.GioiTinh = txt_GioiTinh.SelectedItem.ToString();
                old_sinhvien.MaLop = cb_MaLop.SelectedValue.ToString();
                old_sinhvien.update_at = DateTime.Now;

                
                db.SubmitChanges();
                LoadForm();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            db = new DataClassesDataContext();
            var qr = db.tbl_SinhViens.Where(o => o.Email == txt_Email.Text && (o.isDelete == false || o.isDelete == null)).FirstOrDefault();
            if (qr == null)
            {
                MessageBox.Show("không tìm thấy sinh viên cần xóa!!");
            }
            else
            {

                tbl_SinhVien old_sinhvien = qr;
                old_sinhvien.isDelete= true;
                old_sinhvien.delete_at = DateTime.Now;

                
                db.SubmitChanges();
                LoadForm();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_HoTen.Clear();
            txt_Email.Clear();
            
            txt_NgaySinh = null;
            
        }

        private void txt_GioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
