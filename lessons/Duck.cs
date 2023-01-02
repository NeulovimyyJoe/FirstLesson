public class Duck
{
    public string nickname;
    public string displayName;

    public Duck(string name)
    {
        nickname = name;
        displayName = name;
    }

    public virtual void Fly()
    {
        Console.WriteLine($"{displayName} is now flying!");
    }
}