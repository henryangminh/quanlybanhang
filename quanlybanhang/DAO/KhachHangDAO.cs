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
    public class KhachHangDAO : Connection, IDal<KhachHangDTO>
    {

        public void Add(KhachHangDTO entity)
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from KhachHang", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow r = dt.NewRow();
            r[0] = entity.Id;
            r[1] = entity.Name;
            r[2] = entity.Contact;
            r[3] = entity.Address;
            dt.Rows.Add(r);
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Update(dt);

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(KhachHangDTO entity)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from KhachHang", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public KhachHangDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
        public DataTable GetByContact(string contact)
        {
            try
            {
                
                SqlDataAdapter da = new SqlDataAdapter("Select * from KhachHang where Contact='" + contact + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
