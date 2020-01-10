using System;
namespace Composite
{
    class Program
    {
        static IFileSystemComponent root;
        static void Main(string[] args)
        {
            var cwd = new System.IO.DirectoryInfo( System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            var rootDirPath = cwd.Split(new char[] { '/', '\\' });
            root = new DirectoryComponent( rootDirPath[rootDirPath.Length-1] );
            root = PopulateDirectory(root, cwd);

            root.Print( 0 );

        }

        static IFileSystemComponent PopulateDirectory( IFileSystemComponent current, string path )
        {
            if (current == null || current is FileComponent)
                return current;

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo( path );
            var childrenDir = di.GetDirectories();
            var childrenFile = di.GetFiles();

            foreach (var child in childrenFile)
                current.AddComponent(new FileComponent(child.Name));

            foreach (var child in childrenDir)
                current.AddComponent(PopulateDirectory(new DirectoryComponent(child.Name), child.FullName));

            return current;
        }
    }
}
