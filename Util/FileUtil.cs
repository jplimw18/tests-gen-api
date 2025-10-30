using System.Threading.Tasks;

namespace TestGenAPI;

public static class FileUtil
{
    public static async Task ConvertByteToFile(byte[] bytes, string path)
    {
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        await File.WriteAllBytesAsync(path, bytes);
    }

    public static async Task<IEnumerable<String>> GetFilesContent(string path)
    {
        if (!Directory.Exists(path))
            throw new FileNotFoundException("An error ocurred when try to get file content: The file path not found.");


        return Directory.GetFiles(path)
            .Select(async f => await File.ReadAllTextAsync(path))
            .Select(t => t.Result);
        
    }
}
