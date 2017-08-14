namespace SuperCopa.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Jogadores")]
    public partial class Jogador
    {
        [StringLength(50)]
        public string PosicaoPrincipal { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? Equipe_Id { get; set; }

        public virtual Agente Agente { get; set; }

        public virtual Equipe Equipe { get; set; }
    }
}
