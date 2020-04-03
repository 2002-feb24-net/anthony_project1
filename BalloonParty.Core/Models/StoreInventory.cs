// namespace BalloonParty.Core.Models
// {
//     public class StoreInventory
//     {
//         private int _StoreId { get; set; }
//         private int _ProductId { get; set; }
//         private string _ProductName { get; set; }
//         private int _ProductCount { get; set; }
//         private int _SinventoryId { get; set; }

//         public int StoreId
//         {
//             get => _StoreID;
//             set
//             {
//                 if (value < 0)
//                 {
//                     throw new System.Exception("Store ID Cannot Be 0", nameof(value));
//                 }
//                 _StoreID = value;
//             }
//         }

//         public int ProductID
//         {
//             get => _ProductID;
//             set
//             {
//                 if (value < 0)
//                 {
//                     throw new System.Exception("Product ID Cannot Be 0", nameof(value));
//                 }
//                 _ProductID = value;
//             }
//         }

//         public string ProductName
//         {
//             get => _ProductName;
//             set
//             {
//                 if (value.Length == 0)
//                 {
//                     throw new System.Exception("Product Name Cannot Be Empty", nameof(value));
//                 }
//                 _ProductName = value;
//             }
//         }

//         public int ProductCount
//         {
//             get => _ProductCount;
//             set
//             {
//                 if (value < 0)
//                 {
//                     throw new System.Exception("Product Count Cannot Be 0", nameof(value));
//                 }
//                 _ProductCount = value;
//             }
//         }

//         public int SinventoryId { get; set;}

//     }
// }