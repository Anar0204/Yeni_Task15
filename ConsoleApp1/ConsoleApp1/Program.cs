using ConsoleApp1;

Person[] persons = new Person[3];

Person person = new Person();
person.Age = 10;
person.Name = "Anar";

Person person1 = new Person();
person1.Age = 15;
person1.Name = "Anar2";

Person person2 = new Person();
person2.Age = 6;
person2.Name = "Anar3";


persons[0] = person;
persons[1] = person1;
persons[2] = person2;

Array.Sort(persons);


foreach (var itemP in persons)
{
    Console.WriteLine($"name:{itemP.Name} surname:{itemP.Surname}  Age: {itemP.Age}");
}