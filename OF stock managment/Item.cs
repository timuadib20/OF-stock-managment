using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OF_stock_managment
{
    class Item
    {
        int id;
        string itemCode;
        string itemDescription;
        double quantity;
        string uOM;
        string brandName;
        double unitPrice;
        double totalPrice;
        string catagoryName;
        string subCatagory;

        public Item() { }

        public Item(int id,string itemCode, string itemDescription, double quantity, string UOM, string brandName, double unitPrice, string catagoryName, string subCatagory)
        {
            this.id = id;
            this.itemCode = itemCode;
            this.itemDescription = itemDescription;
            this.quantity = quantity;
            uOM = UOM;
            this.unitPrice = unitPrice;
            this.brandName = brandName;
            this.catagoryName = catagoryName;
            this.subCatagory = subCatagory;

        }

        public Item(string itemCode, string itemDescription, double quantity, string UOM, string brandName, double unitPrice, string catagoryName, string subCatagory)
        {
            this.itemCode = itemCode;
            this.itemDescription = itemDescription;
            this.quantity = quantity;
            uOM = UOM;
            this.unitPrice = unitPrice;
            //this.totalPrice = totalPrice;
            this.brandName = brandName;
            this.catagoryName = catagoryName;
            this.subCatagory = subCatagory;

        }

        //public Item this[int index]{
        //    set { this[index] = value; }
        //    get { return this[index]; }
        //}
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string ItemCode
        {
            set { itemCode = value; }
            get { return itemCode; }
        }

        public string ItemDescription
        {
            set { itemDescription = value; }
            get { return itemDescription; }
        }

        public string BrandName
        {
            set { brandName = value; }
            get { return brandName; }
        }

        public double Quantity
        {
            set { quantity = value; }
            get { return quantity; }
        }
        public string UOM
        {
            set { uOM = value; }
            get { return uOM; }
        }
        public double UnitPrice
        {
            set { unitPrice = value; }
            get { return unitPrice; }
        }

        public double TotalPrice
        {
            set { totalPrice = value; }
            get { return totalPrice; }
        }

        public string CatagoryName
        {
            get { return catagoryName; }
            set { catagoryName = value; }
        }

        public string SubCatagory
        {
            get { return subCatagory; }
            set { subCatagory = value; }
        }

        public DataTable searchCatagory(string catagory)
        {
            ItemDBLayer i = new ItemDBLayer();
            return i.SearchItemByCatagoryDB(catagory);
        }

        public DataTable searchItemDescribtion(string itemDescribtion)
        {
            ItemDBLayer i = new ItemDBLayer();
            return i.SearchItemByItemCodeOrItemDescDB(itemDescribtion);
        }

        

        public DataTable viewProduct()
        {
            ItemDBLayer i = new ItemDBLayer();
            return i.ViewItemDB();
        }


        public string insertProduct( )
        {
            ItemDBLayer i = new ItemDBLayer();
            return i.InsertItemDB(this);
        }

        public string insertManyProduct( )
        {
            
            ItemDBLayer i = new ItemDBLayer();
           return  i.InsertManyItemDB(this);
        }


        public string updateProduct()
        {
            ItemDBLayer i = new ItemDBLayer();
           return  i.UpdateItemDB(this);

        }

        public string deleteProduct(int id)
        {
            ItemDBLayer i = new ItemDBLayer();
          return  i.DeleteItemDB(id);
        }

        public DataTable loadCatagory()
        {
            ItemDBLayer i = new ItemDBLayer();
             return i.loadCatagory();
        }

        public DataTable loadSubCatagory()
        {
            ItemDBLayer i = new ItemDBLayer();
            return i.loadSubCatagory();
        }

        public DataTable loadBrand()
        {
            ItemDBLayer i = new ItemDBLayer();
            return i.loadBrand();
        }
        public DataTable loadUOM()
        {
            ItemDBLayer i = new ItemDBLayer();
            return i.loadUOM();
        }

    }
}
