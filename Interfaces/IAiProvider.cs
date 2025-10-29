namespace TestGenAPI;

public interface IAiProvider
{
    Task<String> SendPrompt(string prompt);
    public string providerName { get; }
}
