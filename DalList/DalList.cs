using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalList;

namespace Dal;

    internal sealed class DalList:IDal
    {
    private DalList() {
    }
        private static DalList s_instance;
        public static IDal Instance => s_instance ??= new DalList();


        public ISale Sale => new SaleImplementation();
        public IProduct Product => new ProductImplementation();
        public ICustomer Customer => new CustomerImplementation();

    }

