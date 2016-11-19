using Gama.Musicas.WEB.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gama.Musicas.WEB.ViewModels.Album
{
    public class AlbumViewModel
    {
        [Required(ErrorMessage ="O ID do álbum é obrigatório")]
        public int Id { get; set; }
        [Display(Name = "Nome do Album")]
        [Required(ErrorMessage = "O Nome do álbum é obrigatório")]
        [MaxLength(100, ErrorMessage ="Nome maior que 100 caracteres")]
        public string Nome { get; set; }
        [Display(Name = "Ano do Album")]
        [Required(ErrorMessage = "O ano do álbum é obrigatório")]
        public int Ano { get; set; }
        [Display(Name = "Observações")]
        [MaxLength(1000, ErrorMessage = "Você excedeu 1000 caracteres")]
        public string Observacoes { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required (ErrorMessage ="O email é obrigatório")]
        [MaxLength(50, ErrorMessage = "Você excedeu 50 caracteres")]
        [EmailTreinaWeb(ErrorMessage ="O email tem que ser Treinaweb")]
        public string Email { get; set; }
    }
}