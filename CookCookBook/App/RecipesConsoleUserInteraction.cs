using CookCookBook.Recipes;
using CookCookBook.Recipes.Ingredients;

namespace CookCookBook.App
{
    public class RecipesConsoleUserInteraction : IRecipesUserInteraction
    {
        private readonly IIngredientRegister _ingredientRegister;

        public RecipesConsoleUserInteraction(IIngredientRegister ingredientRegister)
        {
            _ingredientRegister = ingredientRegister;
        }


        public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
        {
            if (allRecipes.Count() > 0)
            {
                Console.WriteLine("Existing recipes are:" + Environment.NewLine);
                int counter = 1;
                foreach (Recipe recipe in allRecipes)
                {
                    Console.WriteLine($"*******{counter++}*******");
                    Console.WriteLine(recipe.ToString());
                    Console.WriteLine();
                }
            }
        }

        public void PromptToCreateRecipe()
        {
            Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
            foreach (Ingredient ingredient in _ingredientRegister.All)
            {
                Console.WriteLine(ingredient);
            }
        }

        public IEnumerable<Ingredient> ReadIngredientsFormUsers()
        {
            bool shallStop = false;
            var ingredient = new List<Ingredient>();
            while (!shallStop)
            {
                Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");

                string? userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int id))
                {
                    Ingredient selectIngredient = _ingredientRegister.GetById(id);
                    if (selectIngredient is not null)
                    {
                        ingredient.Add(selectIngredient);
                    }
                }
                else
                {
                    shallStop = true;
                }
            }
            return ingredient;
        }


        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}