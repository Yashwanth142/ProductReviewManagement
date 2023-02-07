using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management
{
    public class Management
    {
        public void top3Records(List<Product_review> lpr)
        {
            var recordData = (from p in lpr orderby p.Rating descending select p).Take(3);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + "UserID : " + list.UserID + "Rating : " + list.Rating + "Review : " + list.Review + "IsLike : " + list.IsLike);
            }
        
        }
         public void SelectRecords(List<Product_review> lpr)
        {
            var recordData= from p in lpr where(p.ProductID==1|| p.ProductID==4|| p.ProductID==9)&&p.Rating>3 select p;
            foreach (var list in recordData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + "UserID : " + list.UserID + "Rating : " + list.Rating + "Review : " + list.Review + "IsLike : " + list.IsLike);
            }
        }
          public void RetriveRecords(List<Product_review> lpr)
        {
            var recordData = (from p in lpr where p.ProductID != null select p.Review).Distinct().Count();
            Console.WriteLine("the count of types of review is: "+recordData);

        }
        
          public void SelectiveColumns(List<Product_review> lpr)
        {
            var recordData = from p in lpr  select (p.Review, p.ProductID);
            foreach (var list in recordData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " Review : " + list.Review );
            }

        }
    }
}
