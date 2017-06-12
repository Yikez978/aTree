using System.IO;

namespace aTree
{
    class DirectoryInfoExtensions
    {
        public static bool IsReal(DirectoryInfo info) {
            return !(info.Attributes.HasFlag(FileAttributes.ReparsePoint));
        }
    }
    class FileInfoExtensions
    {
        public static bool IsReal(FileInfo info)
        {
            return !(info.Attributes.HasFlag(FileAttributes.ReparsePoint));
        }
    }
}
