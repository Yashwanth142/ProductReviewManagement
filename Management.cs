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
    }
}
