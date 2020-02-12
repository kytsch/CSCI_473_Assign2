using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleSean_Assign2
{
    /*********************************************************************************
         Person Class

         Person class that implements the IComparable interface to be able to sort by
          full name
    *********************************************************************************/
    public class Person : IComparable
    {

        private readonly uint id;  //Unique identifier for a specific Person
        private string firstName;  //...we know what these two are
        private string lastName;
        private string occupation;  //Person's occupation
        private readonly DateTime birthday;
        private List<uint> residenceIds;  //ID representing where this person lives

        //Default constructor
        public Person()
        {

            id = 0;
            firstName = "";
            lastName = "";
            occupation = "";
            birthday = DateTime.Now;

        }
        /*********************************************************************************
         Method     : Person
         Purpose    : Full constructor for a Person object
         Parameters : 1. args - an array of strings containing the information to populate 
                                 a Person object 
         Returns    : N/A
        *********************************************************************************/
        public Person(string[] args, Dictionary<uint, uint> ids)
        {

            id = Convert.ToUInt32(args[0]);

            lastName = args[1];

            firstName = args[2];

            occupation = args[3];

            birthday = new DateTime(Convert.ToInt32(args[4]), Convert.ToInt32(args[5]), Convert.ToInt32(args[6]));

            List<uint> baseResId = new List<uint>();

            baseResId.Add(Convert.ToUInt32(args[7]));

            residenceIds = baseResId;

            ids.Add(id, id);

        }

        /*********************************************************************************
         Method     : Person (form constructor)
         Purpose    : Full constructor for a Person object that is more intuitive for the
                      form input.
         Parameters : 1. newId
                      2. newFirstName
                      3. newLastName
                      4. newOccupation
                      5. newBirthday
                      6. newResidenceIds
         Returns    : N/A
        *********************************************************************************/
        public Person(uint newId, string newFirstName, string newLastName, string newOccupation, DateTime newBirthday, List<uint>newResidenceIds)
        {

            id = newId;
            firstName = newFirstName;
            lastName = newLastName;
            occupation = newOccupation;
            birthday = newBirthday;
            residenceIds = newResidenceIds;

    }

        // *** Person Class Properties ***
        public uint Id
        {
            get { return id; }
            set { }
        }

        public string FirstName
        {

            get { return firstName; }

            set { firstName = value; }

        }

        public string LastName
        {

            get { return lastName; }

            set { lastName = value; }

        }

        public string Occupation
        {

            get { return occupation; }

            set { occupation = value; }

        }

        public DateTime Birthday
        {

            get { return birthday; }

        }

        public List<uint> ResidenceIds
        {

            get { return residenceIds; }

        }

        //Full name property that concatenates the person's first and last names
        public string FullName
        {

            get { return firstName + " " + lastName; }

        }

        //String override for the Person class
        public override string ToString()
        {

            if (this.Occupation.Length < 13)
            {
                return String.Format("{0,-10} {1,-3} {2,-13}", this.FirstName, (DateTime.Now.Year - this.Birthday.Year), this.Occupation);
            }
            else  //if the residents occupation is long, shorten it
            {
                string substr = this.Occupation.Substring(0, 12);  //get shortened occupation for output

                //use shortened occupation and formatting
                return String.Format("{0,-10} {1,-3} {2,-13}", this.FirstName, (DateTime.Now.Year - this.Birthday.Year), substr + "...");
            }

        }

        /*********************************************************************************
         Method     : CompareTo
         Purpose    : Overloaded CompareTo implemented with the IComparable interface to 
                       sort Person objects based on their name
         Parameters : 1. alpha - a Person object to be compared 
         Returns    : an integer representing the result of the comparison
         *********************************************************************************/
        public int CompareTo(Object resident)
        {

            if (resident == null) throw new ArgumentNullException();

            Person rightOp = resident as Person;

            if (rightOp != null)
            {

                int comparison = this.lastName.CompareTo(rightOp.lastName);

                if (comparison == 0)
                {

                    return this.firstName.CompareTo(rightOp.firstName);

                }
                else
                    return comparison;

            }
            else
            {

                throw new ArgumentException("[Person]: Attempted to compare to an argument that is not a person.");

            }

        }

    }

}
