using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCopa.Controller.DTO
{
    public class JogadorDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string PosicaoPrincipal { get; set; }
        public virtual EquipeDTO EquipeDTO { get; set; }
    }
}
