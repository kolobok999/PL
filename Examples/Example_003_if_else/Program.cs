Console.WriteLine("Введие имя пользователя");
string name = Console.ReadLine();

if (name.ToLower() == "маша") {
    Console.WriteLine("Ура,это Маша");
}
else {
    Console.WriteLine("Привет, " + name);
}