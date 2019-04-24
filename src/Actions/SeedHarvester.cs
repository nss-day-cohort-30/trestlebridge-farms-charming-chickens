// using System;
// using System.Linq;
// using Trestlebridge.Interfaces;
// using Trestlebridge.Models;
// using Trestlebridge.Models.Facilities;
// using Trestlebridge.Models.Animals;

// namespace Trestlebridge.Actions {
//     public class SeedHarvester {
//         public static void CollectInput (Farm farm, IResource plant) {
//             Console.Clear();

//             for (int i = 0; i < farm.GrazingFields.Count; i++)
//             {
//                 GrazingField specificField = farm.GrazingFields[i];
//                 Console.WriteLine ($"{i + 1}. {specificField}");
//             }

//             Console.WriteLine ();



//             // How can I output the type of animal chosen here?
//             Console.WriteLine ($"Place the animal where?");

//             Console.Write ("> ");

//             try
//                 {
//                     int choice = Int32.Parse(Console.ReadLine ()) - 1;
//                     farm.[choice].AddResource(plant);
//                 }
//             catch (ArgumentOutOfRangeException ex)
//                 {
//                     Console.WriteLine(ex);
//                 }


//             /*
//                 Couldn't get this to work. Can you?
//                 Stretch goal. Only if the app is fully functional.
//              */
//             // farm.PurchaseResource<IGrazing>(animal, choice);

//         }
//     }
// }