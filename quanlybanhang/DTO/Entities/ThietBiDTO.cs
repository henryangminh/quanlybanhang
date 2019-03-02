using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entities
{
    class ThietBiDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public ThietBiDTO(int id, string name, int typeid, double price, int qty)
        {
            Id = id;
            Name = name;
            TypeId = typeid;
            Price = price;
            Qty = qty;
        }
        public ThietBiDTO() { }
    }
}
