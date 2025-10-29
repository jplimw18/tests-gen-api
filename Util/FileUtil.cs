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

    public static async Task<IEnumerable<String>> GetFileContent(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException("An error ocurred when try to get file content: The file path not found.");

        throw new NotImplementedException();
    }
}
