using CookCookBook.Recipes;
using CookCookBook.Recipes.Ingredients;


namespace CookCookBook.App
{
    public interface IRecipesUserInteraction
    {
        void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
        void PromptToCreateRecipe();
        IEnumerable<Ingredient> ReadIngredientsFormUsers();
        void ShowMessage(string message);
        void Exit();
    }
}