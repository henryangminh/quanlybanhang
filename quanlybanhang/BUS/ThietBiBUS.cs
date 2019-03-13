using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO.Entities;

namespace BUS
{
    public class ThietBiBUS
    {
        ThietBiDAO a = new ThietBiDAO();
        public DataTable GetAll()
        {
            return a.GetAll();
        }
        public DataTable GetByType(int typeId)
        {
            return a.GetByType(typeId);
        }
        
        public void UpdateQty(int id, int qty)
        {
            a.UpdateQty(id, qty);
        }
        public void Edit(ThietBiDTO thietBiDTO)
        {
            a.Edit(thietBiDTO);
        }

        public void Add(ThietBiDTO thietBiDTO)
        {
            a.Add(thietBiDTO);
        }
    }
}
