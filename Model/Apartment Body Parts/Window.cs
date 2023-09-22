using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model.Apartment_Body_Parts
{
    /// <summary>
    /// This class contains the available windows.
    /// </summary>
    internal class Window
    {
        #region Fields
        private string? _oneLayerWindow;
        private string? _oneLayerFrostedWindow;
        private string? _twoLayerWindow;
        private string? _threeLayerWindow;
        #endregion Fields
        #region Properties
        internal string? OneLayerWindow
        {
            get { return _oneLayerWindow; }
            set { _oneLayerWindow = value; }
        }

        internal string? OneLayerFrostedWindow
        {
            get { return _oneLayerFrostedWindow; }
            set { _oneLayerFrostedWindow = value; }
        }

        internal string? TwoLayerWindow
        {
            get { return _twoLayerWindow; }
            set { _twoLayerWindow = value; }
        }

        internal string? ThreeLayerWindow
        {
            get { return _threeLayerWindow; }
            set { _oneLayerFrostedWindow= value; }
        }
        #endregion Properties
    }
}
