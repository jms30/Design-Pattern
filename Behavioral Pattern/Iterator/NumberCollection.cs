using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// A collection class that holds the data internally 
    /// and allows client to add/get the collected data.
    /// It implements <see cref="IEnumerable{T}"/> interface that 
    /// inherently allows iterating over the collection.
    /// </summary>
    public class NumberCollection : IEnumerable<int>
    {
        private List<int> m_InternalCollection = null;

        private bool m_IsReversed = false;

        public NumberCollection()
        {
            m_InternalCollection = new List<int>();
        }

        public IReadOnlyCollection<int> GetItems()
        {
            return m_InternalCollection.AsReadOnly();
        }

        public void ReverseDirection()
        {
            m_IsReversed = !m_IsReversed;
        }

        public void AddItem( int item )
        {
            m_InternalCollection.Add( item );
        }

        private IEnumerator GetEnumeratorPrivate()
        {
            return this.GetEnumerator();
        }

        #region IEnumerable Implementation
        public IEnumerator<int> GetEnumerator()
        {
            return new NumberCollectionIterator( m_InternalCollection, m_IsReversed );
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumeratorPrivate();
        }
        #endregion
    }
}
