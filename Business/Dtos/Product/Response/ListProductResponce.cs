using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Product.Response
{
    public class ListProductResponce
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
    }
}