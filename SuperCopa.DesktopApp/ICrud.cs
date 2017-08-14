using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCopa.DesktopApp
{
    public interface ICrud
    {
        void Novo();
        void Excluir();
        void Pesquisar();
        void Salvar();
        void GerarRelatorio();
    }
}
