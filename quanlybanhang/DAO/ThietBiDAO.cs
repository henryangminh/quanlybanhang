using DAO.Interfaces;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace DAO
{
    public class ThietBiDAO : Connection, IDal<ThietBiDTO>
    {
        public void Add(ThietBiDTO entity)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from ThietBi", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow r = dt.NewRow();
            r[0] = entity.TBId;
            r[1] = entity.TBName;
            r[2] = entity.LTBId;
            r[3] = entity.Price;
            r[4] = entity.Qty;
            dt.Rows.Add(r);
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Update(dt);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ThietBiDTO entity)
        {
            using (SqlCommand command = conn.CreateCommand())
            {
                command.CommandText = "UPDATE ThietBi SET TBName = @tbName, LTBId = @ltbId, Price = @price, Qty = @qty WHERE TBId = @tbId";
                command.Parameters.AddWithValue("@tbName", entity.TBName);
                command.Parameters.AddWithValue("@ltbId", entity.LTBId);
                command.Parameters.AddWithValue("@price", entity.Price);
                command.Parameters.AddWithValue("@qty", entity.Qty);
                command.Parameters.AddWithValue("@tbId", entity.TBId);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public DataTable GetAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from ThietBi", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable GetByType(int typeId)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from ThietBi where LTBId="+typeId, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable GetById(int id)
        {
            throw new NotImplementedException();

        }

        ThietBiDTO IDal<ThietBiDTO>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
