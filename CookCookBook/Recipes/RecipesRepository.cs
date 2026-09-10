using CookCookBook.DataAccess;
using CookCookBook.Recipes.Ingredients;

namespace CookCookBook.Recipes
{
    public class RecipesRepository : IRecipesRepository
    {
        private readonly IStringRepository _stringRepository;
        private readonly IIngredientRegister _ingredientRegister;
        private const string separator = ",";
        public RecipesRepository(IStringRepository stringRepository, IIngredientRegister ingredientRegister)
        {
            _stringRepository = stringRepository;
            _ingredientRegister = ingredientRegister;
        }

        public List<Recipe> Read(string filePath)
        {
            List<string> recipesFromFile = _stringRepository.Read(filePath);
            List<Recipe> recipes = new List<Recipe>();

            foreach (string recipeFromFile in recipesFromFile)
            {
                Recipe recipe = RecipeFromString(recipeFromFile);
                recipes.Add(recipe);
            }

            foreach(Recipe rec in recipes)
            {
                rec.ToString();
            }
            return recipes;
        }

        private Recipe RecipeFromString(string recipeFromFile)
        {
            string[] textualIds = recipeFromFile.Split(separator);
            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (string textualId in textualIds)
            {
                int id = int.Parse(textualId);
                Ingredient ingredient = _ingredientRegister.GetById(id);
                ingredients.Add(ingredient);
            }
            return new Recipe(ingredients);
        }
        
        public void Write(string filePath, List<Recipe> allRecipes)
        {
            List<string> recipesAsStrings = new List<string>();
            foreach (Recipe recipe in allRecipes)
            {
                List<int> allIds = new List<int>();
                foreach(Ingredient ingredient in recipe.Ingredients)
                {
                    allIds.Add(ingredient.Id);
                }
                recipesAsStrings.Add(string.Join(separator, allIds));
            }
            _stringRepository.Write(filePath, recipesAsStrings);
        }
    }
}