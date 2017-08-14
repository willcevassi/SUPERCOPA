using System;
using System.Data.Entity;
using SuperCopa.Controller.DTO;
using SuperCopa.Modelo;

namespace SuperCopa.Controller.DAL
{
    public class JogadorDAL : GenericDAL<JogadorDTO>
    {

        public override bool Salvar(JogadorDTO dto)
        {
            try
            {
                if (ValidaCampos(dto))
                {

                    Jogador modelo = new Jogador();
                    modelo.Id = dto.Id;
                    modelo.Agente = new Agente()
                    {
                        Nome = dto.Nome,
                        Telefone = dto.Telefone,
                        Endereco = dto.Endereco
                    };
                    modelo.PosicaoPrincipal = dto.PosicaoPrincipal;
                    //modelo.Equipe = new Equipe
                    //{
                    //    Id = dto.EquipeDTO.Id,
                    //    Nome = dto.EquipeDTO.Nome
                    //};
                    //Se id > 0, então é uma atualização
                    if (dto.Id > 0)
                    {
                        dbcontext.Jogadores.Add(modelo);
                        dbcontext.Entry(modelo).CurrentValues.SetValues(modelo);
                        dbcontext.Entry(modelo).State = EntityState.Modified;
                    }
                    else
                    {
                        //senão, está inserindo
                        dbcontext.Jogadores.Add(modelo);
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


        //public override bool Save(AlunoDTO o)
        //{
        //    try
        //    {
        //        if (ValidaCampos(o))
        //        {
        //            ALUNO alunoModel = new ALUNO();

        //            alunoModel.idAluno = o.idAluno;
        //            alunoModel.idPessoa = o.idPessoa;
        //            alunoModel.PESSOA = new PESSOA()
        //            {
        //                idPessoa = o.idPessoa,
        //                nomePessoa = o.pessoa.nomePessoa,
        //                endereco = o.pessoa.endereco,
        //                dataNascimento = o.pessoa.dataNascimento
        //            };
        //            alunoModel.cargo = o.cargo;

        //            //se tem código preenchido, está atualizando
        //            if (o.idAluno > 0)
        //            {
        //                db.ALUNO.Attach(alunoModel);
        //                db.Entry(alunoModel).CurrentValues.SetValues(alunoModel);
        //                db.Entry(alunoModel).State = EntityState.Modified;
        //            }
        //            else
        //            {
        //                //senão, está inserindo
        //                db.ALUNO.Add(alunoModel);
        //            }

        //            db.SaveChanges();
        //        }
        //        else
        //            return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        mensagens.Add(ex.Message);
        //        return false;
        //    }

        //    return true;
        //}

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
