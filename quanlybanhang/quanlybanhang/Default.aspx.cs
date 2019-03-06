using BUS;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace quanlybanhang
{
    public partial class _Default : Page
    {
        ThietBiBUS tbBus = new ThietBiBUS();
        LoaiThietBiBUS ltbBus = new LoaiThietBiBUS();
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
                        cell.InnerHtml = "<input type='checkbox' id='chkSelected' value='"+ item +"'>";
                    }
                    if (row2.Cells.Count == 2)
                    {
                        LoaiThietBiDTO loaiThietBiDTO = ltbBus.GetById(Convert.ToInt32(item));
                        cell.InnerText = loaiThietBiDTO.TypeName;
                    }
                    
                    row2.Cells.Add(cell);
                   
                }
                tbl_ThietBi.Controls.Add(row2);
                //tblThietBi.Rows.Add(row2);
            }
            //TableRow row = new TableHeaderRow();
            //TableRow row2 = new TableRow();
            //TableRow row3 = new TableFooterRow();
            //Table table = new Table();

            ////var cell1 = new TableCell();
            ////row.TableSection = TableRowSection.TableHeader;
            ////cell1.Text = "Header";
            ////row.Cells.Add(cell1);

            //var cell2 = new TableCell();
            //cell2.Text = "Contents";
            //row2.Cells.Add(cell2);

            ////var cell3 = new TableCell();
            ////cell3.Text = "Footer";
            ////row3.Cells.Add(cell3);
            ////row3.TableSection = TableRowSection.TableFooter;


            ////table.Rows.Add(row);
            //table.Rows.Add(row2);
            ////table.Rows.Add(row3);
            //this.Controls.Add(table);
            //TextBox1.Text = "a";
            //txtSearch.Value = "bbbbb";
        }
    }
}