using CookCookBook.Recipes;
using CookCookBook.Recipes.Ingredients;

namespace CookCookBook.App
{
    class CookesRecipesApp
    {
        private readonly IRecipesRepository _recipesRepository;
        private readonly IRecipesUserInteraction _recipesUserInteraction;

        public CookesRecipesApp(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
        {
            _recipesRepository = recipesRepository;
            _recipesUserInteraction = recipesUserInteraction;
        }

        public void Run(string filePath)
        {
            List<Recipe> allRecipes = _recipesRepository.Read(filePath);
            _recipesUserInteraction.PrintExistingRecipes(allRecipes);

            _recipesUserInteraction.PromptToCreateRecipe();
            var ingredient = _recipesUserInteraction.ReadIngredientsFormUsers();
            if (ingredient.Count() > 0)
            {
                var recipe = new Recipe(ingredient);
                allRecipes.Add(recipe);
                _recipesRepository.Write(filePath, allRecipes);

                _recipesUserInteraction.ShowMessage("Recipes added:");
                _recipesUserInteraction.ShowMessage(recipe.ToString());
            }
            else
            {
                _recipesUserInteraction.ShowMessage(
                    "No ingredients have been selected." +
                    " Recipe will not be saved.");
            }
            _recipesUserInteraction.Exit();
        }
    }
}