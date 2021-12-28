using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Models
{
    public class Persona
    {
        #region Constructors

        public Persona() 
        {
        
        }

        public Persona(DateTime birthday)
        {
            this.Birthday = birthday;

            if (this.GetAge() >= 18)
                this.Over18 = true;
        }
        #endregion

        #region Properties

        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public bool Over18 { get; set; }
        #endregion

        #region Methods


        public int GetAge() 
        {
            DateTime now = DateTime.Now;

            int age = 0;

            while(now >= this.Birthday.AddYears(1)) 
            {
                now = now.AddYears(-1);
                age++;
            }

            return age;
        }

        #endregion


    }
}
