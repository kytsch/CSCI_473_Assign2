using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleSean_Assign2
{
    /*********************************************************************************
         Communities Class

         Implements the IEnumerable interface
        *********************************************************************************/

    //IEnumerable stuff starts here
    public class Communities : IEnumerable
    {

        //Array of stored communities
        private Community[] comms;

        //Copy an existing community array to the Commuinities comm array
        public Communities(Community[] cArr)
        {

            //Set comms to a new array with the same size as the passed-in array
            comms = new Community[cArr.Length];

            //Iterate through the input array and place its value into the corresponding comms value
            for (int i = 0; i < cArr.Length; i++)
            {

                comms[i] = cArr[i];

            }

        }

        //GetEnumerator() override
        IEnumerator IEnumerable.GetEnumerator()
        {

            return (IEnumerator)GetEnumerator();

        }

        //Returns the enumerator assigned for Communities so the above function works
        public CommunityEnum GetEnumerator()
        {

            return new CommunityEnum(comms);

        }

    }

}
