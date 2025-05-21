

using TaskManagmentApp;
using TaskManagmentApp.Enums;

Task1 task1 = new Task1("Ders", TaskStatus1.Cancelled);

Task1 task2 = new Task1("Dizayn", TaskStatus1.NotStarted);

Task1 task3 = new Task1("Yemek bisir", TaskStatus1.InProgress);


Console.WriteLine(task1.ToString());

string[] strings = new string[4];



SimpleStringCollection simpleStringCollection = new SimpleStringCollection(strings);

simpleStringCollection[1] = "Kitap";

string name = simpleStringCollection[1];

Console.WriteLine( name);





