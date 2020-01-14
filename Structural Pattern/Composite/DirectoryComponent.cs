using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// The aggregator class that can act as 'Leaf' or 
    /// a 'root' that has many children under. 
    /// </summary>
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

        public void Print( int tabCount )
        {
            var directoryPad = new string( '\t', tabCount ) + "Directory " + Name;
            // directoryPad = directoryPad.PadLeft( widespace );
            Console.WriteLine( "\n" + directoryPad );
            foreach ( var item in m_Children )
            {
                Console.WriteLine();
                item.Print( tabCount + 1 );
            }
        }
    }

}
