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
    public class GiaoHangDAO : Connection, IDal<GiaoHangDTO>
    {
        public DataTable GetAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from GiaoHang", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(GiaoHangDTO entity)
        {
            throw new NotImplementedException();
        }

        

        public GiaoHangDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(GiaoHangDTO entity)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from GiaoHang", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            HoaDonDAO hoaDonDAO = new HoaDonDAO();
            int _HDId = hoaDonDAO.GetByLastestId();
            DataRow r = dt.NewRow();
            var _dateDeli = DateTime.Now;
            r[0] = entity.Id;
            r[1] = _HDId;
            r[2] = entity.TotalPrice;
            r[3] = _dateDeli;
            r[4] = entity.CustomerName;
            r[5] = entity.DeliveryContact;
            r[6] = entity.DeliveryAddress;

            dt.Rows.Add(r);
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Update(dt);
        }
    }
}
