using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// An interface for Abstraction. The implementors of this interface are the classes 
    /// that serve as Abstraction to the client program (not to confuse with 'abstract' 
    /// keyword in OOP).
    /// 
    /// An abstraction classes are those classes that serve as first point for clients and
    /// allow them to interact with underlying implementor classes. They carry out the actual 
    /// client actions on the implementor classes. This allows the abstraction classes to vary 
    /// by functionality independently from each other. 
    /// 
    /// </summary>
    public interface IRemote
    {
        void ToggleDevice();

        void IncreaseVolume();

        void DecreaseVolume();

        void IncreaseChannel();

        void DescreseChannel();

        void SetImplementation( IImplementation concreteImplementer );
    }
}
