using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace OF_stock_managment
{
    class Recycle
    {

        public DataTable viewRecycle(string tablename , string operation)
        {
            RecycleDBLayer r = new RecycleDBLayer();
            return r.ViewRecycleBinDB(tablename, operation);
        }

        public void ResetSupplier(int tinnumber)
        {
            RecycleDBLayer r = new RecycleDBLayer();
            r.ResetSupplierDB(tinnumber);
        }
    }
}
