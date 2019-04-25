using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;
using Trestlebridge.Models.HashSets;


namespace Trestlebridge.Models.Facilities
{
    public class ChooseComposter
    {
        // need to group classes in facilities by the interface type ICompost

        /*  Steve said to be verbose and loop over facilities that have animals
            or flowers that can be composted. At that point, console.writeline()
            or store those items in a new list. Once in that list, you can output them or loop over them or really just kind of whatever.
        */
        public List<ICompost> CompostFacilities = new List<ICompost>();


    public static void CollectInput(ICompost resource)
    {
        Console.Clear();









        /*
            Couldn't get this to work. Can you?
            Stretch goal. Only if the app is fully functional.
         */
        // farm.PurchaseResource<IGrazing>(animal, choice);

    }
}
}