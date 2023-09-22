using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model.Apartment_Body_Parts
{
    /// <summary>
    /// This class contains the available doors
    /// </summary>
    internal class Door
    {
        #region Fields
        private string? _fronDoor;
        private string? _backDoor;
        #endregion Fields
        #region Properties
        internal string? FrontDoor
        {
            get { return _fronDoor; }
            set { _fronDoor = value; }
        }
        internal string? BackDoor
        {
            get { return _backDoor; }
            set { _backDoor = value; }
        }
        #endregion Properties
    }
}
