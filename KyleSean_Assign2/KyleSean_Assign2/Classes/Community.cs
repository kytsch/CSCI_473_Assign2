using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleSean_Assign2
{
    /*********************************************************************************
         Community Class

         Community Class that implements the IComparable interface
    *********************************************************************************/

    public class Community : IComparable
    {
        private SortedSet<Property> props;  //SortedSet of Properties that belong to this community
        private SortedSet<Person> residents;  //SortedSet of Person objects that belong to this community
        private readonly uint id;  //Community ID
        private readonly string name;  //Community Name
        private uint mayorID;  //Community Mayor ID Number

        //Default constructor
        public Community()
        {
            props = new SortedSet<Property>();
            residents = new SortedSet<Person>();
            id = 99999;
            name = "";
            mayorID = 0;

        }

        /*********************************************************************************
         Method     : Community
         Purpose    : Full constructor for a Community object 
         Parameters : 1. comProps - SortedSet of Properties belonging to a Community
                      2. resids   - SortedSet of Persons belonging to a Community
                      3. comName  - name of the Community to be used
                      4. mID      - the Mayor ID of the Community
         Returns    : N/A
        *********************************************************************************/
        public Community(SortedSet<Property> comProps, SortedSet<Person> resids, string comName, uint mID)
        {

            props = comProps;
            residents = resids;
            id = 99999;
            name = comName;
            mayorID = mID;

        }

        /*********************************************************************************
         Method     : Community
         Purpose    : Partial constructor for a Community object 
         Parameters : 1. comName  - name of the Community to be used
                      2. mID      - the Mayor ID of the Community
         Returns    : N/A
         *********************************************************************************/
        public Community(string comName, uint mID)
        {

            props = new SortedSet<Property>();
            residents = new SortedSet<Person>();
            id = 99999;
            name = comName;
            mayorID = mID;

        }

        //CompareTo function.
        //This might need to be modified as we start using it, but it should line up with the given example with our context.
        public int CompareTo(Object comm)
        {

            if (comm == null) throw new ArgumentNullException();

            Community rightOp = comm as Community;

            //If the right op was successfully initialized as a community,
            //compare the names of both sides.
            if (rightOp != null)
            {

                return name.CompareTo(rightOp.name);

            }
            //If it was 
            else
            {

                throw new ArgumentException("[Community]: Attempted to compare to an argument that is not a community.");

            }

        }

        // *** Community Class Properties ***
        public SortedSet<Property> Props
        {

            get { return props; }
            set { props = value; }

        }

        public SortedSet<Person> Residents
        {

            get { return residents; }
            set { residents = value; }

        }

        public int Population
        {

            get { return residents.Count; }

        }

        public uint ID
        {

            get { return id; }

        }

        public string Name
        {

            get { return name; }

        }

        public uint MayorID
        {

            get { return mayorID; }

            set { mayorID = value; }

        }

        /*********************************************************************************
         Method     : addProperty
         Purpose    : Add a property using a complete property object
         Parameters : 1. newProperty - a Property object to be added to the Properties 
                                        SortedSet
         Returns    : N/A
        *********************************************************************************/

        public void addProperty(Property newProperty)
        {

            props.Add(newProperty);

        }

        /*********************************************************************************
         Method     : addResident
         Purpose    : Add a resident using a complete Person object
         Parameters : 1. newResident - a Person object that will be added to the Person 
                                        SortedSet
         Returns    : N/A
        *********************************************************************************/

        public void addResident(Person newResident)
        {

            residents.Add(newResident);

        }

        /*********************************************************************************
         Method     : populate
         Purpose    : Read the Person file and populate the Person SortedSet to be used 
                       throughout the program
         Parameters : 1. fileName - the name of the file to be read
                      2. ids - Dictionary of used ID numbers
         Returns    : N/A
        *********************************************************************************/

        public void populate(string fileName, Dictionary<uint, uint> ids)
        {

            string input;
            using (StreamReader inFile = new StreamReader(fileName))
            {

                input = inFile.ReadLine();

                while (input != null)
                {

                    string[] args = input.Split('\t');

                    UInt32 newId = Convert.ToUInt32(args[0]);

                    if (ids.ContainsKey(newId))
                    {

                        Console.WriteLine("[Person] The id " + newId + " is already in use.");

                    }
                    else
                    {

                        Person newResident = new Person(args, ids);

                        residents.Add(newResident);

                        ids.Add(newId, newId);

                    }

                    input = inFile.ReadLine();

                }

            }

        }

    }

}
