namespace DotnetSecretsConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dotnet Secrets Console App example");

        var settingsReader = new SettingsReader();

        var credentials = settingsReader.ReadSection<Credentials>("ConsoleCredentials");

        Console.WriteLine($"Credentials.Username: {credentials.Username}");
        Console.WriteLine($"Credentials.Password: {credentials.Password}");
    }
}