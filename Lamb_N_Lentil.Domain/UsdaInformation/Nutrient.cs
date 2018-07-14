using System.Collections.Generic;

namespace Lamb_N_Lentil.Domain.UsdaInformation
{
    public class Nutrient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Value { get; set; }
        public List<Measure> Measures { get; set; }
    }
}
