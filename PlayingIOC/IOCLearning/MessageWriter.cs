namespace IOCLearning;

public interface IMessageWriter
{
	void Write(string message);
}

public class MessageWriter : IMessageWriter
{
	public void Write(string message)
	{
		Console.WriteLine($"MessageWriter : <{message}>");
	}
}