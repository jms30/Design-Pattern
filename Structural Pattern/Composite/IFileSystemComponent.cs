using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// Interface to represent file system.
    /// </summary>
    public interface IFileSystemComponent
    {
        string Name
        {
            get;
        }

        void AddComponent( IFileSystemComponent newComponent );

        void Print( int tabCount );
    }
}


