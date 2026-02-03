using System.Diagnostics;
using System.Text;

namespace ERP.Seed;

public class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("bonour");

        // Getter les seed functions dans l'autre assembly 
        // TODO: allow many scenarios for the same seed

        // Dotnet run avec un 

        // 

        await Execute(nameof(SeededCompany), "");
    }

    static Process Process;

    static async Task Execute(string seedName, string projectRunPath)
    {
        var allo = new DirectoryInfo("../../../../src/ERP.Api");

        var stdOutBuffer = new StringBuilder();
        var stdErrBuffer = new StringBuilder();

        string path = "C:\\CODING\\aetherfire23.erp\\erp\\src\\ERP.Api\\ERP.Api.csproj";

        var info = new ProcessStartInfo($"dotnet", $"run --project {path}");

        info.UseShellExecute = true;

        Process = Process.Start(info);

        await Process.WaitForExitAsync();

        while (true)
        {
            await Task.Delay(Timeout.Infinite);
        }
        
        
        

        // CliWrap.Cli.Wrap("dotnet")
        //     .WithArguments("run")
        //     .WithWorkingDirectory(allo.FullName + "\\")
        //     .WithStandardOutputPipe(PipeTarget.ToStringBuilder(stdOutBuffer))
        //     .WithStandardErrorPipe(PipeTarget.ToStringBuilder(stdErrBuffer))
        //     .ExecuteAsync().ConfigureAwait(false);
        //
        // Console.WriteLine(stdErrBuffer.ToString());
        // Console.WriteLine(stdErrBuffer.ToString());
    }

    ~Program()
    {
        Process.Kill(entireProcessTree: true);
    }
}