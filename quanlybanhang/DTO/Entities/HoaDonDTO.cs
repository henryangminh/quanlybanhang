using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entities
{
    public class HoaDonDTO
    {
        public int Id { get; set; }
        public int KHId { get; set; }
        public DateTime DateCreate { get; set; }
        public double SaleOff { get; set; }
        public double TotalPrice { get; set; }

        public HoaDonDTO(int id, int khid, DateTime datecreate,double sale, double total)
        {
            Id = id;
            KHId = khid;
            DateCreate = datecreate;
            SaleOff = sale;
            TotalPrice = total;
        }
        public HoaDonDTO() { }
    }
}
