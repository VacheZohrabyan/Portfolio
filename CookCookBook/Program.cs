using CookCookBook.App;
using CookCookBook.DataAccess;
using CookCookBook.FileAccess;
using CookCookBook.Recipes;
using CookCookBook.Recipes.Ingredients;

FileFormat fileFormat = FileFormat.TXT;
IStringRepository stringRepository = fileFormat == FileFormat.JSON
    ? new StringJsonRepository()
    : new StringTextualRepository();

string fileName = "recipes";
var fileMetaData = new FileMetaData(fileName, fileFormat);

IngredientRegister ingredientRegister = new IngredientRegister();

var cookesRecipesApp = new CookesRecipesApp(
    new RecipesRepository(
        stringRepository,
        ingredientRegister
    ),
    new RecipesConsoleUserInteraction(ingredientRegister)
);

cookesRecipesApp.Run(fileMetaData.ToPath());