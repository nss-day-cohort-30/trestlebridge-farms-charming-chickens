using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
        //added list for each type of field need to create class
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();

        // public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
        // public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();
        // public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        // public List<DuckHouse> DuckHouse { get; } = new List<DuckHouse>();


        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));

            return report.ToString();
        }
    }
}