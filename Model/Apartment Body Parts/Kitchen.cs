using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model.Apartment_Body_Parts
{
    /// <summary>
    /// This class contains the available kitchens.
    /// </summary>
    internal class Kitchen
    {
        #region Fields
        private byte _kitchenOne;
        private byte _kitchenTwo;
        private byte _kitchenThree;
        private byte _kitchenFour;
        private byte _kitchenFive;
        #endregion Fields
        #region Properties
        internal byte KitchenOne
        {
            get { return _kitchenOne; }
            set { _kitchenOne = value;}
        }

        internal byte KitchenTwo
        {
            get { return _kitchenTwo; }
            set { _kitchenTwo = value;}
        }

        internal byte KitchenThree
        {
            get { return _kitchenThree; }
            set { _kitchenThree = value;}
        }

        internal byte KitchenFour
        {
            get { return _kitchenFour; }
            set { _kitchenFour = value;}
        }

        internal byte KitchenFive
        {
            get { return _kitchenFive; }
            set { _kitchenFive = value;}
        }
        #endregion Properties
    }
}
