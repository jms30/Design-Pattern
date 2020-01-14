using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// The 'Leaf' class.
    /// </summary>
    public class FileComponent : IFileSystemComponent
    {
        public string Name
        {
            get;
            private set;
        } = "";

        public FileComponent( string name )
        {
            Name = name;
        }

        public void AddComponent( IFileSystemComponent newComponent )
        {
            Console.Write( "File " + Name + " is the leaf node." );
        }

        public void Print( int tabCount)
        {
            Console.Write( new string( '\t', tabCount) + string.Format( "File: {0}, ", Name ) );
        }
    }
}
