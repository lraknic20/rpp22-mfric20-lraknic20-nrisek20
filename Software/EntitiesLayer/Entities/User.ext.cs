using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Entities
{
    public partial class User
    {
        public override string ToString()
        {
            return first_name + " " + last_name;
        }
        public bool isAdmin()
        {
            if (roles_id == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //nrisek
        public bool isActivated()
        {
            if (roles_id == 6)
            {
                return false;
            }
            else return true;
        }
    }
}
