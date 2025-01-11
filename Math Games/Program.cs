using Math_Games;

var menu = new Menu();

string? name = Helpers.GetName();
DateTime date = DateTime.UtcNow;

var games = new List<string>();

menu.ShowMenu(name, date);


