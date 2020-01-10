using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public interface IFileSystemComponent
    {
        string Name
        {
            get;
        }

        void AddComponent( IFileSystemComponent newComponent );

        void Print( int widespace );
    }

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

        public void Print( int widespace )
        {
            Console.Write( string.Format( "File: {0}, ", Name ).PadLeft( widespace ) );
        }
    }

    public class DirectoryComponent : IFileSystemComponent
    {

        List<IFileSystemComponent> m_Children = null;

        public string Name
        {
            get;
            private set;
        } = "";
        
        public DirectoryComponent( string name )
        {
            m_Children = new List<IFileSystemComponent>();
            Name = name;
        }

        public void AddComponent( IFileSystemComponent newComponent )
        {
            m_Children.Add( newComponent );
        }

        public void Print( int widespace )
        {
            var directoryPad = "Directory " + Name;
            directoryPad = directoryPad.PadLeft( widespace );
            Console.WriteLine( "\n"+ directoryPad );
            foreach (var item in m_Children)
            {
                Console.WriteLine();
                if ( item is DirectoryComponent )
                {
                    item.Print( widespace + 8 );
                }
                else
                    item.Print( widespace +  12 );
            }
        }
    }
}


