public class Samurai : ICharacter
{
    private List<Icommand> commands = new List<Icommand>();
    private Weapon weapon;
    public Samurai(Weapon weapon)
    {
        this.weapon = weapon;
    }
    public void AddCommand(Icommand command)
    {
        commands.Add(command);
        command.SetCharacter("Samurai ");
    }
    public void ExecuteCommands()
    {
        foreach (Icommand command in commands)
        {
            command.Execute();
        }
    }
}