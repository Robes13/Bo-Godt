using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model.Apartment_Body_Parts
{
    /// <summary>
    /// This class contains the available floors.
    /// </summary>
    internal class Floor
    {
        #region Fields
        private string? _LaminateFloor;
        #endregion Fields
        #region Properties
        internal string? LaminateFloor
        {
            get { return _LaminateFloor; }
            set { _LaminateFloor = value;}
        }
        #endregion Properties
    }
}
