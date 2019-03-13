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
    public class LoaiThietBiDAO : Connection, IDal<LoaiThietBiDTO>
    {
        public void Add(LoaiThietBiDTO entity)
        {
            using (SqlCommand command = conn.CreateCommand())
            {
                command.CommandText = "INSERT INTO LoaiThietBi VALUES (@ltbName)";
                command.Parameters.AddWithValue("@ltbName", entity.TypeName);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(LoaiThietBiDTO entity)
        {
            using (SqlCommand command = conn.CreateCommand())
            {
                command.CommandText = "UPDATE LoaiThietBi SET LTBName = @ltbName WHERE LTBId = @ltbId";
                command.Parameters.AddWithValue("@ltbName", entity.TypeName);
                command.Parameters.AddWithValue("@ltbId", entity.Id);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public DataTable GetAll()
        {

            try
            {
                SqlDataAdapter da_ltb = new SqlDataAdapter("Select * from LoaiThietBi", conn);
                DataTable dt_ltb = new DataTable();
                da_ltb.Fill(dt_ltb);
                return dt_ltb;
            }
            catch
            {
                return null;
            }
        }

        public LoaiThietBiDTO GetById(int id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from LoaiThietBi where LTBId = '" + id + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    return new LoaiThietBiDTO()
                    {
                        Id = Convert.ToInt32(dr["LTBId"]),
                        TypeName = Convert.ToString(dr["LTBName"])
                    };
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
