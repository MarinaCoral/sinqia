//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesenvolvimentoWeb.Vendas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUTO()
        {
            this.ITENS = new HashSet<ITEM>();
        }
    
        public int Id { get; set; }
        public int Id_Categoria { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public byte[] Foto { get; set; }
        public string Mime_Type { get; set; }
    
        public virtual CATEGORIA CATEGORIA_INFO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM> ITENS { get; set; }
    }
}
