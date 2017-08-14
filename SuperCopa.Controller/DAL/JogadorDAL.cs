using System;
using System.Data.Entity;

namespace SuperCopa.Controller.DAL
{
    public class JogadorDAL<T> : GenericDAL<SuperCopa.Modelo.Jogador>
    {

        public override bool Salvar(SuperCopa.Modelo.Jogador jogador)
        {
            try
            {
                if (ValidaCampos(jogador))
                {
                    //Se id > 0, então é uma atualização
                    if (jogador.Id > 0)
                    {
                        dbcontext.JogadoresSet.Add(jogador);
                        dbcontext.Entry(jogador).CurrentValues.SetValues(jogador);
                        dbcontext.Entry(jogador).State = EntityState.Modified;
                    }
                    else
                    {
                        //senão, está inserindo
                        dbcontext.JogadoresSet.Add(jogador);
                    }
                    dbcontext.SaveChanges();

                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                _mensagens.Add(ex.Message);
                return false;
            }
        }

        //public override AlunoDTO GetById(int id)
        //{
        //    var query = (from a in db.ALUNO
        //                 where a.idAluno.Equals(id)
        //                 select new AlunoDTO
        //                 {
        //                     idAluno = a.idAluno,
        //                     idPessoa = a.idPessoa,
        //                     cargo = a.cargo,
        //                     pessoa = new PessoaDTO()
        //                     {
        //                         idPessoa = a.PESSOA.idPessoa,
        //                         nomePessoa = a.PESSOA.nomePessoa,
        //                         endereco = a.PESSOA.endereco,
        //                         dataNascimento = a.PESSOA.dataNascimento
        //                     }
        //                 }).FirstOrDefault();
        //    return query;
        //}
        //public override List<AlunoDTO> GetBy()
        //{
        //    var query = (from a in db.ALUNO
        //                 select new AlunoDTO
        //                 {
        //                     idAluno = a.idAluno,
        //                     idPessoa = a.idPessoa,
        //                     cargo = a.cargo,
        //                     pessoa = new PessoaDTO()
        //                     {
        //                         idPessoa = a.PESSOA.idPessoa,
        //                         nomePessoa = a.PESSOA.nomePessoa,
        //                         endereco = a.PESSOA.endereco,
        //                         dataNascimento = a.PESSOA.dataNascimento
        //                     }
        //                 }).ToList();
        //    return query;
        //}
        //public override bool ValidaCampos(AlunoDTO o)
        //{
        //    bool retorno = true;

        //    if (string.IsNullOrEmpty(o.cargo))
        //    {
        //        mensagens.Add(string.Format(Camadas.DAO.Properties.Resources.CampoObrigatorio, "Cargo"));
        //        retorno = false;
        //    }
        //    if (string.IsNullOrEmpty(o.pessoa.endereco))
        //    {
        //        mensagens.Add(string.Format(Camadas.DAO.Properties.Resources.CampoObrigatorio, "Endereço"));
        //        retorno = false;
        //    }
        //    if (string.IsNullOrEmpty(o.pessoa.nomePessoa))
        //    {
        //        mensagens.Add(string.Format(Camadas.DAO.Properties.Resources.CampoObrigatorio, "Nome"));
        //        retorno = false;
        //    }
        //    if (!o.pessoa.dataNascimento.HasValue)
        //    {
        //        mensagens.Add(string.Format(Camadas.DAO.Properties.Resources.CampoObrigatorio, "Data de Nascimento"));
        //        retorno = false;
        //    }

        //    return retorno;
        //}
    }
}
