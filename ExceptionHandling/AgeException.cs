using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class AgeException:Exception
    {
        //userdefined
        public AgeException(string errmsg) : base(errmsg)
        { 
        }
    }
}
