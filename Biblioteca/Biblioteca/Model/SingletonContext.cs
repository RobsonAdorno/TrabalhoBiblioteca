using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    class SingletonContext
    {

        private static Context context;

        private SingletonContext() { }

        public static Context GetInstance()
        {
            if (context == null)
            {
                context = new Context();
            }
            return context;
        }

    }
}
