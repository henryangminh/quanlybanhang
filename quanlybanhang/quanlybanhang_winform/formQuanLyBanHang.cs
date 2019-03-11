using BUS;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybanhang_winform
{
    public partial class formQuanLyBanHang : Form
    {
        public formQuanLyBanHang()
        {
            InitializeComponent();
            getProduct();
            grvProduct.CellClick += new DataGridViewCellEventHandler(editProducts);
            btnEdit.Click += new EventHandler(updateProduct);
            btnAddProduct.Click += new EventHandler(addProduct);
        }

        private void addProduct(object sender, EventArgs e)
        {
            string TBName = txtThietBiName.Text.ToString();
            int LTBAdd = cbxAddProduct.SelectedIndex + 1;
            int QtyAdd = Convert.ToInt32(txtQtyAdd.Text.ToString());
            int PriceAdd = Convert.ToInt32(txtPriceAdd.Text.ToString());
        }

        private void updateProduct(object sender, EventArgs e)
        {
            int idEditProduct = Convert.ToInt32(lblId.Text.ToString());
            string NameEditProduct = txtEditProduct.Text.ToString();
            int TypeProductEdit = cbxEditProductType.SelectedIndex + 1;
            int EditProductQty = Convert.ToInt32(txtEditProductQty.Text.ToString());
            int EditProductPrice = Convert.ToInt32(txtEditProductPrice.Text.ToString());

            //gọi hàm sửa sản phẩm
        }

        public void editProducts(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if(dataGridView  != null)
            {
                List<string> listLoaiThietBi = getLoaiThietBi();
                //DataGridViewButtonCell btnEditProduct = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                int rowIndex = e.RowIndex;
                lblId.Text = grvProduct.Rows[rowIndex].Cells[0].Value.ToString();
                txtEditProduct.Text = grvProduct.Rows[rowIndex].Cells[1].Value.ToString();
                cbxEditProductType.DataSource = listLoaiThietBi;
                cbxEditProductType.Text = grvProduct.Rows[rowIndex].Cells[2].Value.ToString();
                txtEditProductQty.Text = grvProduct.Rows[rowIndex].Cells[3].Value.ToString();
                txtEditProductPrice.Text = grvProduct.Rows[rowIndex].Cells[4].Value.ToString();
            }
        }

        public List<string> getLoaiThietBi()
        {
            LoaiThietBiBUS loaiThietBiBUS = new LoaiThietBiBUS();
            DataTable dtLTB = loaiThietBiBUS.GetAll();
            List<string> listLoaiThietBi = new List<string>();
            foreach (DataRow item in dtLTB.Rows)
            {
                listLoaiThietBi.Add(item[1].ToString());
            }
            return listLoaiThietBi;
        }

        public void getProduct()
        {
            ThietBiBUS thietBiBus = new ThietBiBUS();
            DataTable dtTB = new DataTable();
            dtTB = thietBiBus.GetAll();
            List<string> listLoaiThietBi = getLoaiThietBi();

            foreach (DataRow row in dtTB.Rows)
            {
                int n = grvProduct.Rows.Add();
                grvProduct.Rows[n].Cells[0].Value = row[0].ToString();
                grvProduct.Rows[n].Cells[1].Value = row[1].ToString();
                
                var cellComboBox = new DataGridViewComboBoxCell();
                cellComboBox.DataSource = listLoaiThietBi;
                grvProduct.Rows[n].Cells[2] = cellComboBox;
                grvProduct.Rows[n].Cells[2].Value = listLoaiThietBi[Convert.ToInt32(row[2].ToString())-1];

                grvProduct.Rows[n].Cells[3].Value = row[3].ToString();
                grvProduct.Rows[n].Cells[4].Value = row[4].ToString();
            }
        }
    }
}
