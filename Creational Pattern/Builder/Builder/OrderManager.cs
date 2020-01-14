using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// The Director class that dictates some set of actions in a certain steps
    /// to prepare a Kids menu. The actual product will depend upon the type of
    /// Menu Builder.
    /// </summary>
    public class OrderManager
    {
        private MealBuilder m_Builder = null;

        public void SetBuilder( MealBuilder builder )
        {
            m_Builder = builder;
        }

        // The function that will be invoked by client in order to 'Order' a Kids Plate.
        public void BuildPlate()
        {
            if ( m_Builder == null )
                throw new Exception( "Builder Object is not set." );

            m_Builder.PrepareSandwiches();
            m_Builder.PrepareBurger();
            m_Builder.PrepareDrinks();
            m_Builder.PrepareSideDishes();
            m_Builder.PrepareExtras();
            m_Builder.PrepareDesserts();
        }

    }
}
