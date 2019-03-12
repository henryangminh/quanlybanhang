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
            getProductType();
            getInvoice();
            getCustomer();
            getDelivery();

            grvProduct.CellClick += new DataGridViewCellEventHandler(editProducts);
            btnEdit.Click += new EventHandler(updateProduct);
            btnAddProduct.Click += new EventHandler(addProduct);
            grvInvoice.CellClick += new DataGridViewCellEventHandler(getInvoiceDetails);
            grvProductType.CellClick += new DataGridViewCellEventHandler(editProductTypes);
        }

        private void getInvoiceDetails(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView != null)
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    string invoiceId = grvInvoice.Rows[rowIndex].Cells[0].Value.ToString();
                    lblInvoiceDetailsId.Text = invoiceId;

                    grvInvoiceDetails.Rows.Clear();

                    CTHDBUS cTHDBUS = new CTHDBUS();
                    DataTable dataTableInvoiceDetails = cTHDBUS.GetAllInvoiceDetailsByInvoiceId(Convert.ToInt32(invoiceId));

                    foreach (DataRow row in dataTableInvoiceDetails.Rows)
                    {
                        int n = grvInvoiceDetails.Rows.Add();
                        grvInvoiceDetails.Rows[n].Cells[0].Value = row[6].ToString();
                        grvInvoiceDetails.Rows[n].Cells[1].Value = row[10].ToString();
                        grvInvoiceDetails.Rows[n].Cells[2].Value = row[7].ToString();
                        grvInvoiceDetails.Rows[n].Cells[2].Value = row[8].ToString();
                    }

                    lblInvoiceTotalPrice.Text = grvInvoice.Rows[rowIndex].Cells[4].Value.ToString();
                    lblInvoiceSaleOff.Text = (Convert.ToDouble(grvInvoice.Rows[rowIndex].Cells[3].Value.ToString())*100).ToString() + "%";
                    lblInvoiceDetailsPayment.Text = ((1.0 - Convert.ToDouble(grvInvoice.Rows[rowIndex].Cells[3].Value.ToString())) * Convert.ToDouble(grvInvoice.Rows[rowIndex].Cells[4].Value.ToString())).ToString();
                }
            }
        }

        private void editProductTypes(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView != null)
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    lblProductTypeId.Text = grvProductType.Rows[rowIndex].Cells[0].Value.ToString();
                    txtEditProductType.Text = grvProductType.Rows[rowIndex].Cells[1].Value.ToString();
                }
            }
        }

        public void getProductType()
        {
            LoaiThietBiBUS loaiThietBiBUS = new LoaiThietBiBUS();
            DataTable dtLTB = new DataTable();
            dtLTB = loaiThietBiBUS.GetAll();

            foreach (DataRow row in dtLTB.Rows)
            {
                int n = grvProductType.Rows.Add();
                grvProductType.Rows[n].Cells[0].Value = row[0].ToString();
                grvProductType.Rows[n].Cells[1].Value = row[1].ToString();
            }
        }

        private void addProduct(object sender, EventArgs e)
        {
            string TBName = txtThietBiName.Text.ToString();
            int LTBAdd = cbxAddProduct.SelectedIndex + 1;
            int QtyAdd = Convert.ToInt32(txtQtyAdd.Text.ToString());
            int PriceAdd = Convert.ToInt32(txtPriceAdd.Text.ToString());

            //gọi hàm thêm sản phẩm
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
                if (rowIndex >= 0)
                {
                    lblId.Text = grvProduct.Rows[rowIndex].Cells[0].Value.ToString();
                    txtEditProduct.Text = grvProduct.Rows[rowIndex].Cells[1].Value.ToString();
                    cbxEditProductType.DataSource = listLoaiThietBi;
                    cbxEditProductType.Text = grvProduct.Rows[rowIndex].Cells[2].Value.ToString();
                    txtEditProductQty.Text = grvProduct.Rows[rowIndex].Cells[3].Value.ToString();
                    txtEditProductPrice.Text = grvProduct.Rows[rowIndex].Cells[4].Value.ToString();
                }
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

        public void getInvoice()
        {
            HoaDonBUS hoaDonBUS = new HoaDonBUS();
            DataTable dtHD = new DataTable();
            dtHD = hoaDonBUS.GetAll();

            foreach (DataRow row in dtHD.Rows)
            {
                int n = grvInvoice.Rows.Add();
                grvInvoice.Rows[n].Cells[0].Value = row[0].ToString();
                grvInvoice.Rows[n].Cells[1].Value = row[1].ToString();
                grvInvoice.Rows[n].Cells[2].Value = row[2].ToString();
                grvInvoice.Rows[n].Cells[3].Value = row[3].ToString();
                grvInvoice.Rows[n].Cells[4].Value = row[4].ToString();
            }
        }

        public void getCustomer()
        {
            KhachHangBUS hoaDonBUS = new KhachHangBUS();
            DataTable dtKH = new DataTable();
            dtKH = hoaDonBUS.GetAll();

            foreach (DataRow row in dtKH.Rows)
            {
                int n = grvCustomer.Rows.Add();
                grvCustomer.Rows[n].Cells[0].Value = row[0].ToString();
                grvCustomer.Rows[n].Cells[1].Value = row[1].ToString();
                grvCustomer.Rows[n].Cells[2].Value = row[2].ToString();
                grvCustomer.Rows[n].Cells[3].Value = row[3].ToString();
            }
        }

        public void getDelivery ()
        {
            GiaoHangBUS giaoHangBUS = new GiaoHangBUS();
            DataTable dtGH = new DataTable();
            dtGH = giaoHangBUS.GetAll();

            foreach (DataRow row in dtGH.Rows)
            {
                int n = grvDelivery.Rows.Add();
                grvDelivery.Rows[n].Cells[0].Value = row[0].ToString();
                grvDelivery.Rows[n].Cells[1].Value = row[1].ToString();
                //grvCustomer.Rows[n].Cells[2].Value = row[2].ToString();
                grvDelivery.Rows[n].Cells[2].Value = row[3].ToString();
                grvDelivery.Rows[n].Cells[3].Value = row[4].ToString();
                grvDelivery.Rows[n].Cells[4].Value = row[5].ToString();
                grvDelivery.Rows[n].Cells[5].Value = row[6].ToString();
            }
        }
    }
}
