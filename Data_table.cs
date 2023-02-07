using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management
{
    public class Data_table
    {
        public  void insertdata()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserID");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("IsLike");

            table.Rows.Add("1","9","5","Excellent","true");
            table.Rows.Add("2", "9", "5", "Excellent", "true");
            table.Rows.Add("3", "9", "5", "Excellent", "true");
            table.Rows.Add("4", "9", "5", "Excellent", "true");
            table.Rows.Add("5", "9", "5", "Excellent", "true");
            table.Rows.Add("6", "9", "5", "Excellent", "true");
            table.Rows.Add("7", "9", "5", "Excellent", "true");
            table.Rows.Add("8", "9", "5", "Excellent", "true");
            table.Rows.Add("9", "9", "5", "Excellent", "true");
            table.Rows.Add("10", "9", "5", "Excellent", "true");
            table.Rows.Add("11", "9", "5", "Excellent", "true");
            table.Rows.Add("12", "9", "5", "Excellent", "true");
            table.Rows.Add("13", "9", "5", "Excellent", "true");
            table.Rows.Add("14", "9", "5", "Excellent", "true");
            table.Rows.Add("15", "9", "5", "Excellent", "true");
            table.Rows.Add("16", "9", "5", "Excellent", "true");
            table.Rows.Add("17", "9", "5", "Excellent", "true");
            table.Rows.Add("18", "9", "5", "Excellent", "true");
            table.Rows.Add("19", "9", "5", "Excellent", "true");
            table.Rows.Add("20", "9", "5", "Excellent", "true");
            table.Rows.Add("21", "9", "5", "Excellent", "true");
            table.Rows.Add("22", "9", "5", "Excellent", "true");
            table.Rows.Add("23", "9", "5", "Excellent", "true");
            table.Rows.Add("24", "9", "5", "Excellent", "true");
            table.Rows.Add("25", "9", "5", "Excellent", "true");

            Data_table D = new Data_table();
            D.DisplayProducts(table);

        }

        public void DisplayProducts(DataTable dt)
        {
            var prodName = from products in dt.AsEnumerable()
                           select products.Field<String>("ProductID");
            foreach (var prd in prodName)
            {
                Console.WriteLine(prd);
            }
        }
    }
}
