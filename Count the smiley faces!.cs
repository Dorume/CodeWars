using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/* Description
Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.

Rules for a smiling face:

Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
Every smiling face must have a smiling mouth that should be marked with either ) or D
No additional characters are allowed except for those mentioned.

Valid smiley face examples: :) :D ;-D :~)
Invalid smiley faces: ;( :> :} :]
*/






namespace CodeWars
{
    class Count_the_smiley_faces_
    {
        public static int CountSmileysMyAnswer(string[] smileys)
        {

            int count = 0;

            foreach (string b in smileys)
            {
                if (b.Length == 2 && (b[0] == ':' || b[0] == ';') && (b[1] == ')' || b[1] == 'D')) count++;
                if (b.Length == 3 && (b[0] == ':' || b[0] == ';') && (b[1] == '-' || b[1] == '~') && (b[2] == ')' || b[2] == 'D')) count++;
            }
            return count;

        }


        public static int CountSmileys(string[] smileys)
        {
            return smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$")); //В прикладі були підключені using System.Text.RegularExpressions;
        }                                                                               //                           using System.Linq;     
    }
}
