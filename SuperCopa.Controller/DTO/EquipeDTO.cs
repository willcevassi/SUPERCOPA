namespace SuperCopa.Controller.DTO
{
    public class EquipeDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual TreinadorDTO Treinador { get; set; }
    }
}