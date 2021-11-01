using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementWithLinq
{
    public class Management
    {
        public DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReviewManagement> listProductReview)
        {
            var recordsData = (from productreviews in listProductReview
                               orderby productreviews.Rating descending
                               select productreviews).Take(3);
            foreach(var list in recordsData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + " " + list.Review + " " + "isLike:-" + list.isLike);
            }
        }
        public void SelectedRecords(List<ProductReviewManagement> listProductReview)
        {
            var recordData = from productReviews in listProductReview
                             where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9) && productReviews.Rating > 3
                             select productReviews;
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + " " + list.Review + " " + "isLike:-" + list.isLike);
            }
        }
    }
}
