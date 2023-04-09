public class Thrust : Icommand
{
    string? character;
    private Weapon weapon;
    public Thrust(Weapon weapon)
    {
        this.weapon = weapon;
    }
    public void Execute()
    {
        Console.WriteLine(character + "thrust with his " + weapon.GetWeapon());
    }

    public void SetCharacter(string character)
    {
        this.character = character;
    }

}