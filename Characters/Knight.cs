public class Knight : ICharacter
{
    private Weapon weapon;
    private List<Icommand> commands = new List<Icommand>();

    public Knight(Weapon weapon)
    {
        this.weapon = weapon;
    }
    public void AddCommand(Icommand command)
    {
        commands.Add(command);
        command.SetCharacter("Knight ");
    }
    public void ExecuteCommands()
    {
        foreach (Icommand command in commands)
        {
            command.Execute();
        }
    }
}