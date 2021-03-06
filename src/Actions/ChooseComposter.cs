using System;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Actions
{
    public class ChooseComposter
    {
        public static void CollectInput(Farm farm, ICompost compost)
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