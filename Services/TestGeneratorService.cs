using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using TestGenAPI.Interfaces;

namespace TestGenAPI;

public class TestGeneratorService : ITestGenerator
{
    private readonly ICodeExtractor _analysis;
    private readonly IAiProvider _provider;


    public TestGeneratorService(ICodeExtractor analysis, IAiProvider provider)
    {
        _analysis = analysis;
        _provider = provider;
    }
    
    public async void GenTests(byte[] file)
    {
        string path = Environment.GetEnvironmentVariable("TEMP_FILE_PATH")!;
        if (String.IsNullOrEmpty(path) || String.IsNullOrWhiteSpace(path))
            throw new KeyNotFoundException("Uploads path's not found");

        await FileUtil.ConvertByteToFile(file, path);

        IEnumerable<String> files = await FileUtil.GetFileContent(path);

        throw new NotImplementedException();  
    }
}
