using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Gülzade" && gamer.LastName=="Odabaş" 
                && gamer.BirthYear==1996 && gamer.IdentityNumber==123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
