namespace SuperCopa.Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SuperCopaModel : DbContext
    {
        public SuperCopaModel()
            : base("name=SuperCopaEFContext")
        {
        }

        public virtual DbSet<Agente> Agentes { get; set; }
        public virtual DbSet<Equipe> Equipes { get; set; }
        public virtual DbSet<Jogador> Jogadores { get; set; }
        public virtual DbSet<Treinador> Treinadores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipe>()
                .HasMany(e => e.Jogadores)
                .WithOptional(e => e.Equipe)
                .HasForeignKey(e => e.Equipe_Id);

            modelBuilder.Entity<Jogador>()
                .Property(e => e.PosicaoPrincipal)
                .IsUnicode(false);

            modelBuilder.Entity<Treinador>()
                .HasMany(e => e.Equipes)
                .WithOptional(e => e.Treinadores)
                .HasForeignKey(e => e.TreinadorId);
        }
    }
}
