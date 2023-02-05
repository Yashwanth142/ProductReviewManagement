namespace ProductReviewManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview() {ProductId=1,UserId=1,Rating=5,Review="Good",isLike=true},
                new ProductReview() {ProductId=2,UserId=1,Rating=4,Review="Good",isLike=true},
                new ProductReview() {ProductId=3,UserId=2,Rating=5,Review="Good",isLike=true},
                new ProductReview() {ProductId=4,UserId=2,Rating=4,Review="Good",isLike=true},
                new ProductReview() {ProductId=5,UserId=3,Rating=2,Review="Good",isLike=true},
                new ProductReview() {ProductId=6,UserId=4,Rating=1,Review="bad",isLike=false},
                new ProductReview() {ProductId=11,UserId=3,Rating=4,Review="Good",isLike=true},
                new ProductReview() {ProductId=1,UserId=10,Rating=4,Review="Good",isLike=true},
                new ProductReview() {ProductId=12,UserId=10,Rating=4,Review="Good",isLike=true},
                new ProductReview() {ProductId=13,UserId=10,Rating=3,Review="nice",isLike=true}

            };

            //foreach(var list in productReviewList)
            //{
            //    Console.WriteLine("Product: " + list.ProductId + " UserId : " + list.UserId + " Rating : " + list.Rating + " Review :" + list.Review);
            //}

            Management management=new Management();
            //management.TopRecords(productReviewList);
            management.SelectRecord(productReviewList);
        }
    }
}