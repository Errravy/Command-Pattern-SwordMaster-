public class Slash : Icommand
{
    string? character;
    private Weapon weapon;
    public Slash(Weapon weapon)
    {
        this.weapon = weapon;
    }
    public void Execute()
    {
        Console.WriteLine(character + "slash with his " + weapon.GetWeapon());
    }
    public void SetCharacter(string character)
    {
        this.character = character;
    }
}