using BUS;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
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
                        cell.InnerHtml = "<asp:CheckBox runat='server' ID='chkSelected' value='" + item + "' OnCheckedChanged='addListSelect'></asp:CheckBox>";
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
        [WebMethod]
        public static string OnSubmit()
        {
            return "it worked";
        }
        protected void SaveInvoice (object sender, EventArgs e)
        {
            int MaKhachHang = int.Parse(txtMaKhachHang.Value);
            string TenKhachGiao = txtTenKhachGiao.Value;
            string DiaChi = txtDiaChi.Value;
            string Contact = txtContact.Value;
			int MaHD = 0;
			int KhId = 1;
			DateTime DateCreate = DateTime.Now;
			int Total = 0;
			HoaDonDTO hd = new HoaDonDTO(MaHD, KhId, DateCreate, Total);
			hoaDonBUS.Add(hd);
            //foreach (Control ctrl in pnlTblSelected.Controls)
            //{

            //}
        }

        /*
        public void GetTable(List<Object> selectedList)
        {
            string i = "get duoc";
        }
        */

        [System.Web.Services.WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static int GetTable(List<Object> j)
        {
            return 0;
        }
        
        protected void addListSelect(object sender, EventArgs e)
        {
            if(sender != null)
            {
                try
                {
                    Console.Write("Abc");
                    //if((CheckBox))
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}