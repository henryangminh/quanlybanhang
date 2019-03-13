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
        static ThietBiBUS tbBus = new ThietBiBUS();
        LoaiThietBiBUS ltbBus = new LoaiThietBiBUS();
        static KhachHangBUS khBus = new KhachHangBUS();

        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable tb = tbBus.GetAll();
            //DataTable ltb = ltbBus.GetAll();
            //DataTable kh = khBus.GetByContact();
            //slcType.Items.Clear();


            //foreach (DataRow ltb_row in ltb.Rows)
            //{
            //    string text = ltb_row.ItemArray[1].ToString();
            //    string val = ltb_row.ItemArray[0].ToString();
            //    slcType.Items.Add(new ListItem(text, val));
            //}
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
                        cell.InnerHtml = "<input type='checkbox' runat='server' ID='chkSelected' value='" + item + "' OnCheckedChanged='addListSelect'/>";
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
            //MaintainScrollPositionOnPostBack = false;
            //findKH.Attributes.Add("AutoPostback", "false");
            //btnFindKH.Attributes.Add("onclick", "return false");
        }



        //btnLap.Attributes.Add("OnClick", "SaveInvoice");

        [WebMethod]
        public static void SaveInvoice(int KhId, int total, double saleoff,List<CTHDDTO> listCTHD, GiaoHangDTO GH)
        {
            CTHDBUS cthd = new CTHDBUS();
            int Mahd = 0;
            DateTime DateCreate = DateTime.Now;
            HoaDonBUS hd = new HoaDonBUS();

            HoaDonDTO entity = new HoaDonDTO(Mahd, KhId, DateCreate, saleoff, total);

            CTHDBUS cTHDBUS = new CTHDBUS();
            GiaoHangBUS giaoHangBUS = new GiaoHangBUS();
            hd.Add(entity);
            giaoHangBUS.Add(GH);
            cTHDBUS.Add(listCTHD);
         
        }
        //public void LoadKH(object sender, EventArgs e)
        //{
        //    string contact = txtPhoneNumber.Value;
        //    DataTable kh = khBus.GetByContact(contact);
        //    txtCustomerID.Value = kh.Rows[0].ItemArray[0].ToString();
        //    txtAddress.Value = kh.Rows[0].ItemArray[3].ToString();
        //    txtCustomerName.Value = kh.Rows[0].ItemArray[1].ToString();

        //}
        [WebMethod]
        public static KhachHangDTO GetKH(string contact)
        {
            
            DataTable kh = khBus.GetByContact(contact);
            if (kh.Rows.Count > 0)
            {
                KhachHangDTO _khachhang = new KhachHangDTO(int.Parse(kh.Rows[0].ItemArray[0].ToString()), kh.Rows[0].ItemArray[1].ToString(), kh.Rows[0].ItemArray[2].ToString(), kh.Rows[0].ItemArray[3].ToString());
                return _khachhang;
            }
            else
                return null;
        }

        [WebMethod]
        public static void UpdateTBQty(int id, int qty)
        {
            ThietBiBUS _tbbus = new ThietBiBUS();
            _tbbus.UpdateQty(id, qty);
        }
     

        [WebMethod]
        public static List<ThietBiDTO> GetByType(int Id)
        {
            ThietBiBUS tbBus_gbt = new ThietBiBUS();
            List<ThietBiDTO> rs = new List<ThietBiDTO>();
            DataTable tb = tbBus_gbt.GetByType(Id);
            foreach (DataRow row in tb.Rows)
            {

                int TBId = int.Parse(row.ItemArray[0].ToString());
                string TBName = row.ItemArray[1].ToString();
                int LTBId = int.Parse(row.ItemArray[2].ToString());
                int Price = int.Parse(row.ItemArray[3].ToString());
                int Qty = int.Parse(row.ItemArray[4].ToString());
                ThietBiDTO temp = new ThietBiDTO(TBId, TBName, LTBId, Price, Qty);
                rs.Add(temp);
                
            }
            return rs;
        }

        [WebMethod]
        public static List<ThietBiDTO> GetByName(string keyword)
        {
            List<ThietBiDTO> rs = new List<ThietBiDTO>();
            ThietBiBUS _tbBus = new ThietBiBUS();
            DataTable tb = _tbBus.GetAll();
            //if(keyword=="")
            //{
            //    foreach (DataRow row in tb.Rows)
            //    {

            //            int TBId = int.Parse(row.ItemArray[0].ToString());
            //            string TBName = row.ItemArray[1].ToString();
            //            int LTBId = int.Parse(row.ItemArray[2].ToString());
            //            int Price = int.Parse(row.ItemArray[3].ToString());
            //            int Qty = int.Parse(row.ItemArray[4].ToString());
            //            ThietBiDTO temp = new ThietBiDTO(TBId, TBName, LTBId, Price, Qty);
            //            rs.Add(temp);
                  
            //    }
            //    return rs;
            //}
            foreach (DataRow row in tb.Rows)
            {
                if(row.ItemArray[1].ToString().ToUpper().Contains(keyword.ToUpper()))
                {

                    int TBId = int.Parse(row.ItemArray[0].ToString());
                    string TBName = row.ItemArray[1].ToString();
                    int LTBId = int.Parse(row.ItemArray[2].ToString());
                    int Price = int.Parse(row.ItemArray[3].ToString());
                    int Qty = int.Parse(row.ItemArray[4].ToString());
                    ThietBiDTO temp = new ThietBiDTO(TBId, TBName, LTBId, Price, Qty);
                    rs.Add(temp);
                }

            }
            return rs;
        }

        [WebMethod]
        public static LoaiThietBiDTO GetLTBById(int id)
        {
            LoaiThietBiBUS ltbBus_gltbbi = new LoaiThietBiBUS();
            LoaiThietBiDTO loaiThietBiDTO = ltbBus_gltbbi.GetById(id);
            return loaiThietBiDTO;
        }

        [WebMethod]
        public static void SaveKhachHang(int KHId, string Name, string Contact, string Address)
        {
            KhachHangBUS _KHBus = new KhachHangBUS();
            KhachHangDTO _KH = new KhachHangDTO(KHId, Name, Contact, Address);
            _KHBus.Add(_KH);
            
        }

    }
}