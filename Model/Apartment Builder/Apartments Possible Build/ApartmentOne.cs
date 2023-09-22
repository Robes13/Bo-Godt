using Bo_Godt.Model.Apartment_Body_Parts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model.Apartment_Builder.Apartments_Possible_Build
{
    /// <summary>
    /// This class contains everything that a one room apartment would contain
    /// </summary>
    internal class ApartmentOne : ApartmentPart
    {
        #region Fields
        private const byte AREAOFAPARTMENT = 40;
        #endregion Fields
        #region Constructors
        internal ApartmentOne(byte rooms, Kitchen kitchen, Bathroom bathroom, Window windowType) 
        {
            if (rooms != 1)
            {
                Debug.WriteLine("Incorrect input. Please try again, This apartment can only have one room");
                throw new ArgumentException("Incorrect input. Please try again, This apartment can only have one room");
            }
            else 
            {
                _rooms = rooms;
            }
            _kitchenOne = kitchen;
            _bathroom = bathroom;
            if(windowType == _oneLayerWindow)
            {
                _oneLayerWindow = windowType;
            }
            else if(windowType == _twoLayerWindow)
            {
                _twoLayerWindow = windowType;
            }
            else if (windowType == _threeLayerWindow) 
            {
                _threeLayerWindow = windowType;
            }
            else
            {
                Debug.WriteLine("There was an error in creating this apartment. Please try again.");
                throw new ArgumentException("There was an error in creating this apartment. Please try again.");
            }
        }
        #endregion Constructors
        #region Properties
        internal byte AreaOfApartment
        {
            get { return AREAOFAPARTMENT; }
        }
        #endregion Properties
        #region Methods
        internal override string Print()
        {
            return $"I have {_rooms} room.";
        }
        #endregion Methods
    }
}
