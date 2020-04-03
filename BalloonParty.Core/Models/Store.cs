// using System;
// using System.Collections.Generic;
// using System.Text;

// namespace BalloonParty.Core.Models
// {
//     public class Store
//     {
//         private string _StoreName { get; set; }
//         private string _StoreUsername { get; set; }
//         private string _StorePw { get; set; }
//         private string _Address { get; set; }
//         private string _City { get; set; }
//         private string _State { get; set; }
//         private int _ZipCode { get; set; }
//         private int _StoreId { get; set; }

//         public string StoreName
//         {
//             get => _StoreName;
//             set
//             {
//                 if (value.Length == 0)
//                 {
//                     throw new System.Exception("Store Name Cannot Be Empty", nameof(value));
//                 }
//                 _StoreName = value;
//             }
//         }

//         public string StoreUsername
//         {
//             get => _StoreUsername;
//             set
//             {
//                 if (value.Length == 0)
//                 {
//                     throw new System.Exception("Store Username Cannot Be Empty", nameof(value));
//                 }
//                 _StoreUsername = value;
//             }
//         }

//         public string Address
//         {
//             get => _Address;
//             set
//             {
//                 if (value.Length == 0)
//                 {
//                     throw new System.Exception("Store Address Cannot Be Empty", nameof(value));
//                 }
//                 _Address = value;
//             }
//         }

//         public string City
//         {
//             get => _City;
//             set
//             {
//                 if (value.Length == 0)
//                 {
//                     throw new System.Exception("City Cannot Be Empty", nameof(value));
//                 }
//                 _City = value;
//             }
//         }

//         public string Stete
//         {
//             get => _State;
//             set
//             {
//                 if (value.Length == 0)
//                 {
//                     throw new System.Exception("State Cannot Be Empty", nameof(value));
//                 }
//                 _State = value;
//             }
//         }

//         public int ZipCode
//         {
//             get => _ZipCode;
//             set
//             {
//                 if (value < 0)
//                 {
//                     throw new System.Exception("Zip Code Cannot Be Empty", nameof(value));
//                 }
//                 _ZipCode = value;
//             }
//         }

//         public int StoreId { get; set; }
//     }
// }