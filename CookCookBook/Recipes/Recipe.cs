using CookCookBook.Recipes.Ingredients;

namespace CookCookBook.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients{ get; }
        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            List<string> steps = new List<string>();
            foreach (var ingredient in Ingredients)
            {
                steps.Add($"{ingredient.Name}. {ingredient.PreparationInstruction}");
            }
            return string.Join(Environment.NewLine, steps);
        }
    }
}