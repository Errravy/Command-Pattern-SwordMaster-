
public class Program
{
    public static void Main()
    {
        Weapon sword = new Weapon("Black Edge");
        Weapon katana = new Weapon("Blinded Man Katana");
        Knight knight = new Knight(sword);
        Samurai samurai = new Samurai(katana);

        knight.AddCommand(new Slash(sword));
        knight.AddCommand(new Thrust(sword));
        knight.AddCommand(new Block(sword));

        samurai.AddCommand(new Slash(katana));
        samurai.AddCommand(new Thrust(katana));

        Console.WriteLine(" ");
        knight.ExecuteCommands();
        Console.WriteLine(" ");
        samurai.ExecuteCommands();
        Console.WriteLine(" ");
    }
}
