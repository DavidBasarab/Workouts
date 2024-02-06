namespace IOCLearning;

public interface IMoreStuff
{
    Task DoMoreStuff();
}

public class MoreStuff(IOtherSimpleInterface otherSimpleInterface) : IMoreStuff
{
    public async Task DoMoreStuff()
    {
        await otherSimpleInterface.Execute();
    }
}
