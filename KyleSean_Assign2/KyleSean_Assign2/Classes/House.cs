using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleSean_Assign2
{
    /*********************************************************************************
         House Class

         Derived from the Residential and Property classes
    *********************************************************************************/
    public class House : Residential
    {
        private bool garage;  //bool representing if there is a garage or not
        private Nullable<bool> attachedGarage;  //nullable bool representing an attached garage or not
        private uint floors;  //number of floors in the property

        // *** House Class Properties ***
        public bool Garage
        {
            get { return garage; }
            set { garage = value; }
        }

        public Nullable<bool> AttachedGarage
        {
            get { return attachedGarage; }
            set { attachedGarage = value; }
        }

        public uint Floors
        {
            get { return floors; }
            set { floors = value; }
        }

        //Default House Constructor
        public House() : base()
        {
            //Initialize all House attributes to default values and call the base default constructor of Residential to 
            //initialize all Residentail and Property attributes
            garage = false;
            attachedGarage = null;
            floors = 0;
        }

        /*********************************************************************************
         Method     : House
         Purpose    : Constructor for the House class. Initializes House attributes and
                       passes all other arguments to the base constructor for this class,
                       Residential
         Parameters : 1. newPropID
                      2. newOwnerID
                      3. newX
                      4. newY
                      5. newStreetAddr
                      6. newCity
                      7. newState
                      8. newZip
                      9. newIsForSale
                     10. newBedrooms
                     11. newBaths
                     12. newSqft
                     13. isGarage
                     14. isAttachedGarage
                     15. newFloors
         Returns    : N/A
        *********************************************************************************/
        public House(uint newPropID, uint newOwnerID, uint newX, uint newY, string newStreetAddr, string newCity,
                     string newState, string newZip, string isForSale, uint newBedrooms, uint newBaths, uint newSqft,
                     string isGarage, string isAttachedGarage, uint newFloors) : base(newBedrooms, newBaths, newSqft,
                     newPropID, newOwnerID, newX, newY, newStreetAddr, newCity, newState, newZip, isForSale)
        {
            //Check if isGarage value passes a "T" for true 
            if (isGarage == "T" || isGarage == "t")
            {
                garage = true;
            }
            //If isGarage is not equal to "T", then it is considered false 
            else
            {
                garage = false;
            }

            //Check if the house has a garage. If true, check if the garage is attached to the house 
            if (Garage == true)
            {
                //If garage is equal to true, check if isAttachedGarage is equal to "T" 
                if (isAttachedGarage == "T" || isAttachedGarage == "t")
                {
                    attachedGarage = true;
                }
                //If isAttachedgarage is not equal to "T", then it is considered false 
                else
                {
                    attachedGarage = false;
                }
            }
            //If the house does not have a garage, there is no way for it to be attached or not attached. Set to null to represent this situation.
            else
            {
                attachedGarage = null;
            }

            floors = newFloors;
        }

    }

}
