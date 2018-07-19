using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Lamb_N_Lentil.Domain.UsdaInformation;

namespace Lamb_N_Lentil.UI.Models
{
    public class UsdaFoodReportViewModel
    {
        public string Ndbno { get; set; }

        [Display(Name = "Ingredient")]
        public string Description { get; set; }

        [Display(Name = "INGREDIENTS")]
        public string Ingredients { get; set; }

        [Display(Name = "Serving Size")]
        public string ServingSize { get; set; }

        public List<Nutrient> Nutrients { get; set; }
        public decimal Calories { get; set; }

        [Display(Name = "Total Fat")]
        public decimal TotalFat { get; set; }
        public string TotalFatUnit { get; set; }
        public int TotalFatPercentageDailyValue { get; set; }

        [Display(Name = "Saturated Fat")]
        public decimal SaturatedFat { get; set; }
        public string SaturatedFatUnit { get; set; }
        public int SaturatedFatPercentageDailyValue { get; set; }

        [Display(Name = "Trans Fat")]
        public decimal TransFat { get; set; }
        public string TransFatUnit { get; set; }

        [Display(Name = "Polyunsaturated Fat")]
        public decimal PolyunsaturatedFat { get; set; }
        public string PolyunsaturatedFatUnit { get; set; }

        [Display(Name = "Monounsaturated Fat")]
        public decimal MonounsaturatedFat { get; set; }
        public string MonounsaturatedFatUnit { get; set; }

        public decimal Cholesterol { get; set; }
        public string CholesterolUnit { get; set; }
        public int CholesterolPercentageDailyValue { get; set; }

        public decimal Sodium { get; set; }
        public string SodiumUnit { get; set; }
        public int SodiumPercentageDailyValue { get; set; }

        public decimal Potassium { get; set; }
        public string PotassiumUnit { get; set; }
        public int PotassiumPercentageDailyValue { get; set; }

        [Display(Name = "Total Carbohydrate")]
        public decimal TotalCarbohydrate { get; set; }
        public string TotalCarbohydrateUnit { get; set; }
        public int TotalCarbohydratePercentageDailyValue { get; set; }

        [Display(Name = "Dietary Fiber")]
        public decimal DietaryFiber  { get; set; }
        public string DietaryFiberUnit { get; set; }
        public int DietaryFiberPercentageDailyValue { get; set; }

        public decimal Sugars { get; set; }
        public string SugarsUnit { get; set; }

        public decimal Protein { get; set; }
        public string ProteinUnit { get; set; }

        [Display(Name = "Vitamin A")]
        public decimal VitaminA { get; set; }
        public string VitaminAUnit { get; set; }
        public int VitaminAPercentageDailyValue { get; set; }

        [Display(Name = "Vitamin C")]
        public decimal VitaminC { get; set; }
        public string VitaminCUnit { get; set; }
        public int VitaminCPercentageDailyValue { get; set; }

        public decimal Calcium { get; set; }
        public string CalciumUnit { get; set; }
        public int CalciumPercentageDailyValue { get; set; }

        public decimal Iron { get; set; }
        public string IronUnit { get; set; }
        public int IronPercentageDailyValue { get; set; }

        public decimal Thiamine { get; set; }
        public string ThiamineUnit { get; set; }
        public int ThiaminePercentageDailyValue { get; set; }

        public decimal Riboflavin { get; set; }
        public string RiboflavinUnit { get; set; }
        public int RiboflavinPercentageDailyValue { get; set; }

        public decimal Niacin { get; set; }
        public string NiacinUnit { get; set; }
        public int NiacinPercentageDailyValue { get; set; }

        [Display(Name = "Folic Acid")]
        public decimal FolicAcid { get; set; }
        public string FolicAcidUnit { get; set; }
        public int FolicAcidPercentageDailyValue { get; set; }

        [Display(Name = "Vitamin D")]
        public decimal VitaminD { get; set; }
        public string VitaminDUnit { get; set; }
        public int VitaminDPercentageDailyValue { get; set; }

        [Display(Name = "Vitamin B12")]
        public decimal VitaminB12 { get; set; }
        public string VitaminB12Unit { get; set; }
        public int VitaminB12PercentageDailyValue { get; set; }

        [Display(Name = "Vitamin B6")]
        public decimal VitaminB6 { get; set; }
        public string VitaminB6Unit { get; set; }
        public int VitaminB6PercentageDailyValue { get; set; }

        public decimal Magnesium { get; set; }
        public string MagnesiumUnit { get; set; }
        public int MagnesiumPercentageDailyValue { get; set; }

