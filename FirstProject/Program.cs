Console.WriteLine("What is your height?");
int input = Convert.ToInt32(Console.ReadLine());
Check(input);

  void Check (int a) 
    { 
    if (input<=147)
{
     Console.WriteLine("You are a dwarf.");
}
    else if (input>147 && input<180)
{
     Console.WriteLine("You are a normal height.");
}
    else
{
     Console.WriteLine("You are too tall.");
}
}

