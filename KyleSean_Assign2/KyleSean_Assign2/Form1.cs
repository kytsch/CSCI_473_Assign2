﻿using System;
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

        /*********************************************************************************
         Method     : populatePersonListBox
         Purpose    : Populates the listbox that displays people with residents from
                      the currently-selected community
         Parameters : N/A
         Returns    : N/A
        *********************************************************************************/
        private void populatePersonListBox()
        {

            if (sycamore_radio_button.Checked == true)
            {

                foreach (Person res in Sycamore.Residents)
                {

                    person_listbox.Items.Add(res);  //utilize overloaded ToString to directly add res to person listbox

                }

            }
            else
            {

                foreach (Person res in DeKalb.Residents)
                {

                    person_listbox.Items.Add(res);  //utilize overloaded ToString to directly add res to person listbox

                }

            }


        }

        /*********************************************************************************
         Method     : populateResidenceListBox
         Purpose    : Populates the listbox that displays residences with properties from
                      the currently-selected community
         Parameters : N/A
         Returns    : N/A
        *********************************************************************************/
        private void populateResidenceListBox()
        {

            residence_listbox.Items.Add("Houses:");
            residence_listbox.Items.Add("----------------");

            if (sycamore_radio_button.Checked == true)
            {

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


            }
            else
            {


                //loop through each Property in the Sycamore Community
                foreach (Property prop in DeKalb.Props)
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

                //loop through Properties in the DeKalb Community
                foreach (Property prop in DeKalb.Props)
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


            }

        }

        /*********************************************************************************
         Method     : populateNewResidentComboBox
         Purpose    : Takes the property list from the currently-selected community and
                      populates the new resident listbox's combobox with it
         Parameters : N/A
         Returns    : N/A
        *********************************************************************************/
        private void populateNewResidentComboBox()
        {

            //Populate the combobox with DeKalb properties if the DeKalb radio button is active.
            if (dekalb_radio_button.Checked == true)
            {

                //Get each property from the DeKalb property list and add them to the combobox.
                foreach (Property prop in DeKalb.Props)
                {

                    new_resident_residence_comboBox.Items.Add(prop);

                }

            }
            //Populate the combobox with Sycamore properties if the Sycamore radio button is active.
            //Using this instead of else for the case where neither radio button is active.
            else if (sycamore_radio_button.Checked == true)
            {

                //Get each property from the Sycamore property list and add them to the combobox.
                foreach (Property prop in Sycamore.Props)
                {

                    new_resident_residence_comboBox.Items.Add(prop);

                }

            }

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


                person_listbox.Items.Clear();  //reset text so only the desired Communities residents are displayed
                residence_listbox.Items.Clear(); //reset the text so only Sycamore Properties will be listed
                new_resident_residence_comboBox.Items.Clear();

                //Repopulate list and comboboxes with DeKalb properties
                populatePersonListBox();
                populateResidenceListBox();
                populateNewResidentComboBox();

                output_listbox.Items.Add("The residents and properties of DeKalb are now listed.");


            }

        }

        private void sycamore_radio_button_CheckedChanged(object sender, EventArgs e)
        {

            if (sycamore_radio_button.Checked == true)
            {


                person_listbox.Items.Clear();  //reset text so only the desired Community's residents are displayed
                residence_listbox.Items.Clear(); //reset the text so only Sycamore Properties will be listed
                new_resident_residence_comboBox.Items.Clear(); //Reset new resident combobox

                //Repopulate list and comboboxes with Sycamore properties
                populatePersonListBox();
                populateResidenceListBox();
                populateNewResidentComboBox();

                output_listbox.Items.Add("The residents and properties of Sycamore are now listed.");

            }

        }

        private void sycamore_radio_button_Click(object sender, EventArgs e)
        {
            output_listbox.Items.Add("The residents and properties of Sycamore are now listed.");

            residence_listbox.Items.Clear(); //reset the text so only Sycamore Properties will be listed

            residence_listbox.Items.Add("Houses:");
            residence_listbox.Items.Add("----------------");

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

                //Typecast selected item as a property
                Property prop = residence_listbox.SelectedItem as Property;

                //Flip for-sale status
                prop.ForSale = !prop.ForSale;

                //Get the index of the selected item
                int index = residence_listbox.Items.IndexOf(residence_listbox.SelectedItem);

                //Remove selected item
                residence_listbox.Items.RemoveAt(index);

                //Re-insert item so it shows the proper (not) for-sale string
                residence_listbox.Items.Insert(index, prop);

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
            //Catch if a property is not selected
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
            else
            {
                throw new ArgumentException("[Person]: argument is not a Person.");
            }
        }

        private void residence_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            output_listbox.Items.Clear();

            //Check if DeKalb Community is selected
            if (dekalb_radio_button.Checked)
            {

                //check if the selected item is a House
                if (residence_listbox.SelectedItem.GetType() == typeof(House))
                {
                    House tempHouse = residence_listbox.SelectedItem as House;  //typecast selected item as a House

                    if(tempHouse != null)  //protect against failed typecasting
                    {
                        
                        //loop through each person in the DeKalb Community to find the correct owner of the property and display the House information
                        foreach(Person anon in DeKalb.Residents)
                        {
                            if(tempHouse.OwnerID == anon.Id)
                            {

                                output_listbox.Items.Add(String.Format("Residents living at {0}, {1}, owned by {2}, {3}:", tempHouse.StreetAddr, tempHouse.City,
                                                                                                                            anon.LastName, anon.FirstName));
                                output_listbox.Items.Add("----------------------------------------------------------------------");
                            }
                        }

                        //loop through each person in the DeKalb Community to find who lives at this property
                        foreach(Person anon in DeKalb.Residents)
                        {

                            //loop through the persons residence IDs
                            foreach(uint id in anon.ResidenceIds)
                            {

                                //if the person has an ID that matches the property ID, list them as a resident
                                if(id == tempHouse.PropID)
                                {

                                    //format the first and last name for the output listbox
                                    string formatName = String.Format("{0}, {1}", anon.LastName, anon.FirstName);

                                    output_listbox.Items.Add(String.Format("{0,-27}{1,3}{2,30}", formatName, (DateTime.Now.Year - anon.Birthday.Year), anon.Occupation));
                                }
                            }
                        }

                        output_listbox.Items.Add("");
                        output_listbox.Items.Add("### END OF OUTPUT ###");
                    }
                    else
                    {
                        throw new ArgumentException("[House]: argument is not an House.");
                    }
                }

                //check if the selected item is an Apartment 
                else if (residence_listbox.SelectedItem.GetType() == typeof(Apartment))
                {

                    Apartment tempApt = residence_listbox.SelectedItem as Apartment;  //typecast selected item as an Apartment

                    if (tempApt != null)  //protect against failed typecasting
                    {

                        //loop through each person in the DeKalb Community to find the correct owner of the Apartment and display the Apartment information
                        foreach (Person anon in DeKalb.Residents)
                        {
                            if (tempApt.OwnerID == anon.Id)
                            {

                                output_listbox.Items.Add(String.Format("Residents living at {0} # {1}, {2}, owned by {3}, {4}:", tempApt.StreetAddr, tempApt.Unit, tempApt.City,
                                                                                                                            anon.LastName, anon.FirstName));
                                output_listbox.Items.Add("----------------------------------------------------------------------");
                            }
                        }

                        //loop through each person in the DeKalb Community to find who lives at this property
                        foreach (Person anon in DeKalb.Residents)
                        {

                            //loop through the persons residence IDs
                            foreach (uint id in anon.ResidenceIds)
                            {

                                //if the person has an ID that matches the property ID, list them as a resident
                                if (id == tempApt.PropID)
                                {

                                    //format the first and last name for the output listbox
                                    string formatName = String.Format("{0}, {1}", anon.LastName, anon.FirstName);

                                    output_listbox.Items.Add(String.Format("{0,-27}{1,3}{2,30}", formatName, (DateTime.Now.Year - anon.Birthday.Year), anon.Occupation));
                                }
                            }
                        }

                        output_listbox.Items.Add("");
                        output_listbox.Items.Add("### END OF OUTPUT ###");
                    }
                    else
                    {
                        throw new ArgumentException("[House]: argument is not an House.");
                    }
                }
                else  //user may have selected a header or blank line.
                {
                    return;
                }
            }

            //Check if Sycamore Community is selected 
            else if(sycamore_radio_button.Checked)
            {

                //check if the selected item is a House
                if (residence_listbox.SelectedItem.GetType() == typeof(House))
                {

                    House tempHouse = residence_listbox.SelectedItem as House;  //typecast selected item as a House

                    if (tempHouse != null)  //protect against failed typecasting
                    {

                        //loop through each person in the Sycamore Community to find the correct owner of the property and display the House information
                        foreach (Person anon in Sycamore.Residents)
                        {
                            if (tempHouse.OwnerID == anon.Id)
                            {

                                output_listbox.Items.Add(String.Format("Residents living at {0}, {1}, owned by {2}, {3}:", tempHouse.StreetAddr, tempHouse.City,
                                                                                                                            anon.LastName, anon.FirstName));
                                output_listbox.Items.Add("----------------------------------------------------------------------");
                            }
                        }

                        //loop through each person in the Sycamore Community to find who lives at this property
                        foreach (Person anon in Sycamore.Residents)
                        {

                            //loop through the persons residence IDs
                            foreach (uint id in anon.ResidenceIds)
                            {

                                //if the person has an ID that matches the property ID, list them as a resident
                                if (id == tempHouse.PropID)
                                {

                                    //format the first and last name for the output listbox
                                    string formatName = String.Format("{0}, {1}", anon.LastName, anon.FirstName);

                                    output_listbox.Items.Add(String.Format("{0,-27}{1,3}{2,30}", formatName, (DateTime.Now.Year - anon.Birthday.Year), anon.Occupation));
                                }
                            }
                        }

                        output_listbox.Items.Add("");
                        output_listbox.Items.Add("### END OF OUTPUT ###");
                    }
                    else
                    {
                        throw new ArgumentException("[House]: argument is not an House.");
                    }
                }

                //check if the selected item is an Apartment 
                else if (residence_listbox.SelectedItem.GetType() == typeof(Apartment))
                {

                    Apartment tempApt = residence_listbox.SelectedItem as Apartment;  //typecast selected item as an Apartment

                    if (tempApt != null)  //protect against failed typecasting
                    {

                        //loop through each person in the DeKalb Community to find the correct owner of the property and display the Apartment information
                        foreach (Person anon in Sycamore.Residents)
                        {
                            if (tempApt.OwnerID == anon.Id)
                            {

                                output_listbox.Items.Add(String.Format("Residents living at {0} # {1}, {2}, owned by {3}, {4}:", tempApt.StreetAddr, tempApt.Unit, tempApt.City,
                                                                                                                            anon.LastName, anon.FirstName));
                                output_listbox.Items.Add("----------------------------------------------------------------------");
                            }
                        }

                        //loop through each person in the DeKalb Community to find who lives at this property
                        foreach (Person anon in Sycamore.Residents)
                        {

                            //loop through the persons residence IDs
                            foreach (uint id in anon.ResidenceIds)
                            {

                                //if the person has an ID that matches the property ID, list them as a resident
                                if (id == tempApt.PropID)
                                {

                                    //format the first and last name for the output listbox
                                    string formatName = String.Format("{0}, {1}", anon.LastName, anon.FirstName);

                                    output_listbox.Items.Add(String.Format("{0,-27}{1,3}{2,30}", formatName, (DateTime.Now.Year - anon.Birthday.Year), anon.Occupation));
                                }
                            }
                        }

                        output_listbox.Items.Add("");
                        output_listbox.Items.Add("### END OF OUTPUT ###");
                    }
                    else
                    {
                        throw new ArgumentException("[House]: argument is not an House.");
                    }
                }
                else  //user may have selected a header or blank line.
                {
                    return;
                }
            }
        }

        /*********************************************************************************
         Method     : new_property_apt_textbox_TextChanged
         Purpose    : Disables control of the floor increment box and the garage checkbox
                      for a new property if the apartment textbox contains text on change.
                      Otherwise, it enables them.
         Parameters : 1. sender - Object that uses this event code
                      2. e - Arguments sent by event
         Returns    : N/A
        *********************************************************************************/
        private void new_property_apt_textbox_TextChanged(object sender, EventArgs e)
        {

            if (new_property_apt_textbox.TextLength != 0)
            {

                new_property_garage_checkBox.Enabled = false;
                new_property_floors_numericUpDown.Enabled = false;

            }
            else
            {

                new_property_garage_checkBox.Enabled = true;
                new_property_floors_numericUpDown.Enabled = true;

            }

        }

        private void add_new_property_button_Click(object sender, EventArgs e)
        {

            //Check if the input in the new property listbox is valid.
            //If it is, continue with property creation.
            //If it is not, checkPropertyInput displays an error box.
            if(checkPropertyInput() == true)
            {

                //New ID value. Needs to be incremented to an unused ID first
                uint newID = 0;

                //Loops through the ID dictionary sequentially until it finds one that is not in use
                foreach (UInt32 id in ids.Keys)
                {

                    if (id != newID)
                    {

                        break;

                    }

                    newID++;

                }

                //Add new ID value to dictionary so it can't be used again.
                ids.Add(newID, newID);

                //This block creates apartments if there is a unit provided.
                if (new_property_apt_textbox.TextLength > 0)
                {

                    if (dekalb_radio_button.Checked == true)
                    {

                        Apartment newApartment = new Apartment(newID, 0, 0, 0, new_property_street_address_textbox.Text, "DeKalb", "Illinois", "60115", "F", Convert.ToUInt32(new_property_bedrooms_numericUpDown.Value), Convert.ToUInt32(new_property_baths_numericUpDown.Value), Convert.ToUInt32(new_property_square_footage_numericUpDown.Value), "F");

                        DeKalb.addProperty(newApartment);

                    }
                    else if (sycamore_radio_button.Checked == true)
                    {

                        Apartment newApartment = new Apartment(newID, 0, 0, 0, new_property_street_address_textbox.Text, "Sycamore", "Illinois", "60178", "F", Convert.ToUInt32(new_property_bedrooms_numericUpDown.Value), Convert.ToUInt32(new_property_baths_numericUpDown.Value), Convert.ToUInt32(new_property_square_footage_numericUpDown.Value), "F");

                        Sycamore.addProperty(newApartment);

                    }

                }
                //This block creates houses if there is no apartment unit.
                else {

                    //String to hold the new garage input value.
                    //Using a string instead of a bool allows use of the original house constructor.
                    string garageVal;

                    //If the garage checkbox is checked, pass T for true. Pass F for false otherwise.
                    if (new_property_garage_checkBox.Checked == true)
                    {

                        garageVal = "T";

                    }
                    else
                    {

                        garageVal = "F";

                    }

                    //If the DeKalb radio button is active, create a house with the correct community and zipcode.
                    //Then, add it to the DeKalb community.
                    if (dekalb_radio_button.Checked == true)
                    {

                        House newHouse = new House(newID, 0, 0, 0, new_property_street_address_textbox.Text, "DeKalb", "Illinois", "60115", "F", Convert.ToUInt32(new_property_bedrooms_numericUpDown.Value), Convert.ToUInt32(new_property_baths_numericUpDown.Value), Convert.ToUInt32(new_property_square_footage_numericUpDown.Value), garageVal, "F", Convert.ToUInt32(new_property_floors_numericUpDown.Value));

                        DeKalb.addProperty(newHouse);

                    }
                    //Same as above, but for Sycamore.
                    else if (sycamore_radio_button.Checked == true)
                    {

                        House newHouse = new House(newID, 0, 0, 0, new_property_street_address_textbox.Text, "Sycamore", "Illinois", "60178", "F", Convert.ToUInt32(new_property_bedrooms_numericUpDown.Value), Convert.ToUInt32(new_property_baths_numericUpDown.Value), Convert.ToUInt32(new_property_square_footage_numericUpDown.Value), garageVal, "F", Convert.ToUInt32(new_property_floors_numericUpDown.Value));

                        Sycamore.addProperty(newHouse);

                    }
                    //Capture case where no radio buttons are active.
                    else
                    {

                        MessageBox.Show("Neither of the communities are selected\nPlease select a community to add the property to.", "Error");

                    }

                }

                //Clear and repopulate the residence listbox.
                residence_listbox.Items.Clear();
                populateResidenceListBox();

                //Clear and repopulate new resident residence combobox
                new_resident_residence_comboBox.Items.Clear();
                populateNewResidentComboBox();

            }

        }

        /*********************************************************************************
         Method     : checkPropertyInput
         Purpose    : Checks the current values in the new property listbox and checks if
                      they exist/if they hold correct values for their property
         Parameters : N/A
         Returns    : True if string passes, false if it fails
        *********************************************************************************/
        private bool checkPropertyInput()
        {

            //Constructed output string.
            //For each error, a new line is added to this string.
            string errorOutput = "";
            //Integer used as an out when checking for an integer in the street address
            int test = 0;

            //Catch if there is nothing in the street address box
            if (new_property_street_address_textbox.TextLength == 0)
            {

                errorOutput += "Street address cannot be empty.\n";

            }
            //If there is something in the street address textbox, make sure that it is in the
            //proper format of having an address number first. Otherwise, CompareTo will not work.
            else if (int.TryParse(new_property_street_address_textbox.Text.Split(' ')[0], out test) == false)
            {

                errorOutput += "Street address must start with a number.\n";

            }
            //The following catches were added before minimum values were set for the
            //rest of the boxes. They are kept here for preservation.
            /*
            if (new_property_square_footage_numericUpDown.Value <= 0)
            {

                errorOutput += "Square footage must contain a value greater than 0.\n";

            }
            if (new_property_bedrooms_numericUpDown.Value <= 0)
            {

                errorOutput += "No bedrooms? Are you sleeping on the floor?\n";

            }
            if (new_property_baths_numericUpDown.Value <= 0)
            {

                errorOutput += "No bathrooms? Bring a bucket.\n";

            }
            if (new_property_apt_textbox.Text.Length > 0 && new_property_floors_numericUpDown.Value <= 0)
            {

                errorOutput += "No floors? Does the house even exist?";

            }
            */

            //If the error string contains anything, create a message box with the new string and
            //return false (failed).
            if(errorOutput.Length > 0)
            {

                MessageBox.Show(errorOutput, "Invalid property values");

                return false;

            }
            //Otherwise, return true (passed).
            return true;

        }

    }
}
