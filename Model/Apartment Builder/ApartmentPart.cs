using Bo_Godt.Model.Apartment_Body_Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model.Apartment_Builder
{
    /// <summary>
    /// This class contains everything that an apartment can be made up from.
    /// </summary>
    abstract class ApartmentPart
    {
        #region Fields
        private protected Door _frontDoor;
        private protected Door _backDoor;
        private protected Window _oneLayerWindow;
        private protected Window _twoLayerWindow;
        private protected Window _threeLayerWindow;
        private protected Floor _laminatedFloor;
        private protected Kitchen _kitchenOne;
        private protected Kitchen _kitchenTwo;
        private protected Kitchen _kitchenThree;
        private protected Kitchen _kitchenFour;
        private protected Kitchen _kitchenFive;
        private protected Bathroom _bathroom;
        private protected byte _rooms;
        #endregion Fields

        #region Properties
        private protected Door FrontDoor
        {
            get { return _frontDoor; }
            set { _frontDoor = value; }
        }
        private protected Door BackDoor
        {
            get { return _backDoor; }
            set { _backDoor = value; }
        }
        private protected Window OneLayerWindow
        {
            get { return _oneLayerWindow; }
            set { _oneLayerWindow = value; }
        }
        private protected Window TwoLayerWindow
        {
            get { return _twoLayerWindow; }
            set { _twoLayerWindow = value; }
        }
        private protected Window ThreeLayerWindow
        {
            get { return _threeLayerWindow; }
            set { _threeLayerWindow = value; }
        }
        private protected Floor LaminatedFloor
        {
            get { return _laminatedFloor; }
            set { _laminatedFloor = value; }
        }
        private protected Kitchen KitchenOne
        {
            get { return _kitchenOne; }
            set { _kitchenOne = value; }
        }
        private protected Kitchen KitchenTwo
        {
            get { return _kitchenTwo; }
            set { _kitchenTwo = value;}
        }
        private protected Kitchen KitchenThree
        {
            get { return _kitchenThree; }
            set { _kitchenThree = value; }
        }
        private protected Kitchen KitchenFour
        {
            get { return _kitchenFour; }
            set { _kitchenFour = value;}
        }
        private protected Kitchen KitchenFive
        {
            get { return _kitchenFive; }
            set { _kitchenFive = value;}
        }
        private protected Bathroom Bathroom
        {
            get { return _bathroom; }
            set { _bathroom = value; }
        }
        private protected byte Rooms
        {
            get { return _rooms; }
            set { _rooms = value; }
        }
        #endregion Properties
        #region Methods
        internal abstract string Print();
        #endregion Methods
    }
}
