using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCopa.Controller.DAL
{

    public abstract class GenericDAL<T>
    {
        protected SuperCopa.Modelo.SuperCopaModelContainer dbcontext;
        protected List<String> _mensagens;

        protected GenericDAL()
        {
            this.dbcontext = new Modelo.SuperCopaModelContainer();
            this._mensagens = new List<string>();
        }

        public virtual bool Salvar(T o)
        {
            return true;
        }
        public virtual bool Exluir(int id)
        {
            return true;
        }
        public virtual T GetById(int id)
        {
            return default(T);
        }
        public virtual List<T> GetByString()
        {
            return new List<T>();
        }
        public virtual bool ValidaCampos(T o)
        {
            return true;
        }

    }
}
