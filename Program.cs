using System;

namespace WindowsTmp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.IO.Path.Combine("C:\\", "tmp");
            if(System.IO.Directory.Exists(path))
            {
                System.IO.Directory.Delete(path, true);
            }
            System.IO.Directory.CreateDirectory(path);
        }
    }
}
