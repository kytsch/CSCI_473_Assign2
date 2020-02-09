using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleSean_Assign2
{
    /*********************************************************************************
         CommunityEnum Class

         CommunityEnum class that implements the IEnumerator interface
        *********************************************************************************/

    public class CommunityEnum : IEnumerator
    {

        //Array to iterate through.
        public Community[] communities;

        //Startiterator position at beginning
        int position = -1;

        //Set the communities array to the passed-in array.
        public CommunityEnum(Community[] list)
        {

            communities = list;

        }

        //Increment iterator position
        public bool MoveNext()
        {

            position++;

            return (position < communities.Length);

        }

        //Resets enumerator position to the beginning
        public void Reset()
        {

            position = -1;

        }

        //Returns the object at the iterator's position
        object IEnumerator.Current
        {

            get
            {

                return Current;

            }

        }

        //Return the community at the current position.
        //If the iterator is out of bounds, throw a exception.
        public Community Current
        {

            get
            {

                try
                {

                    return communities[position];

                }
                catch (IndexOutOfRangeException)
                {

                    throw new InvalidOperationException();

                }

            }

        }

    }

}
