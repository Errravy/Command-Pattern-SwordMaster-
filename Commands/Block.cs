public class Block : Icommand
{
    string? character;
    private Weapon weapon;
    public Block(Weapon weapon)
    {
        this.weapon = weapon;
    }
    public void Execute()
    {
        Console.WriteLine(character + "block with his " + weapon.GetWeapon());
    }

    public void SetCharacter(string character)
    {
        this.character = character;
    }
}