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
            try
            {
                string sql = "INSERT INTO HoaDon VALUES(" + entity.Id + "," + entity.KHId + ",'" + entity.DateCreate + "'," + entity.TotalPrice + ")";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                DataRowCollection rowCollection = dt.Rows;
                // Instantiate a new row using the NewRow method.

                DataRow r = dt.NewRow();
                // Insert code to fill the row with values.

                // Add the row to the DataRowCollection.
                
                    r["HDId"] = entity.Id;
                    r["KHId"] = entity.KHId;
                    r["DateCreate"] = entity.DateCreate;
                    r["TotalPrice"] = entity.TotalPrice;
                dt.Rows.Add(r);
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);

            }
            catch
            {
               
            }
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
    }
}
