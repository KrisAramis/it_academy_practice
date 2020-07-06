using System;
using System.Collections.Generic;
using System.Text;

namespace lecture11
{
    public class UniqueItem
    {
        public int ID=1;
        public  UniqueItem()
        {
            this.ID = ID++;
            
        }

        public int getID()
        {
            return ID;
        }

    }
}
