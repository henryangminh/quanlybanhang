using DAO.Interfaces;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CTHDDAO : Connection, IDal<CTHDDTO>
    {
        public void Add(CTHDDTO entity)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from CTHD", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow r = dt.NewRow();
            r[0] = entity.HDId;
            r[1] = entity.TBId;
            r[2] = entity.Qty;
            r[3] = entity.Subtotal;
            dt.Rows.Add(r);
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Update(dt);
        }

        public void Add(List<CTHDDTO> entity)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from CTHD", conn);
            HoaDonDTO hoaDonDTO = new HoaDonDTO();
            HoaDonDAO hoaDonDAO = new HoaDonDAO();
            int _HDId = hoaDonDAO.GetByLastestId();
           
            
            foreach (var item in entity)
            {
                item.HDId = _HDId;
                //CTHDDTO tempcthd = new CTHDDTO(_HDId, item[0], item[1], item[2]);
                Add(item);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CTHDDTO entity)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllInvoiceDetailsByInvoiceId(int id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from HoaDon, CTHD, ThietBi where HoaDon.HDId = CTHD.HDId and CTHD.TBId = ThietBi.TBId and HoaDon.HDId = " + id, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public CTHDDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
