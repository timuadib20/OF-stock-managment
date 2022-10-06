using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OF_stock_managment
{
    class Supplier
    {
        int tinnumber;
        string supplierName;
        string date;
        SupplierDBLayer s;

        public Supplier() { }
        public Supplier(int tinnumber, string supplierName, string date)
        {
            this.tinnumber = tinnumber;
            this.supplierName = supplierName;
            this.date = date;
        }
        public int Tinnumber
        {
            set { tinnumber = value; }
            get { return tinnumber; }
        }


        public string SupplierName
        {
            set { supplierName = value; }
            get { return supplierName; }
        }

        public string Date
        {
            set { date = value; }
            get { return date; }
        }

        public string INsertSupplier()
        {
            s = new SupplierDBLayer();
            return s.InsertSupplierDB(this);
        }

        public string  UpdateSupplier()
        {
            s = new SupplierDBLayer();
           return  s.UpdateSupplierDB(this);

        }

        public string DeleteSupplier(int id)
        {
            s = new SupplierDBLayer();
             return s.DeleteSupplierDB(id);
        }

        public DataTable ViewSupplier()
        {
            s = new SupplierDBLayer();
            return s.ViewSupplierDB();
        }
        public DataTable SearchSupplierByTinnumber(int tinNumber)
        {
            s = new SupplierDBLayer();
            return s.SearchSupplierByTinnumberDB(tinNumber);
        }
        public DataTable SearchSupplierByName(string  supplierName)
        {
            s = new SupplierDBLayer();
            return s.SearchSupplierBynameDB(supplierName);
        }

    }
}
