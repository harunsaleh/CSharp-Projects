string name = string.Empty;
while (string.IsNullOrEmpty(name))
{
    name = GetName();
}
ShowName(name);

//Methode GetName() mit return
string GetName()
{
    Console.Write("Type your name and press enter: ");
    name = Console.ReadLine();
    if (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("");
        Console.WriteLine("Name cannot be empty!");
        Console.WriteLine("");
        //Value of name is string.Empty the while loop repeat
        return string.Empty;
    }
    else {

        //Value of name is the name while loop ends
        return name;
    }
}
//Methode Showname ohne return
void ShowName(string name)
{
    Console.WriteLine($"Hello, welcome {name}");
}