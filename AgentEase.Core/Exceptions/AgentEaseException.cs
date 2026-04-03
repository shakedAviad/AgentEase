namespace AgentEase.Core.Exceptions;

public class AgentEaseException(string message, Exception? innerException = null) : Exception(message, innerException)
{}
