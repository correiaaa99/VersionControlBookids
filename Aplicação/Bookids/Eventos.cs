//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookids
{
    using System;
    using System.Collections.Generic;
    
    public partial class Eventos
    {
        public Eventos()
        {
            this.Inscricoes = new HashSet<Inscricoes>();
            this.Participacoes = new HashSet<Participacoes>();
            this.Colaboracoes = new HashSet<Colaboracoes>();
        }
    
        public int NrEvento { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public System.DateTime DataHora { get; set; }
        public string LimiteParticipacoes { get; set; }
        public string IdadeInferior { get; set; }
        public string IdadeSuperior { get; set; }
        public int ColaboracoesId { get; set; }
        public string TipoEvento { get; set; }
    
        public virtual ICollection<Inscricoes> Inscricoes { get; set; }
        public virtual ICollection<Participacoes> Participacoes { get; set; }
        public virtual ICollection<Colaboracoes> Colaboracoes { get; set; }
    }
}
