using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyPet.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("ObservacaoId")]
        [Display(Name = "Identificação da observação")]
        public int Id { get; set; }

        [Column("ObservacaoDescricao")]
        [Display(Name = "Descrição")]
        public string ObservacaoDescricao { get; set; } = string.Empty;

        [Column("ObservacaoLocal")]
        [Display(Name = "Local")]
        public string ObservacaoLocal { get; set; } = string.Empty;

        [Column("ObservacaoData")]
        [Display(Name = "Data")]
        public DateTime ObservacaoData { get; set; }

        [ForeignKey("AnimalId")]
        [Display(Name = "Animal")]
        public int AnimalId { get; set; }
        public Animais? Animais { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuário")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
