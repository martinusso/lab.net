namespace EntityPOC
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ParticipanteContext : DbContext
    {
        public ParticipanteContext()
            : base("name=Participante")
        {
        }

       public virtual DbSet<Participante> Participantes { get; set; }
    }

    public class Participante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
    }
}