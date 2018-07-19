namespace Lamb_N_Lentil.Domain.UsdaInformation
{
    public class UsdaFoodReport : UsdaAsync, IUsdaAsync
    {
        public foods[] foods { get; set; }
    }

    public class foods
    {
        public food food { get; set; } 
    }

    public class food
    {
        public ing ing { get; set; }
        public desc desc { get; set; }
        public nutrients[] nutrients { get; set; }
    }

    public class ing
    {
        public string desc { get; set; }
        public string upd { get; set; }
    }

    public class desc
    {
        public string ds { get; set; } 
        public string fg { get; set; }
        public string name { get; set; }
        public string ndbno { get; set; }
       
        public string manu { get; set; }
    }

    public class nutrients
    {
        public int nutrient_id { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public string value { get; set; }
        public decimal qty { get; set; }
        public measures[] measures { get; set; }
    }

    public class measures
    {
        public string label { get; set; }
        public decimal eqv { get; set; }
        public string eunit { get; set; }
        public decimal qty { get; set; }
        public decimal value { get; set; } 
    } 
}
