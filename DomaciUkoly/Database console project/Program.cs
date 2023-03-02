using Spectre.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        Welcome();

        //reaad app cofig
        Database database = new Database();
        Menu manager = new Menu(database);

        static void Welcome()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("Car service managment").Centered());
            AnsiConsole.Write(new Markup("Version: 1.0.0").Centered());
            AnsiConsole.Write(new Markup("Created by: Ondřej Kulhavý").Centered());
            AnsiConsole.Write(new Markup("[gray]Press any key to continue...[/]").Centered());
            Console.ReadKey();
        }
    }
}