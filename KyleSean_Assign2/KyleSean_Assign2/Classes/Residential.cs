using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleSean_Assign2
{

    /*********************************************************************************
         Residential Class

         Derived from the Property class
    *********************************************************************************/
    public abstract class Residential : Property
    {
        private uint bedrooms;  //number of bedrooms in the property
        private uint baths;  //number of baths in the property
        private uint sqft;  //Square Footage of the property

        // *** Residential Class Properties ***
        public uint Bedrooms
        {
            get { return bedrooms; }
            set { bedrooms = value; }
        }

        public uint Baths
        {
            get { return baths; }
            set { baths = value; }
        }

        public uint Sqft
        {
            get { return sqft; }
            set { sqft = value; }
        }

        //Default Constructor for the Residential class
        public Residential() : base()
        {
            //Initialize all unsigned integer Residential attributes to a default value of 0. Also call the base default
            //constructor for Property to initialize to default values
            bedrooms = baths = sqft = 0;
        }

        /*********************************************************************************
         Method     : Residential
         Purpose    : Constructor for the Residential class. Initializes Residentail
                       attributes and passes all other arguments to the base constructor 
                       for this class, Property
         Parameters : 1. newBedrooms
                      2. newBaths
                      3. newSqft
                      4. newPropID
                      5. newOwnerID
                      6. newX
                      7. newY
                      8. newStreetAddr
                      9. newCity
                     10. newState
                     11. newZip
                     12. newIsForSale
         Returns    : N/A
        *********************************************************************************/
        public Residential(uint newBedrooms, uint newBaths, uint newSqft, uint newPropID, uint newOwnerID, uint newX,
                           uint newY, string newStreetAddr, string newCity, string newState, string newZip,
                           string isForSale) : base(newPropID, newOwnerID, newX, newY, newStreetAddr, newCity, newState,
                           newZip, isForSale)
        {
            //Initialize all unsigned integer Residential attributes to the values passed as arguments
            bedrooms = newBedrooms;
            baths = newBaths;
            sqft = newSqft;
        }

    }

}
