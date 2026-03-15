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
    public partial class QLLopForm : Form
    {
        DataClassesDataContext db;
        List<tbl_LopQL> dslopquanly;


        public QLLopForm()
        {
            db = new DataClassesDataContext();
            InitializeComponent();
            
            LoadLop();
                       
        }

       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadLop();
        }

        private void listv_LopQL_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_MaLop.Text = dgvLop.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
                txt_TenLop.Text = dgvLop.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();

            }
        }
        private void LoadLop()
        {
            
            string keyword = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                var dsLop = db.tbl_LopQLs
                          .Where(o => o.isDelete == false || o.isDelete == null)
                          .Select(o => new
                          {
                              o.MaLop,
                              o.TenLop


                          })
                          .ToList();

                dgvLop.DataSource = dsLop;
            }
            else
            {
                var dsLop = db.tbl_LopQLs
                          .Where(o=>o.MaLop.Contains(keyword)||o.TenLop.Contains(keyword) && (o.isDelete == false || o.isDelete == null))
                          .Select(o => new
                          {
                              o.MaLop,
                              o.TenLop


                          })
                          .ToList();

                dgvLop.DataSource = dsLop;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            db = new DataClassesDataContext();
            
            var qr = db.tbl_LopQLs.Where(o => o.MaLop == txt_MaLop.Text).FirstOrDefault();
            if (qr != null)
            {
                tbl_LopQL old_lopql = qr;
                old_lopql.MaLop = txt_MaLop.Text;
                old_lopql.TenLop = txt_TenLop.Text;
                old_lopql.create_at = DateTime.Now;
                old_lopql.update_at = DateTime.Now;
                old_lopql.isDelete = false;


                db.SubmitChanges();
            }
            else { 
                tbl_LopQL new_lopql = new tbl_LopQL();
                new_lopql.MaLop = txt_MaLop.Text;
                new_lopql.TenLop = txt_TenLop.Text;
                new_lopql.create_at = DateTime.Now;

                db.tbl_LopQLs.InsertOnSubmit(new_lopql);
                db.SubmitChanges();
                LoadLop();
            }
        }
        private void txt_MaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            db = new DataClassesDataContext();

            var qr = db.tbl_LopQLs.Where(o => o.MaLop == txt_MaLop.Text).FirstOrDefault();
            if (qr != null)
            {
                MessageBox.Show("không tìm thấy lớp cần sửa");
            }
            else
            {
                tbl_LopQL old_lopql = qr;
                old_lopql.MaLop = txt_MaLop.Text;
                old_lopql.TenLop = txt_TenLop.Text;
                old_lopql.update_at = DateTime.Now;

                
                db.SubmitChanges();
                LoadLop();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            db = new DataClassesDataContext();

            var qr = db.tbl_LopQLs.Where(o => o.MaLop == txt_MaLop.Text && (o.isDelete==false||o.isDelete==null)).FirstOrDefault();
            if (qr == null)
            {
                MessageBox.Show("không tìm thấy lớp cần xóa");
            }
            else
            {
                tbl_LopQL old_lopql = qr;
                old_lopql.isDelete = true;


                db.SubmitChanges();
                LoadLop();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_MaLop.Clear();
            txt_TenLop.Clear();
        }
    }
}
