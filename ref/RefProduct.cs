using System;
using System.Collections.Generic;
using System.Text;

namespace refP
{
    public class RefProduct
    {
        public string ItemName { get; set; }
        public int ItemID { get; set; }

        public  RefProduct(string name, int newID)
        {
            ItemName = name;
            ItemID = newID;
        }
    }
}
