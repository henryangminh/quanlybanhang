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
    public class HoaDonDAO : Connection, IDal<HoaDonDTO>
    {
        public void Add(HoaDonDTO entity)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("Select * from HoaDon", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow r = dt.NewRow();
            r[0] = entity.Id;
            r[1] = entity.KHId;
            r[2] = entity.DateCreate;
            r[3] = entity.TotalPrice;
            dt.Rows.Add(r);
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Update(dt);
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(HoaDonDTO entity)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public HoaDonDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetByLastestId()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MAX(HDId) from HoaDon", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    var Id =  int.Parse(dr.ItemArray[0].ToString());
                    //var KHId = int.Parse(dr.ItemArray[1].ToString());
                    //var DateCreate = DateTime.Parse(dr.ItemArray[2].ToString());
                    //var TotalPrice = int.Parse(dr.ItemArray[3].ToString());
                    //    foreach
                    //    var Id = Convert.ToInt32(dr["HDId"]);
                    //    var KHId = Convert.ToInt32(dr["KHId"]);
                    //    var DateCreate = Convert.ToDateTime(dr["DateCreate"]);
                    //    var TotalPrice = Convert.ToInt32(dr["TotalPrice"]);
                    return Id;

                }
                return -1;
            }
            catch
            {
                return -1;
            }
        }
    }
}
