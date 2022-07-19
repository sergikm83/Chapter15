using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyingAttributes
{
    [Serializable]
    public class Motorcycle
    {
        // Однако это поле сохраняться не будет.
        [NonSerialized]
        float weightOfCurrentPessengers;
        // Эти поля останутся сериализуемыми.
        bool hasRadioSystem;
        bool hasHeadSet;
        bool hasSissyBar;
    }
}
