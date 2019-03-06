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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(LoaiThietBiDTO entity)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from LoaiThietBi", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
