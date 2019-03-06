using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entities
{
    public class ThietBiDTO
    {
        private int id, typeid, qty;
        private string name;
       
        private double price;

        public string Name { get => name; set => name = value; }
        public int Typeid { get => typeid; set => typeid = value; }
        public int Qty { get => qty; set => qty = value; }
        public double Price { get => price; set => price = value; }
        public int Id { get => id; set => id = value; }
    }
}
