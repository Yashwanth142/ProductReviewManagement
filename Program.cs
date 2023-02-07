using System.ComponentModel;
using System.Data;

namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(String[] args)
        {
            List<Product_review> pr=new List<Product_review>
            
            {
                new Product_review(){ ProductID = 1, UserID = 9, Rating = 5, Review = "Excellent", IsLike = true },
                new Product_review(){ ProductID = 2, UserID = 10, Rating = 4, Review = "Good", IsLike = false },
                new Product_review(){ ProductID = 3, UserID = 8, Rating = 4, Review = "Good", IsLike = true },
                new Product_review(){ ProductID = 4, UserID = 7, Rating = 1, Review = "Very Bad", IsLike = true },
                new Product_review(){ ProductID = 5, UserID = 2, Rating = 1, Review = "Very Bad", IsLike = true },
                new Product_review(){ ProductID = 6, UserID = 6, Rating = 5, Review = "Excellent", IsLike = false },
                new Product_review(){ ProductID = 7, UserID = 3, Rating = 4, Review = "Good", IsLike = false },
                new Product_review(){ ProductID = 8, UserID = 9, Rating = 5, Review = "Excellent", IsLike = true },
                new Product_review(){ ProductID = 9, UserID = 6, Rating = 1, Review = "Very Bad", IsLike = false },
                new Product_review(){ ProductID = 10, UserID = 4, Rating = 3, Review = "Average", IsLike = false },
                new Product_review(){ ProductID = 11, UserID = 4, Rating = 2, Review = "Bad", IsLike = false },
                new Product_review(){ ProductID = 12, UserID = 10, Rating = 2, Review = "Bad", IsLike = false },
                new Product_review(){ ProductID = 13, UserID = 1, Rating = 5, Review = "Excellent", IsLike = true },
                new Product_review(){ ProductID = 11, UserID = 8, Rating = 2, Review = "Bad", IsLike = true },
                new Product_review(){ ProductID = 15, UserID = 5, Rating = 3, Review = "Average", IsLike = false },
                new Product_review(){ ProductID = 16, UserID = 1, Rating = 3, Review = "Average", IsLike = true },
                new Product_review(){ ProductID = 17, UserID = 7, Rating = 1, Review = "Very Bad", IsLike = false },
                new Product_review(){ ProductID = 18, UserID = 10, Rating = 3, Review = "Average", IsLike = true },
                new Product_review(){ ProductID = 19, UserID = 3, Rating = 4, Review = "Good", IsLike = true },
                new Product_review(){ ProductID = 20, UserID = 2, Rating = 5, Review = "Excellent", IsLike = false },
                new Product_review(){ ProductID = 21, UserID = 6, Rating = 3, Review = "Average", IsLike = true },
                new Product_review(){ ProductID = 22, UserID = 2, Rating = 1, Review = "Very Bad", IsLike = false },
                new Product_review(){ ProductID = 23, UserID = 2, Rating = 4, Review = "Good", IsLike = true },
                new Product_review(){ ProductID = 24, UserID = 1, Rating = 2, Review = "Bad", IsLike = false },
                new Product_review(){ ProductID = 25, UserID = 3, Rating = 5, Review = "Excellent", IsLike = true }
            };

            /*foreach(var list in pr)
            {
                Console.WriteLine("Product ID : "+ list.ProductID + "UserID : "+ list.UserID+ "Rating : "+list.Rating + "Review : "+ list.Review+ "IsLike : "+ list.IsLike);
            }*/
            Management mn = new Management();
            mn.top3Records(pr);

        }
       
    }
}
