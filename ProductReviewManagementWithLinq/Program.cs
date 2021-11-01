using System;
using System.Collections.Generic;

namespace ProductReviewManagementWithLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management problem statement");
            List<ProductReviewManagement> ProductReviewlist = new List<ProductReviewManagement>()
            {
                new ProductReviewManagement() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 2, UserID = 1, Rating = 4, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 3, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 4, UserID = 2, Rating = 3, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 5, UserID = 2, Rating = 2, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 6, UserID = 10, Rating = 4, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 7, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 8, UserID = 10, Rating = 5, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 9, UserID = 10, Rating = 3, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 10, UserID = 10, Rating = 2, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 11, UserID = 9, Rating = 3, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 12, UserID = 10, Rating = 4, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 13, UserID = 10, Rating = 5, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 14, UserID = 7, Rating = 1, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 15, UserID = 1, Rating = 3, Review = "Good", isLike = true },
                new ProductReviewManagement() { ProductID = 16, UserID = 5, Rating = 2, Review = "Good", isLike = true }
            };
            //foreach(var list in ProductReviewlist)
            //{
            //    Console.WriteLine("ProductID:-"+list.ProductID+" "+"UserID:-"+list.UserID+" "+"Rating:-"+list.Rating+" "+"Review:-"+" "+list.Review+" "+"isLike:-"+list.isLike);
            //}
            Management management = new Management();
            management.TopRecords(ProductReviewlist);
        }
    }
}
