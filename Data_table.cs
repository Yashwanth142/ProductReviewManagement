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
            // D.DisplayProducts(table);
            // D.Display_IsLike_True(table);
           //  D.Display_Average_Rating(table);
            // D.Display_Review_Nice(table);
           D.Display_UserId_order(table);
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

        public void Display_IsLike_True(DataTable dt)
        {
            var prodName = from products in dt.AsEnumerable() where products.Field<String>("IsLike") == "true"
                           select products.Field<String>("ProductID");
            foreach (var prd in prodName)
            {
                Console.WriteLine(prd);
            }
        }

        public void Display_Average_Rating(DataTable dt)
        {
          
            var Records = dt.AsEnumerable().GroupBy(x => x.Field<string>("ProductID"))
                .Select(x => new
                {
                    ProductID = x.Key,
                    Rating = x.Average(x => x.Field<int>("Rating"))
                }).ToList();

          

            foreach (var prd in Records)
            {
                Console.WriteLine(prd);
            }
        }

        public void Display_Review_Nice(DataTable dt)
        {
            var prodName = from products in dt.AsEnumerable()
                           where products.Field<String>("Review") == "nice"
                           select products.Field<String>("ProductID");
            foreach (var prd in prodName)
            {
                Console.WriteLine(prd);
            }
        }

        public void Display_UserId_order(DataTable dt)
            //orderby p.Rating descending
        {
            var prodName = from products in dt.AsEnumerable()
                           where products.Field<String>("UserID") == "10"
                           orderby products.Field<String>("Rating") descending
                           select products.Field<String>("ProductID");
            foreach (var prd in prodName)
            {
                Console.WriteLine(prd);
            }
        }
    }
}
