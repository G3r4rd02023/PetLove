﻿using System.ComponentModel.DataAnnotations;

namespace PetLove.Data.Entities
{
    public class PetType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de Mascota")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
    }
}
