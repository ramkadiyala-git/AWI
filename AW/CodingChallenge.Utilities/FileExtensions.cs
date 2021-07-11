using System;
using System.IO;
using System.Reflection;

namespace CodingChallenge.Utilities
{
    public static class FileExtensions
    {
        public static void ToFile(this string content, string fileName)
        {
            content.ReplaceFile(fileName);
        }

        public static string FromFileInExecutingDirectory(this string fileName)
        {
            var baseDirectory = new Uri(Assembly.GetExecutingAssembly().GetName().CodeBase).LocalPath;
            var directory = Path.GetDirectoryName(baseDirectory);

            return FromFile(Path.Combine(directory, fileName));
        }

        public static string FromFile(this string fileName)
        {
            string content;
            using (var file = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(file))
            {
                content = sr.ReadToEnd();
                sr.Close();
                file.Close();
            }
            return content;
        }

        public static void ReplaceFile(this string contents, string fileName)
        {
            var tempFile = string.Format("{0}.{1}.{2}", fileName, "file.tmp", Path.GetRandomFileName());
            using (var sr = new StreamWriter(tempFile))
            {
                sr.Write(contents);
                sr.Close();
            }

            if (!File.Exists(fileName))
            {
                File.Move(tempFile, fileName);
                return;
            }
            var backupfile = string.Format("{0}.{1}", fileName, "file.bak");
            File.Replace(tempFile, fileName, backupfile, true);
        }
    }
}
