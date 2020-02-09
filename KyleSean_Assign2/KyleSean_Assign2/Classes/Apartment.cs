using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleSean_Assign2
{
    /*********************************************************************************
         Apartment Class

         Derived from the Residential and Property classes
    *********************************************************************************/

    public class Apartment : Residential
    {
        private string unit;  //Unit ID for the Apartment 

        // *** Apartment Class Properties ***
        public string Unit
        {
            set { unit = value; }
            get { return unit; }
        }

        //Default Constructor 
        public Apartment()
        {
            unit = "";
        }

        /*********************************************************************************
         Method     : Apartment
         Purpose    : Constructor for the Apartment class. Initializes unit attribute and
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
                      13. newUnit
         Returns    : N/A
        *********************************************************************************/

        public Apartment(uint newPropID, uint newOwnerID, uint newX, uint newY, string newStreetAddr, string newCity, string newState,
                         string newZip, string newIsForSale, uint newBedrooms, uint newBaths, uint newSqft, string newUnit) : base(newBedrooms,
                         newBaths, newSqft, newPropID, newOwnerID, newX, newY, newStreetAddr, newCity, newState, newZip, newIsForSale)
        {
            unit = newUnit;
        }

        public override string ToString()
        {

            return this.StreetAddr + ", apt. " + unit;

        }

    }

}
