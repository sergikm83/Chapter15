using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesCarLibrary
{
    // Назначить описание с помощью "именованного свойства".
    [Serializable]
    [Obsolete("Use anotheer vehicle!")]
    [VehicleDescription("The old gray mare, she ain't what she used to be...")]
    public class HorseAndBuggy
    {

    }
}
