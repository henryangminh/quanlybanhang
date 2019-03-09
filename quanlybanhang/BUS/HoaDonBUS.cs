using DAO;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO a = new HoaDonDAO();
        public void Add(HoaDonDTO entity)
        {
            a.Add(entity);
        }
    }
}
