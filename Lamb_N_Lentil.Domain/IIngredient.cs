using System.Collections.Generic;

namespace Lamb_N_Lentil.Domain.UsdaInformation
{
    public interface IIngredient : IEntity
    {
        string Ndbno { get; set; }
        //string Label { get; set; }
        decimal Eqv { get; set; }
        string ManufacturerOrFoodGroup { get; set; }
        string Name { get; set; }
        string IngredientDescription { get; set; }
        List<Nutrient> Nutrients { get; set;}
        List<string> Footnotes { get; set; }
    } 
}
