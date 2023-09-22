﻿using Bo_Godt.Model.Apartment_Body_Parts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model.Apartment_Builder.Apartments_Possible_Build
{
    /// <summary>
    /// This class contains everything that a three room apartment would contain
    /// </summary>
    internal class ApartmentThree : ApartmentPart
    {
        #region Fields
        private const byte AREAOFAPARTMENT = 70;
        #endregion Fields
        #region Constructors
        internal ApartmentThree(byte rooms, Kitchen kitchen, Bathroom bathroom, Window windowType)
        {
            if (rooms != 3)
            {
                Debug.WriteLine("Incorrect input. Please try again, This apartment can only have one room");
                throw new ArgumentException("Incorrect input. Please try again, This apartment can only have three rooms");
            }
            else
            {
                _rooms = rooms;
            }
            _rooms = rooms;
            _kitchenOne = kitchen;
            _bathroom = bathroom;
            if (windowType == _oneLayerWindow)
            {
                _oneLayerWindow = windowType;
            }
            else if (windowType == _twoLayerWindow)
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
            return $"I have {_rooms} rooms.";
        }
        #endregion Methods
    }
}
