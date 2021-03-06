using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;
using System.Linq;

namespace Trestlebridge.Models
{
    public class Composter : ICompost
    {
        // need to group classes in facilities by the interface type ICompost

        /*  Steve said to be verbose and loop over facilities that have animals
            or flowers that can be composted. At that point, console.writeline()
            or store those items in a new list. Once in that list, you can output them or loop over them or really just kind of whatever.

            farm.GrazingFields
        */
        public List<ICompost> CompostFacilities = new List<ICompost>();

        public double Compost() {
            return 44.44;
        }

        public static void CollectInput(Farm farm)
        {

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                Console.Clear();
                foreach (GrazingField gf in farm.GrazingFields)
                {
                    if (gf.Animals.GetType().Name.ToString() == "ICompost")
                    {
                        Console.WriteLine($"{i + 1}. {farm.GrazingFields[i]}");
                    }
                }
            }
        }
    }
}