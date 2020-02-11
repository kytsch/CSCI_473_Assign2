using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyleSean_Assign2
{
    public partial class Form1 : Form
    {
        Dictionary<uint, uint> ids = new Dictionary<uint, uint>();
        Community DeKalb = new Community("DeKalb", 0);
        Community Sycamore = new Community("Sycamore", 0);

        public Form1()
        {
            InitializeComponent();

            //Read the DeKalb and Sycamore house, apartment, and person files
            readApartmentFile(DeKalb, "DeKalb", "a.txt");
            readHouseFile(DeKalb, "DeKalb", "r.txt", ids);
            readPersonFile(DeKalb, "DeKalb", "p.txt");
            readApartmentFile(Sycamore, "Sycamore", "a.txt");
            readHouseFile(Sycamore, "Sycamore", "r.txt", ids);
            readPersonFile(Sycamore, "Sycamore", "p.txt");

            dekalb_radio_button.Checked = true;

        }

        /*********************************************************************************
         Method     : readApartmentFile
         Purpose    : Read in the Apartment file and populate the Properties SortedSet with
                       Apartment objects
         Parameters : 1. comm - Community object have Apartment objects added to it
                      2. dir  - string representing the directory from which to read the file
                      3. file - string representing the name of the file to read
         Returns    : N/A
        *********************************************************************************/

        public static void readApartmentFile(Community comm, string dir, string file)
        {
            string input;
            uint inPropID;
            uint inOwnerID;
            uint inX;
            uint inY;
            string inStreetAddr;
            string inCity;
            string inState;
            string inZip;
            string inForSale;
            uint inBedrooms;
            uint inBaths;
            uint inSqft;
            string inUnit;

            using (StreamReader inFile = new StreamReader("../../" + dir + "/" + file))
            {
                input = inFile.ReadLine();  //priming read

                //read until EOF
                while (input != null)
                {

                    //Split the input string into the fields that will be passed to the Apartment constructor
                    inPropID = Convert.ToUInt32(input.Split('\t')[0], 10);
                    inOwnerID = Convert.ToUInt32(input.Split('\t')[1], 10);
                    inX = Convert.ToUInt32(input.Split('\t')[2], 10);
                    inY = Convert.ToUInt32(input.Split('\t')[3], 10);
                    inStreetAddr = input.Split('\t')[4];
                    inCity = input.Split('\t')[5];
                    inState = input.Split('\t')[6];
                    inZip = input.Split('\t')[7];
                    inForSale = input.Split('\t')[8];
                    inBedrooms = Convert.ToUInt32(input.Split('\t')[9], 10);
                    inBaths = Convert.ToUInt32(input.Split('\t')[10], 10);
                    inSqft = Convert.ToUInt32(input.Split('\t')[11], 10);
                    inUnit = input.Split('\t')[12];

                    //Create a temporary Apartment object to be added to the Property SortedSet that has been passed in
                    Apartment tempApartment = new Apartment(inPropID, inOwnerID, inX, inY, inStreetAddr, inCity, inState, inZip, inForSale, inBedrooms,
                                                inBaths, inSqft, inUnit);

                    //Add temporary Apartment object to the Property SortedSet
                    comm.Props.Add(tempApartment);

                    input = inFile.ReadLine();  //read next line
                }
            }
        }

        /*********************************************************************************
         Method     : readHouseFile
         Purpose    : Read in the House file and populate the allProperties SortedSet with
                       House objects
         Parameters : 1. comm - A Community object to add House objects to
                      2. dir  - string representing the directory from which to read the file
                      3. file - string representing the name of the file to read
         Returns    : N/A
        *********************************************************************************/

        public static void readHouseFile(Community comm, string dir, string file, Dictionary<uint, uint> ids)
        {
            string input;

            uint inUnitID;
            uint inOwnerID;
            uint inX;
            uint inY;
            string inStreetAddr;
            string inCity;
            string inState;
            string inZip;
            string inForSale;
            uint inBedrooms;
            uint inBaths;
            uint inSqft;
            string inIsGarage;
            string inIsAttachedGarage;
            uint inFloors;

            using (StreamReader inFile = new StreamReader("../../" + dir + "/" + file))
            {
                input = inFile.ReadLine();  //priming read

                //read until EOF
                while (input != null)
                {
                    inUnitID = Convert.ToUInt32(input.Split('\t')[0], 10);

                    if (ids.ContainsKey(inUnitID))
                    {

                        //throw new System.Exception("[Reading house file]: the ID #" + inUnitID + " is already in use.");

                    }

                    Console.WriteLine("I should not print after exception");

                    //Split the input string into the fields that will be passes to the House constructor
                    inOwnerID = Convert.ToUInt32(input.Split('\t')[1], 10);
                    inX = Convert.ToUInt32(input.Split('\t')[2], 10);
                    inY = Convert.ToUInt32(input.Split('\t')[3], 10);
                    inStreetAddr = input.Split('\t')[4];
                    inCity = input.Split('\t')[5];
                    inState = input.Split('\t')[6];
                    inZip = input.Split('\t')[7];
                    inForSale = input.Split('\t')[8];
                    inBedrooms = Convert.ToUInt32(input.Split('\t')[9], 10);
                    inBaths = Convert.ToUInt32(input.Split('\t')[10], 10);
                    inSqft = Convert.ToUInt32(input.Split('\t')[11], 10);
                    inIsGarage = input.Split('\t')[12];
                    inIsAttachedGarage = input.Split('\t')[13];
                    inFloors = Convert.ToUInt32(input.Split('\t')[14], 10);

                    //Create a temporary House object to be added to the Property SortedSet that has been passed in
                    House tempHouse = new House(inUnitID, inOwnerID, inX, inY, inStreetAddr, inCity, inState, inZip, inForSale, inBedrooms,
                                                inBaths, inSqft, inIsGarage, inIsAttachedGarage, inFloors);

                    //Add temporary House object to the Properties SortedSet
                    comm.Props.Add(tempHouse);

                    //Add id to the dictionary
                    ids.Add(inUnitID, inUnitID);

                    input = inFile.ReadLine();  //read next line 
                }
            }
        }

        /*********************************************************************************
         Method     : populate
         Purpose    : Read the Person file and populate the Person SortedSet to be used 
                       throughout the program
         Parameters : 1. fileName - the name of the file to be read
         Returns    : N/A
        *********************************************************************************/

        public void readPersonFile(Community comm, string dir, string file)
        {

            string input;
            using (StreamReader inFile = new StreamReader("../../" + dir + "/" + file))
            {

                input = inFile.ReadLine();

                while (input != null)
                {

                    string[] args = input.Split('\t');

                    Person newResident = new Person(args, ids);

                    comm.Residents.Add(newResident);

                    input = inFile.ReadLine();

                }

            }

        }

        private void fuckoff(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void output_label_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dekalb_radio_button_CheckedChanged(object sender, EventArgs e)
        {

            if(dekalb_radio_button.Checked == true) { 

                output_listbox.Items.Add("The residents and properties of DeKalb are now listed.");

                residence_listbox.Items.Clear();  //reset the text so only DeKalb Properties will be listed

                residence_listbox.Items.Add("Houses:");
                residence_listbox.Items.Add("----------------");

                foreach (Property prop in DeKalb.Props)
                {

                    //check if the property object is a House
                    if (prop.GetType() == typeof(House))
                    {
                        House tempHouse = prop as House;  //typecast prop as a House object

                        if (tempHouse != null)  //protect against failed typecast
                        {

                            residence_listbox.Items.Add(tempHouse);  //utilize overloaded ToString to directly add tempHouse to residence listbox

                        }
                        else
                        {
                            throw new ArgumentException("[Property]: argument is not a House.");
                        }
                    }
                }

                residence_listbox.Items.Add("");
                residence_listbox.Items.Add("Apartments:");
                residence_listbox.Items.Add("----------------");

                foreach (Property prop in DeKalb.Props)
                {

                    //Only print the Apartment objects in the DeKalb Properties
                    if (prop.GetType() == typeof(Apartment))
                    {
                        Apartment tempApt = prop as Apartment;  //typecast Property as an Apartment object

                        if (tempApt != null)  //protect against failed typecast
                        {

                            residence_listbox.Items.Add(tempApt);  //utilize ToString to add tempApt directly to residence listbox

                        }
                        else
                        {
                            throw new ArgumentException("[Property]: argument is not an Apartment.");
                        }
                    }
                }

                person_listbox.Items.Clear();  //reset text so only the desired Communities residents are displayed

                //loop through each resident that lives in DeKalb
                foreach (Person res in DeKalb.Residents)
                {

                    person_listbox.Items.Add(res);  //utiilize ToString to add res directly to person listbox

                }

            }

        }

        private void sycamore_radio_button_Click(object sender, EventArgs e)
        {
            output_listbox.Items.Add("The residents and properties of Sycamore are now listed.");

            residence_listbox.Items.Clear(); //reset the text so only Sycamore Properties will be listed

            residence_listbox.Items.Add("Houses:");
            residence_listbox.Items.Add("----------------");

            //loop through each Property in the Sycamore Community
            foreach (Property prop in Sycamore.Props)
            {

                //check if the Property is a House
                if (prop.GetType() == typeof(House))
                {
                    House tempHouse = prop as House;  //typecast the Property as a House

                    if (tempHouse != null)  //protect against failed typecast
                    {

                        residence_listbox.Items.Add(tempHouse);  //utilize overloaded ToString to add tempHouse directly to residence listbox

                    }
                    else
                    {
                        throw new ArgumentException("[Property]: argument is not a House.");
                    }
                }
            }

            residence_listbox.Items.Add("");
            residence_listbox.Items.Add("Apartments:");
            residence_listbox.Items.Add("----------------");

            //loop through Properties in the Sycamore Community
            foreach (Property prop in Sycamore.Props)
            {

                //check if the property is an Apartment 
                if (prop.GetType() == typeof(Apartment))
                {
                    Apartment tempApt = prop as Apartment;  //typecast the property as an Apartment 

                    if (tempApt != null)   //protect against failed typecast
                    {

                        residence_listbox.Items.Add(tempApt);  //utilize overloaded ToString to directly add tempApt to residence listbox

                    }
                    else
                    {
                        throw new ArgumentException("[Property]: argument is not an Apartment.");
                    }
                }
            }

            person_listbox.Items.Clear();  //reset text so only the desired Communities residents are displayed

            foreach (Person res in Sycamore.Residents)
            {

                person_listbox.Items.Add(res);  //utilize overloaded ToString to directly add res to person listbox

            }
        }


        private void toggle_for_sale_button_Click(object sender, EventArgs e)
        {

            //Make sure that something has actually been selected
            if(residence_listbox.SelectedItem != null)
            {

                Property prop = residence_listbox.SelectedItem as Property;

                prop.ForSale = !prop.ForSale;

                int index = residence_listbox.Items.IndexOf(residence_listbox.SelectedItem);

                residence_listbox.Items.RemoveAt(index);

                residence_listbox.Items.Insert(index, prop);

                residence_listbox.SelectedIndex = index;

                /*
                if (residence_listbox.SelectedItem.ToString().Length > 30)
                {
                    
                    string notForSaleString = residence_listbox.SelectedItem.ToString().Substring(0, 29);

                    int index = residence_listbox.Items.IndexOf(residence_listbox.SelectedItem);

                    residence_listbox.Items.RemoveAt(index);

                    residence_listbox.Items.Insert(index, notForSaleString);

                    

            }
            else
                {

                    

                }
            */
            }
            else
            {

                output_listbox.Items.Add("No residence is currently selected");

            }

        }

        private void person_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person anon = person_listbox.SelectedItem as Person;  //typecast the selected item as a Person 

            if (anon != null)  //protect against failed typecast
            {

                output_listbox.Items.Clear();  //clear the output listbox of any other output previously shown

                //display basic person information
                output_listbox.Items.Add(String.Format("{0}, {1}, Age ({2}), Occupation: {3}, who resides at:", anon.LastName, anon.FirstName,
                                         (DateTime.Now.Year - anon.Birthday.Year), anon.Occupation));

                //if DeKalb Community selected, loop through the persons residence ids first, then loop through the Properties to
                //find a match. When found, list the address of the property
                if (dekalb_radio_button.Checked)
                {
                    foreach (uint id in anon.ResidenceIds)
                    {

                        foreach (Property prop in DeKalb.Props)
                        {
                            if (id == prop.PropID)
                            {
                                output_listbox.Items.Add(String.Format("{0, 8}{1, -20}", "", prop.StreetAddr));
                            }
                        }
                    }
                }

                //else if the Sycamore Community selected, loop through the persons residence ids first, then loop through the Properties to
                //find a match. When found, list the address of the property
                else if (sycamore_radio_button.Checked)
                {
                    foreach (uint id in anon.ResidenceIds)
                    {

                        foreach (Property prop in Sycamore.Props)
                        {
                            if (id == prop.PropID)
                            {
                                output_listbox.Items.Add(String.Format("{0, 8}{1, -20}", "", prop.StreetAddr));
                            }
                        }
                    }
                }
                else  //if a community is somehow not selected
                {
                    MessageBox.Show("You must have a Community selected.");
                }

                output_listbox.Items.Add("");
                output_listbox.Items.Add("### END OF OUTPUT ###");
            }
        }
    }
}
