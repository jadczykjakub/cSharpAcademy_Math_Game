using cSharpAcademy_Math_Game;

string name = Helpers.GetName();
var date = DateTime.UtcNow;
var Menu = new Menu(name, date);
Menu.ShowMenu();

