using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCopa.Controller.DAL
{

    public abstract class GenericDAL<T>
    {
        public SuperCopa.Modelo.SuperCopaModelContainer DbContext { get; set; }

        protected GenericDAL()
        {
            this.DbContext = new Modelo.SuperCopaModelContainer();
        }
    }
}
