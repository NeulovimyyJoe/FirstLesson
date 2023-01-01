namespace lessons;

public interface ICommand
{
    void Execute(string[] arguments);
    string GetHelpMessage();
}