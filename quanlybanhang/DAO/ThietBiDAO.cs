﻿using DAO.Interfaces;
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ThietBiDTO entity)
        {
            throw new NotImplementedException();
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
