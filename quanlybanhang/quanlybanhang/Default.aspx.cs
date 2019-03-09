using BUS;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace quanlybanhang
{
    public partial class _Default : Page
    {
        ThietBiBUS tbBus = new ThietBiBUS();
        LoaiThietBiBUS ltbBus = new LoaiThietBiBUS();
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable tb = tbBus.GetAll();
            DataTable ltb = ltbBus.GetAll();
            List<LoaiThietBiDTO> LoaiThietBiDTOs = new List<LoaiThietBiDTO>();


            foreach (DataRow ltb_row in ltb.Rows)
            {

                LoaiThietBiDTO _LoaiThietBiDTO = new LoaiThietBiDTO(int.Parse(ltb_row.ItemArray[0].ToString()), ltb_row.ItemArray[1].ToString());
                LoaiThietBiDTOs.Add(_LoaiThietBiDTO);

            }
            foreach (DataRow row in tb.Rows)
            {
                HtmlTableRow row2 = new HtmlTableRow();
                foreach (var item in row.ItemArray)
                {

                    var cell = new HtmlTableCell();

                    //var loai = this.
                    cell.InnerText = item.ToString();
                    if (row2.Cells.Count == 0)
                    {
                        cell.InnerHtml = "<input type='checkbox' id='chkSelected' value='" + item + "'>";
                    }
                    if (row2.Cells.Count == 2)
                    {
                        LoaiThietBiDTO loaiThietBiDTO = ltbBus.GetById(Convert.ToInt32(item));
                        cell.InnerText = loaiThietBiDTO.TypeName;
                    }

                    row2.Cells.Add(cell);

                }
                tbl_ThietBi.Controls.Add(row2);
            }

            //btnLap.Attributes.Add("OnClick", "SaveInvoice");
        }
        //[WebMethod]
        //public static string SaveEnity()
        protected void SaveInvoice (object sender, EventArgs e)
        {
            
            int MaKhachHang = int.Parse(txtMaKhachHang.Value);
            string TenKhachGiao = txtTenKhachGiao.Value;
            string DiaChi = txtDiaChi.Value;
            string Contact = txtContact.Value;
            int MaHD = 0;
            int KhID = 1;
            DateTime DateCreate = DateTime.Now;
            int total = 0;
            HoaDonDTO entity = new HoaDonDTO(MaHD, KhID, DateCreate, total);
            hoaDonBUS.Add(entity);
        }
    }
}