        public static UsdaFoodReportViewModel MapUsdaFoodReportToItsViewModel(UsdaFoodReport report)
        {
            var vm = new UsdaFoodReportViewModel();
            if (report.foods != null && report.foods.First().food != null)
            {
                var food = report.foods.First().food;
                if (food.desc != null)
                {
                    if (food.desc.name != null)
                    {
                        vm.Description = food.desc.name;
                    }
                    if (food.desc.ndbno != null)
                    {
                        vm.Ndbno = food.desc.ndbno;
                    }
                }

                vm.Ingredients = food.ing.desc;
                if (food.nutrients != null)
                {
                    vm.ServingSize = food.nutrients.FirstOrDefault().measures.FirstOrDefault().label;
                    vm.Nutrients = GetNutrients(food);
                    vm.Calories = GetNutrientValue(vm, food, 208);

                    vm.TotalFat = GetNutrientValue(vm, food, 204);
                    vm.TotalFatUnit = GetNutrientUnit(vm, food, 204);
                    vm.TotalFatPercentageDailyValue = Decimal.ToInt16(100 * vm.TotalFat / 65);

                    vm.SaturatedFat = GetNutrientValue(vm, food, 606);
                    vm.SaturatedFatUnit = GetNutrientUnit(vm, food, 606);
                    vm.SaturatedFatPercentageDailyValue = Decimal.ToInt16(100 * vm.SaturatedFat / 20);

                    vm.TransFat = GetNutrientValue(vm, food, 605);
                    vm.TransFatUnit = GetNutrientUnit(vm, food, 605);

                    vm.PolyunsaturatedFat= GetNutrientValue(vm, food, 646 );
                    vm.PolyunsaturatedFatUnit= GetNutrientUnit(vm, food, 646 );

                    vm.MonounsaturatedFat = GetNutrientValue(vm, food, 645);  
                    vm.MonounsaturatedFatUnit = GetNutrientUnit(vm, food, 645);

                    vm.Cholesterol = GetNutrientValue(vm, food, 601);
                    vm.CholesterolUnit = GetNutrientUnit(vm, food, 601);
                    vm.CholesterolPercentageDailyValue = Decimal.ToInt16(100 * vm.Cholesterol / 300);

                    vm.Sodium = GetNutrientValue(vm, food, 307);
                    vm.SodiumUnit = GetNutrientUnit(vm, food, 307);
                    vm.SodiumPercentageDailyValue = Decimal.ToInt16(100 * GetNutrientValue(vm, food, 307) / 2400);

                    vm.Potassium = GetNutrientValue(vm, food, 306);
                    vm.PotassiumUnit = GetNutrientUnit(vm, food, 306);
                    vm.PotassiumPercentageDailyValue = Decimal.ToInt16(100 * GetNutrientValue(vm, food, 306) / 3500);

                    vm.TotalCarbohydrate = GetNutrientValue(vm, food, 205);
                    vm.TotalCarbohydrateUnit = GetNutrientUnit(vm, food, 205);
                    vm.TotalCarbohydratePercentageDailyValue = Decimal.ToInt16(100 * vm.TotalCarbohydrate / 300);

                    vm.DietaryFiber = GetNutrientValue(vm, food, 291);
                    vm.DietaryFiberUnit = GetNutrientUnit(vm, food, 291);
                    vm.DietaryFiberPercentageDailyValue = Decimal.ToInt16(100 * vm.DietaryFiber / 25);

                    vm.Sugars = GetNutrientValue(vm, food, 269);
                    vm.SugarsUnit = GetNutrientUnit(vm, food, 269);

                    vm.Protein = GetNutrientValue(vm, food, 203);
                    vm.ProteinUnit = GetNutrientUnit(vm, food, 203);

                    vm.VitaminA = GetNutrientValue(vm, food, 318);
                    vm.VitaminAUnit = GetNutrientUnit(vm, food, 318);
                    vm.VitaminAPercentageDailyValue = Decimal.ToInt16(1 * vm.VitaminA / 50);

                    vm.VitaminC = GetNutrientValue(vm, food, 401);
                    vm.VitaminCUnit = GetNutrientUnit(vm, food, 401);
                    vm.VitaminCPercentageDailyValue = Decimal.ToInt16(100 * vm.VitaminC / 50);

                    vm.Calcium = GetNutrientValue(vm, food, 301);
                    vm.CalciumUnit = GetNutrientUnit(vm, food, 301);
                    vm.CalciumPercentageDailyValue = Decimal.ToInt16(100 * vm.Calcium / 1000);

                    vm.Iron = GetNutrientValue(vm, food, 303);
                    vm.IronUnit = GetNutrientUnit(vm, food, 303);
                    vm.IronPercentageDailyValue = Decimal.ToInt16(100 * vm.Iron / 18);
                    
                    vm.Thiamine = GetNutrientValue(vm, food, 404);
                    vm.ThiamineUnit = GetNutrientUnit(vm, food, 404);
                    vm.ThiaminePercentageDailyValue = Decimal.ToInt16(100 * vm.Thiamine / 1.5M);

                    vm.Riboflavin = GetNutrientValue(vm, food, 405);
                    vm.RiboflavinUnit = GetNutrientUnit(vm, food, 405);
                    vm.RiboflavinPercentageDailyValue = Decimal.ToInt16(100 * vm.Riboflavin / 1.7M);

                    vm.Niacin = GetNutrientValue(vm, food, 406);
                    vm.NiacinUnit = GetNutrientUnit(vm, food, 406);
                    vm.NiacinPercentageDailyValue = Decimal.ToInt16(100 * vm.Niacin / 20.0M);

                    vm.FolicAcid = GetNutrientValue(vm, food, 431);
                    vm.FolicAcidUnit = GetNutrientUnit(vm, food, 431);
                    vm.FolicAcidPercentageDailyValue = Decimal.ToInt16(100 * vm.FolicAcid / 400.0M);

                    vm.VitaminD = GetNutrientValue(vm, food, 324);
                    vm.VitaminDUnit = GetNutrientUnit(vm, food, 324);
                    vm.VitaminDPercentageDailyValue = Decimal.ToInt16(100 * vm.VitaminD / 400.0M); 

                    vm.VitaminB12 = GetNutrientValue(vm, food, 418);
                    vm.VitaminB12Unit = GetNutrientUnit(vm, food, 418);
                    vm.VitaminB12PercentageDailyValue = Decimal.ToInt16(100 * vm.VitaminB12 / 6.0M);
                   
                    vm.VitaminB6 = GetNutrientValue(vm, food, 415);
                    vm.VitaminB6Unit = GetNutrientUnit(vm, food, 415);
                    vm.VitaminB6PercentageDailyValue = Decimal.ToInt16(100 * vm.VitaminB6 / 2.0M);

                    vm.Magnesium = GetNutrientValue(vm, food, 304);
                    vm.MagnesiumUnit = GetNutrientUnit(vm, food, 304);
                    vm.MagnesiumPercentageDailyValue = Decimal.ToInt16(100 * vm.Magnesium / 400.0M);
                }
            }
            return vm;
        }
         

