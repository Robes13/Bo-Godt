using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model.Apartment_Body_Parts
{
    /// <summary>
    /// This class contains anything that a bathroom contains.
    /// </summary>
    internal class Bathroom
    {
        #region Fields
        private Window _oneLayerFrostedWindow;
        #endregion Fields
        #region Properties
        public Window OneLayerFrostedWindow
        {
            get { return _oneLayerFrostedWindow; }
            set { _oneLayerFrostedWindow = value; }
        }
        #endregion Properties
    }
}
