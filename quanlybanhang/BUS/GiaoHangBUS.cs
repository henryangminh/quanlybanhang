using DAO;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiaoHangBUS
    {
        GiaoHangDAO gh = new GiaoHangDAO();
        public void Add(GiaoHangDTO entity)
        {

            gh.Add(entity);
        }

        public DataTable GetAll()
        {
            return gh.GetAll();
        }

    }
}
