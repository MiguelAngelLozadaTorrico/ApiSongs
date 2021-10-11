using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSongs.Models
{
    public class Song
    {
       
        public int SongId { get; set; }
        [Key]
        [Display(Name = "Nombre de la canción")]
        public string NombreCancion { get; set; }
        [Required]

        [Display(Name = "Autor")]
        public string Autor { get; set; }

        [Display(Name = "Letra")]
        public string Letra { get; set; }

        [Display(Name = "Link")]
        public string Link { get; set; }

    }
}
