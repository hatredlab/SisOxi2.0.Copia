using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOxi.VO
{
    public class LoginVO
    {
        private string _nombres;

        public string nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        private string _clave;

        public string clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

    }
}
