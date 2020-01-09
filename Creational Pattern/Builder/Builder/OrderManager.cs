using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class OrderManager
    {
        private MealBuilder m_Builder = null;

        public void SetBuilder(MealBuilder builder)
        {
            m_Builder = builder;
        }

        public void BuildPlate()
        {
            if ( m_Builder == null )
                throw new Exception( "Builder Object is not set." );

            m_Builder.PrepareSandwiches();
            m_Builder.PrepareBurgrer();
            m_Builder.PrepareDrinks();
            m_Builder.PrepareSideDishes();
            m_Builder.PrepareExtras();
            m_Builder.PrepareDesserts();
        }

    }
}
