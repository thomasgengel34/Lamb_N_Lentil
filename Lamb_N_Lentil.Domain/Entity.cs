using System.Collections.Generic;
using System.ComponentModel;

namespace Lamb_N_Lentil.Domain.UsdaInformation
{
    public class Entity : IIngredient, INotifyPropertyChanged
    {
        private decimal _TotalFat;
        public event PropertyChangedEventHandler PropertyChanged;

        public int ID { get; set; }
        public string InstanceName { get; set; }
        public string IngredientsInIngredient { get; set; } 
        public decimal Calcium { get; set; }
        public string Description { get; set; }
        public decimal FolicAcid { get; set; }
        public decimal Iron { get; set; }
        public decimal Sodium { get; set; }
        public decimal TotalCarbohydrate { get; set; }
        public decimal SaturatedFat { get; set; }
        public decimal TransFat { get; set; }
        public string UpdateDate { get; set; }
        public decimal ServingSize { get; set; }

        public decimal Calories { get; set; }
        public decimal Cholesterol { get; set; }
        public decimal Potassium { get; set; }
        public decimal DietaryFiber { get; set; }
        public decimal Sugars { get; set; }
        public decimal Protein { get; set; }
        public decimal VitaminA { get; set; }
        public decimal VitaminB6 { get; set; }
        public decimal VitaminB12 { get; set; }
        public decimal VitaminC { get; set; }
        public decimal VitaminD { get; set; }
        public decimal Thiamine { get; set; }
        public decimal Riboflavin { get; set; }
        public decimal Niacin { get; set; }
        public decimal Magnesium { get; set; }

        string  Label { get; set; }
        decimal IIngredient.Eqv { get; set; }
        string IIngredient.ManufacturerOrFoodGroup { get; set; }

        string IIngredient.Ndbno { get; set; }

        public decimal TotalFat
        {
            get { return _TotalFat; }
            set
            {
                _TotalFat = value;
                OnPropertyChanged("IIngredient.TotalFat");
            }
        }
        public decimal CaloriesFromFat
        {
            get { return CaloriesFromFat1; }
            set { CaloriesFromFat1 = value; }
        }

        public decimal MonounsaturatedFat { get; set; }
        public decimal PolyunsaturatedFat { get; set; }

        public Entity() =>  CaloriesFromFat1 = 9 * _TotalFat; 

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            CaloriesFromFat1 = 9 * _TotalFat;
        }

        public string TotalFatUnit { get; set; }
        public string SaturatedFatUnit { get; set; }
        public string TransFatUnit { get; set; }
        public string PolyunsaturatedFatUnit { get; set; }
        public string MonounsaturatedFatUnit { get; set; }
        public string CholesterolUnit { get; set; }
        public string SodiumUnit { get; set; }
        public string PotassiumUnit { get; set; }
        public string TotalCarbohydrateUnit { get; set; }
        public string DietaryFiberUnit { get; set; }
        public string SugarsUnit { get; set; }
        public string ProteinUnit { get; set; }
        public string VitaminAUnit { get; set; }
        public string VitaminCUnit { get; set; }
        public string CalciumUnit { get; set; }
        public string IronUnit { get; set; }
        public string ThiamineUnit { get; set; }
        public string RiboflavinUnit { get; set; }
        public string NiacinUnit { get; set; }
        public string FolicAcidUnit { get; set; }
        public string VitaminDUnit { get; set; }
        public string VitaminB12Unit { get; set; }
        public string VitaminB6Unit { get; set; }
        public decimal CaloriesFromFat1 { get => CaloriesFromFat2; set => CaloriesFromFat2 = value; }
        public decimal CaloriesFromFat2 { get; set; }
        string IIngredient.Name { get; set; }
        string IIngredient.IngredientDescription { get; set; }
        List<Nutrient> IIngredient.Nutrients { get; set; }
        List<string> IIngredient.Footnotes { get; set; }
        int IEntity.ID { get; set; }
        string IEntity.InstanceName { get; set; }
        string IEntity.IngredientsInIngredient { get; set; }
        string IEntity.Description { get; set; }
        string IEntity.UpdateDate { get; set; }
    }
}
