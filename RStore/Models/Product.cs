using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public double Price  { get; set; }
        public int UserId  { get; set; }
        public int CategoryId  { get; set; }
        public  string Status { get; set; }
        public int Count { get; set; }
    }
}
