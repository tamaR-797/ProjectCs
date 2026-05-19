using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{       public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Categories  category { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public override string ToString() => this.ToStringProperty();

    }

}

