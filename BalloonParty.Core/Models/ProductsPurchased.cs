// using System;
// using System.Collections.Generic;
// using System.Text;

// namespace BalloonParty.Core.Models
// {
//     public class ProductsPurchased
//     {
//         private int _PurchasedProductId { get; set; }
//         private int _ProductId { get; set; }
//         private int _ProductCount { get; set; }
//         private int _StoreId { get; set; }
//         private string _CustomerEmail { get; set; }
//         private DateTime _PurchaseDate { get; set; }


//         public int PurchasedProductId { get; set;}

//         public int ProductId
//         {
//             get => _ProductID;
//             set
//             {
//                 if (value.Length < 0)
//                 {
//                     throw new ArgumentException("Product ID cannot be less than 0", nameof(value));
//                 }
//                 _ProductID = value;
//             }
//         }

//         public int ProductCount
//         {
//             get => _ProductCount;
//             set
//             {
//                 if (value.Length < 0)
//                 {
//                     throw new System.Exception("Product Count cannot be less than 0", nameof(value));
//                 }
//                 _ProdcutCount = value;
//             }
//         }

//         public int StoreId
//         {
//             get => _StoreID;
//             set
//             {
//                 if (value < 0)
//                 {
//                     throw new System.Exception("Store ID Cannot Be Less Than 0", nameof(value));
//                 }
//                 _StoreID = value;
//             }
//         }

//         public string CustomerEmail
//         {
//             get => _CustomerEmail;
//             set
//             {
//                 if (value.Length == 0)
//                 {
//                     throw new System.Exception("Customer Email Cannot Be Empty", nameof(value));
//                 }
//                 _StoreId = value;
//             }
//         }

//         public string  PurchaseDate
//         {
//             get => _PurchaseDate;
//             set
//             {
//                 if (value.Length == 0)
//                 {
//                     throw new ArgumentException("Purchase Date Must Not Be Empty.", nameof(value));
//                 }
//                 _PurchaseDate = value;
//             }
//         }
//     }
// }