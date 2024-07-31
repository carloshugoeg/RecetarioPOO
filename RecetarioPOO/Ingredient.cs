using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RecetarioPOO
{
    internal class Ingredient
    {
        public Ingredient(string ingredientName, string ingredientAmount)
        {
            this.ingredientName = ingredientName;
            this.ingredientAmount = ingredientAmount;
        }

        private string ingredientName {  get; set; }
        private string ingredientAmount { get; set; }

        public void AddIngredient()
        {
            List<Ingredient> ingredientList = new List<Ingredient>();
            do
            {
                Console.WriteLine("---NEW INGREDIENT---");
                Console.WriteLine("\nIngredient Name: ");
                ingredientName = Console.ReadLine();
                Console.WriteLine("Amount: ");
                ingredientName = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIngredient added succesfully!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("\nWant to add anonther ingredient? y/n");
                string option = Console.ReadLine().ToLower().Trim();
                if (option == "n") break;
            } while (true);

        }
    }
}
