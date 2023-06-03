using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annalyn_sInfiltration
{
    internal class QuestLogic
    {
        public static bool CanFastAttack(bool result)
        {
            bool answer;
            if (result == true)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }
            return answer;
        }

        public static bool CanSpy(bool knight, bool ancher, bool prisoner)
        {
            bool result;
            if (knight == true || ancher == true || prisoner == true) {
            
            result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static bool CanSignalPrisoner( bool ancher, bool prisoner)
        {
            bool result;
            if (ancher == false || prisoner == true)
            {

                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static bool CanFreePrisoner(bool knight, bool ancher, bool prisoner, bool dog)
        {
            bool result;
            if( knight ==  true &&  ancher == true && prisoner == true && dog == true) { 
            result=true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
