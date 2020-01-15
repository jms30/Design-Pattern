using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// The iterator class that iterates over a given collection.
    /// It can iterate in a forward way and a reverse way as well.
    /// </summary>
    public class NumberCollectionIterator : IEnumerator<int>
    {
        private List<int> m_Collection = null;

        private int m_CurrentPointer = 0;

        private bool m_Reverse = false;

        private int CurrentPrivate
        {
            get
            {
                return this.Current;
            }
        }

        public NumberCollectionIterator( List<int> collection, bool isReversed )
        {
            m_Collection = collection;
            m_Reverse = isReversed;
            m_CurrentPointer = ( m_Reverse ) ? m_Collection.Count : -1;
        }

        #region IEnumerator Implementation
        public int Current 
        {
            get;
            private set;
        }

        object IEnumerator.Current
        {
            get
            {
                return CurrentPrivate;
            }
        }

        public bool MoveNext()
        {
            if ( ( m_Reverse && m_CurrentPointer == 0 ) || 
                ( !m_Reverse && m_CurrentPointer == m_Collection.Count - 1 ) )
                return false;
            m_CurrentPointer = m_CurrentPointer + ( ( m_Reverse ) ?  - 1 :  1 );
            Current = m_Collection[m_CurrentPointer];
            return true;
        }

        public void Reset()
        {
            Current = default;
            m_CurrentPointer = ( m_Reverse ) ? m_Collection.Count : -1;
        }
        #endregion

        #region IDisposable Support

        private bool disposedValue = false;
        protected virtual void Dispose( bool disposing )
        {
            if ( !disposedValue )
            {
                if ( disposing )
                {
                    // TODO: dispose managed state (managed objects).
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose( true );
        }
        #endregion

    }
}
