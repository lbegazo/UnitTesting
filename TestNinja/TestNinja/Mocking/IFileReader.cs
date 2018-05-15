namespace TestNinja.Mocking
{
    public interface IFileReader
    {
        IFileReader Object { get; }

        string Read(string path);
    }
}