using System.IO;
using Solid.Practices.Composition.Contracts;

namespace netcore
{
    class NetCorePlatformProvider : IPlatformProvider
    {
        public string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }

        public string[] GetFiles(string path, string searchPattern)
        {
            return Directory.GetFiles(path, searchPattern);
        }

        public string GetRootPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}