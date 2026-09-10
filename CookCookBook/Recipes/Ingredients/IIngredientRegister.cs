namespace CookCookBook.Recipes.Ingredients
{
    public interface IIngredientRegister
    {
        public Ingredient GetById(int id);
        public IEnumerable<Ingredient> All { get; }
    }
}