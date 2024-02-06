namespace IOCLearning;

public interface IOtherSimpleInterface
{
    Task Execute();
}

public class OtherSimpleInterface(IMessageWriter messageWriter) : IOtherSimpleInterface
{
    public async Task Execute()
    {
        messageWriter.Write("I am in the OtherSimpleInterface");

        await Task.CompletedTask;
    }
}