        private static decimal GetNutrientValue(UsdaFoodReportViewModel vm, food food, int id)
        {
            Decimal value = 0;
            if (food.nutrients.Where(n => n.nutrient_id == id) != null && food.nutrients.Where(n => n.nutrient_id == id).FirstOrDefault() != null && food.nutrients.Where(n => n.nutrient_id == id).FirstOrDefault().measures != null)
            {
                value =    food.nutrients.Where(n => n.nutrient_id == id).FirstOrDefault().measures.FirstOrDefault().value ; 
            }

            return value;
        }


        private static string GetNutrientUnit(UsdaFoodReportViewModel vm, food food, int id)
        {
            string unit = "";
            if (food.nutrients.Where(n => n.nutrient_id == id) != null && food.nutrients.Where(n => n.nutrient_id == id).FirstOrDefault() != null && food.nutrients.Where(n => n.nutrient_id == id).FirstOrDefault().measures != null)
            { 
                unit = food.nutrients.Where(n => n.nutrient_id == id).First().unit;  
            } 
            return unit;
        }

        private static List<Nutrient> GetNutrients(food food)
        {
            List<Nutrient> nutrients = new List<Nutrient>();
            foreach (var item in food.nutrients)
            {
                Nutrient nutrient = new Nutrient();
                nutrient.ID = item.nutrient_id;
                nutrient.Name = item.name;
                nutrient.Unit = item.unit;
                nutrient.Value = item.value;
                nutrient.Measures = GetListMeasure(item.measures);
                nutrients.Add(nutrient);
            }
            return nutrients;
        }

        private static List<Measure> GetListMeasure(measures[] measures)
        {
            List<Measure> listMeasures = new List<Measure>();
            foreach (var item in measures)
            {
                Measure m = new Measure();
                m.Label = item.label;
                m.Quantity = item.qty;
                m.Value = item.value;
                listMeasures.Add(m);
            }
            return listMeasures;
        } 
    }
}