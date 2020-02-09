using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleSean_Assign2
{

    /*********************************************************************************
         Property Class

         One of the most important classes of the program. The property class will have
          many classes derived from it to be able to create Houses, Apartments, and Communities
    *********************************************************************************/
    public abstract class Property : IComparable
    {
        private readonly uint propID;  //unique identifier for each Property
        private uint ownerID;  //ID of the Person who owns this Property
        private readonly uint x;
        private readonly uint y;
        private string streetAddr;  //Street Address of the Property
        private string city;  //City of the Property
        private string state;  //State of the Property
        private string zip;  //ZIP of the Property
        private bool forSale;  //is the house for sale or not?

        // *** Property Class Properties ***
        public uint PropID
        {
            get { return propID; }
            set { }
        }
        public uint OwnerID
        {
            get { return ownerID; }
            set { ownerID = value; }
        }

        public uint X
        {
            get { return x; }
            set { }
        }

        public uint Y
        {
            get { return y; }
            set { }
        }

        public string StreetAddr
        {
            get { return streetAddr; }
            set { streetAddr = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public bool ForSale
        {
            get { return forSale; }
            set { forSale = value; }
        }

        //Default constructor for Property class
        public Property()
        {
            //Initialize all unsigned integer Property attributes to a default of 0
            ownerID = propID = x = y = 0;

            //Initialize all string Property attributes to a default value of "" 
            streetAddr = city = state = zip = "";

            //Initialize forSale attribute to false. A blank property cannot be sold. 
            forSale = false;
        }

        /*********************************************************************************
         Method     : Property
         Purpose    : Constructor for the Property class. Initializes all attributes
                       to the values that are passed in 
         Parameters : 1. newPropID
                      2. newOwnerID
                      3. newX
                      4. newY
                      5. newStreetAddr
                      6. newCity
                      7. newState
                      8. newZip
                      9. newIsForSale
         Returns    : N/A
        *********************************************************************************/
        public Property(uint newPropID, uint newOwnerID, uint newX, uint newY, string newStreetAddr, string newCity,
                        string newState, string newZip, string isForSale)
        {
            //Initialize all Property attributes to the values that have been passed in 
            propID = newPropID;
            ownerID = newOwnerID;
            x = newX;
            y = newY;
            streetAddr = newStreetAddr;
            city = newCity;
            state = newState;
            zip = newZip;

            //Check if isForSale has passes a "T" for true
            if (isForSale == "T" || isForSale == "t")
            {
                forSale = true;
            }
            //If isForSale is not equal to "T", then it is considered false
            else
            {
                forSale = false;
            }
        }

        /*********************************************************************************
         Method     : CompareTo
         Purpose    : Overloaded Compare to implemented with the IComparable interface to 
                       sort properties on their State, City, Street, Street #. (Also by
                       Unit for Apartment objects)
         Parameters : 1. alpha - a Property object to be compared 
         Returns    : an integer representing the result of the comparison
        *********************************************************************************/
        public int CompareTo(object alpha)
        {
            int k; //int to hold return value

            if (alpha == null) throw new ArgumentNullException();

            Property rightOp = alpha as Property;

            if (rightOp != null)
            {

                k = state.CompareTo(rightOp.state); //Compare the object's State values

                if (k != 0)
                    return k;  //if states not equal, return result
                else
                {
                    k = city.CompareTo(rightOp.city);  //Compare the object's City values 

                    if (k != 0)
                    {
                        return k;  //If Cities not equal, return result
                    }
                    else
                    {
                        string streetName1 = streetAddr.Split(' ')[1];
                        string streetName2 = rightOp.streetAddr.Split(' ')[1];

                        k = streetName1.CompareTo(streetName2);  //compare the object's street name values

                        if (k != 0)
                        {
                            return k;   //if street names not equal, return result
                        }
                        else
                        {
                            string streetNum1 = streetAddr.Split(' ')[0];
                            string streetNum2 = rightOp.streetAddr.Split(' ')[0];

                            //Check if the objects are apartments
                            if (streetNum1.CompareTo(streetNum2) == 0 && alpha.GetType() == typeof(Apartment) && rightOp.GetType() == typeof(Apartment))
                            {

                                Apartment tempAp1 = this as Apartment;
                                Apartment tempAp2 = rightOp as Apartment;

                                return tempAp1.Unit.CompareTo(tempAp2.Unit);  //Return result of Unit value comparison

                            }

                            else
                                return streetNum1.CompareTo(streetNum2); //return result of street number comparison


                        }
                    }
                }
            }
            else
                throw new ArgumentException("[Property]:CompareTo argument is not a Property");
        }

        public override string ToString()
        {

            return streetAddr;

        }

    }
}
