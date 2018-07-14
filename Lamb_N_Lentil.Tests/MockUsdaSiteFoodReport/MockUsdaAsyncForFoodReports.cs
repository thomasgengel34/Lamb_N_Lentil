using Lamb_N_Lentil.Domain;
using Lamb_N_Lentil.Domain.UsdaInformation;
using Lamb_N_Lentil.Domain.UsdaList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lamb_N_Lentil.Tests.MockUsdaSiteFoodReport
{
    public class MockUsdaAsyncForFoodReport : IUsdaAsync
    {
        protected UsdaFoodReport report;

        public MockUsdaAsyncForFoodReport()
        {
            report = new UsdaFoodReport
            {
                foods = new foods[1]
            };

            report.foods = new foods[]
            {
               report.foods[0] = new  foods()  
            };

            report.foods.First().food = new food
            {
                desc = new desc
                {
                    name = "My Name",
                    ndbno = "0"
                },
                ing = new ing
                {
                    desc = "ing-desc"
                }
            };
            report.foods.First().food.desc.fg = "default food group";
            report.foods.First().food.desc.manu = "default manufacturer";
            report.foods.First().food.ing.upd = "default updated date";
                            
            report.foods.First().food.nutrients = new nutrients[26];

            report.foods.First().food.nutrients[0] = new nutrients
            {
                name = "Total Fat",
                nutrient_id = 204,
                value = "24",
                unit = "unit for total fat",

                measures = new measures[1]
            };
            report.foods.First().food.nutrients[0].measures[0] = new measures
            {
                label = "default label total fat",
                eqv = 3.1415926M,
                value = 654.2M,
                qty = 1.0101M,
            };

            report.foods.First().food.nutrients[1] = new nutrients
            {
                name = "Calcium",
                nutrient_id = 301,
                value = "25",
                unit = "unit for Calcium",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[1].measures[0] = new measures
            {
                label = "default label calcium",
                eqv = 2M,
                value = 0.95M
            };

            report.foods.First().food.nutrients[2] = new nutrients
            {
                name = "Cholesterol",
                nutrient_id = 601,
                value = "25",
                unit = "unit for cholesterol",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[2].measures[0] = new measures
            {
                label = "default label cholesterol",
                eqv = 2M,
                value = 82.93M
            };

            report.foods.First().food.nutrients[3] = new nutrients
            {
                name = "Iron",
                nutrient_id = 303,
                value = "26",
                unit = "unit for Iron",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[3].measures[0] = new measures
            {
                label = "default label iron",
                eqv = 2M,
                value = 0.114M
            };

            report.foods.First().food.nutrients[4] = new nutrients
            {
                name = "Magnesium",
                nutrient_id = 304,
                value = "27",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[4].measures[0] = new measures
            {
                label = "default label magnesium",
                eqv = 2M,
                value = 22.23M
            };

            report.foods.First().food.nutrients[5] = new nutrients
            {
                name = "Niacin",
                nutrient_id = 406,
                value = "28",
                unit = "unit for Niacin",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[5].measures[0] = new measures
            {
                label = "default label niacin",
                eqv = 2M,
                value = 21.045M
            };

            report.foods.First().food.nutrients[6] = new nutrients
            {
                name = "Monosaturated Fat",
                nutrient_id = 645,
                value = "29",
                unit = "unit for monounsaturated fat",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[6].measures[0] = new measures
            {
                label = "default label m-s fat",
                eqv = 2M,
                value = 81.92M
            };

            report.foods.First().food.nutrients[7] = new nutrients
            {
                name = "Polyunsaturated Fat",
                nutrient_id = 646,
                value = "30",
                unit = "unit for polyunsaturated fat",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[7].measures[0] = new measures
            {
                label = "default label puns fat",
                eqv = 2M,
                value = 736.08M
            };

            report.foods.First().food.nutrients[8] = new nutrients
            {
                name = "Protein",
                nutrient_id = 203,
                value = "31",
                unit = "unit for Protein",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[8].measures[0] = new measures
            {
                label = "default label protein",
                eqv = 2M,
                value = 7.15M
            };

            report.foods.First().food.nutrients[9] = new nutrients
            {
                name = "Riboflavin",
                nutrient_id = 405,
                value = "32",
                unit = "unit for Riboflavin",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[9].measures[0] = new measures
            {
                label = "default label riboflavin",
                eqv = 2M,
                value = 3.333M
            };

            report.foods.First().food.nutrients[10] = new nutrients
            {
                name = "Sodium",
                nutrient_id = 307,
                value = "33",
                unit = "unit for sodium",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[10].measures[0] = new measures
            {
                label = "default label sodium",
                eqv = 2M,
                value = 143.0M
            };

            report.foods.First().food.nutrients[11] = new nutrients
            {
                name = "Sugars",
                nutrient_id = 269,
                value = "34",
                unit = "unit for Sugars",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[11].measures[0] = new measures
            {
                label = "default label sugars",
                eqv = 2M,
                value = 14.30M
            };

            report.foods.First().food.nutrients[12] = new nutrients
            {
                name = "Thiamine",
                nutrient_id = 404,
                value = "35",
                unit = "unit for Thiamine",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[12].measures[0] = new measures
            {
                label = "default label thiamine",
                eqv = 2M,
                value = 1.228M
            };

            report.foods.First().food.nutrients[13] = new nutrients
            {
                name = "Total carbohydrate",
                nutrient_id = 205,
                value = "36",
                unit = "unit for total carbohydrate",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[13].measures[0] = new measures
            {
                label = "default label total carb",
                eqv = 2M,
                value = 77.04M
            };

            report.foods.First().food.nutrients[14] = new nutrients
            {
                name = "Trans Fat",
                nutrient_id = 605,
                value = "37",
                unit = "unit for trans fat",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[14].measures[0] = new measures
            {
                label = "default label trans fat",
                eqv = 2M,
                value = 101.01M
            };

            report.foods.First().food.nutrients[15] = new nutrients
            {
                name = "Vitamin A",
                nutrient_id = 318,
                value = "39",
                unit = "unit for VitaminA",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[15].measures[0] = new measures
            {
                label = "default label vitamin A",
                eqv = 2.1M,
                value = 101.02M
            };

            report.foods.First().food.nutrients[16] = new nutrients
            {
                name = "Vitamin B12",
                nutrient_id = 418,
                value = "39",
                unit = "unit for vitamin B12",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[16].measures[0] = new measures
            {
                label = "default label vitamin B12",
                eqv = 2M,
                value = 71.055M
            };

            report.foods.First().food.nutrients[17] = new nutrients
            {
                name = "Vitamin B6",
                nutrient_id = 415,
                value = "40",
                unit = "unit for vitamin B6",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[17].measures[0] = new measures
            {
                label = "default label vitamin B6",
                eqv = 2M,
                value = 76.05M
            };

            report.foods.First().food.nutrients[18] = new nutrients
            {
                name = "Vitamin C",
                nutrient_id = 401,
                value = "41",
                unit = "unit for VitaminC",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[18].measures[0] = new measures
            {
                label = "default label vitamin C",
                eqv = 2M,
                value = 1.8M
            };

            report.foods.First().food.nutrients[19] = new nutrients
            {
                name = "Vitamin D",
                nutrient_id = 324,
                value = "42",
                unit = "unit for vitamin D",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[19].measures[0] = new measures
            {
                label = "default label vitamin D",
                eqv = 2M,
                value = 0.228M
            };

            report.foods.First().food.nutrients[20] = new nutrients
            {
                name = "Saturated Fat",
                nutrient_id = 606,
                value = "42",
                unit = "unit for saturated fat",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[20].measures[0] = new measures
            {
                label = "default label saturated fat",
                eqv = 2.1M,
                value = 0.230M
            };

            report.foods.First().food.nutrients[21] = new nutrients
            {
                name = "Potassium",
                nutrient_id = 306,
                value = "43",
                unit = "unit for potassium",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[21].measures[0] = new measures
            {
                label = "default label potassium",
                eqv = 2.2M,
                value = 306.2M
            };

            report.foods.First().food.nutrients[22] = new nutrients
            {
                name = "Dietary Fiber",
                nutrient_id = 291,
                value = "44",
                unit = "unit for Dietary Fiber",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[22].measures[0] = new measures
            {
                label = "default label dietary fiber",
                eqv = 2.3M,
                value = 306.3M
            };


            report.foods.First().food.nutrients[23] = new nutrients
            {
                name = "Folic Acid",
                nutrient_id = 431,
                value = "45",
                unit = "unit for folic acid",
                measures = new measures[1]
            };
            report.foods.First().food.nutrients[22].measures[0] = new measures
            {
                label = "default label folic acid",
                eqv = 2.4M,
                value = 306.4M
            };
        }


        public int FetchedTotalFromSearch { get; set; }
        public string FetchedIngredientsInIngredient { get; set; }

        async Task<UsdaFoodReport> IUsdaAsync.FetchUsdaFoodReport(string ndbno)
        {
            await Task.Delay(0);
            report.foods.First().food.nutrients[0].measures[0].label = "I am an error";
            if (ndbno == "ShouldReturnIngredients")
            {
                report.foods.First().food.nutrients[0].measures[0].label = "I am a label";
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueTotalFat0")
            {
                report.foods.First().food.nutrients[0].measures[0].value = 0;
            }

            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueTotalFat65")
            {
                report.foods.First().food.nutrients[0].measures[0].value = 65;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueSaturatedFat0")
            {
                report.foods.First().food.nutrients[20].measures[0].value = 0;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueSaturatedFat20")
            {
                report.foods.First().food.nutrients[20].measures[0].value = 20;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueCholesterol0")
            {
                report.foods.First().food.nutrients[2].measures[0].value = 0;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueCholesterol300")
            {
                report.foods.First().food.nutrients[2].measures[0].value = 300;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueSodium0")
            {
                report.foods.First().food.nutrients[10].measures[0].value = 0;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueSodium2400")
            {
                report.foods.First().food.nutrients[10].measures[0].value = 2400;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValuePotassium0")
            {
                report.foods.First().food.nutrients[21].measures[0].value = 0;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValuePotassium3500")
            {
                report.foods.First().food.nutrients[21].measures[0].value = 3500;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueTotalCarbohydrate0")
            {
                report.foods.First().food.nutrients[13].measures[0].value = 0;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueTotalCarbohydrate300")
            {
                report.foods.First().food.nutrients[13].measures[0].value = 300;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueDietaryFiber0")
            {
                report.foods.First().food.nutrients[22].measures[0].value = 0;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueDietaryFiber25")
            {
                report.foods.First().food.nutrients[22].measures[0].value = 25;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueVitaminA0")
            {
                report.foods.First().food.nutrients[15].measures[0].value = 0;
            }

            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueVitaminA5000")
            {
                report.foods.First().food.nutrients[15].measures[0].value = 5000;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueVitaminC0")
            {
                report.foods.First().food.nutrients[18].measures[0].value = 0;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueVitaminC60")
            {
                report.foods.First().food.nutrients[18].measures[0].value = 50;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueCalcium0")
            {
                report.foods.First().food.nutrients[1].measures[0].value = 0;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueCalcium1000")
            {
                report.foods.First().food.nutrients[1].measures[0].value = 1000;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueIron0")
            {
                report.foods.First().food.nutrients[3].measures[0].value = 0;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueIron20")
            {
                report.foods.First().food.nutrients[3].measures[0].value = 18;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueThiamine0")
            {
                report.foods.First().food.nutrients[12].measures[0].value = 0;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueThiamine1point5")
            {
                report.foods.First().food.nutrients[12].measures[0].value = 1.5M;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueRiboflavin0")
            {
                report.foods.First().food.nutrients[9].measures[0].value = 0;
            }
            if (ndbno == "ShouldReturnIngredientsWithPercentageDailyValueRiboflavin1point7")
            {
                report.foods.First().food.nutrients[9].measures[0].value = 1.7M;
            }

            if (ndbno == "ManufacturerNotFoodGroup")
            {
                report.foods.First().food.desc.fg = "";
            }
            if (ndbno == "NoManufacturerOrFoodGroup")
            {
                report.foods.First().food.desc.fg = "";
                report.foods.First().food.desc.manu = "";
            }

            return report;
        }

        


        public async Task<string> GetManufacturerOrFoodGroup(string ndbno)
        {
            await Task.Delay(0);
            if (ndbno == "01009")
            {

                return "Valley Brook Farm";
            }
            else
            {
                return "this should not be possible to see";
            }
        }

        Task<UsdaListofFoods> IUsdaAsync.FetchUsdaFoodList(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}
