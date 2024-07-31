using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetarioPOO
{
    internal class Recipes
    {
        public Recipes(string name, string description, List<Ingredient> ingredientList, string procedure)
        {
            RecipeName = name;
            RecipeDescription = description;
            IngredientList = ingredientList;
            RecipeProcedure = procedure;
        }

        private string RecipeName { get; set; }
        private string RecipeDescription { get; set; }
        private List<Ingredient> IngredientList { get; set; }
        private string RecipeProcedure {  get; set; }

        public void NewRecipe()
        {
            Console.Clear();
            Console.WriteLine("-----NEW RECIPE----");
            Console.WriteLine("\nRecipe name: ");
            Console.WriteLine("Please Proceed to add your igredients\nPress ENTER to continue");
            IngredientList
            Console.ReadLine();
            
        }
    }
}
