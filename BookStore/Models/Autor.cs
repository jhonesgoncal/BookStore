﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Autor
    {
        public Autor()
        {
            this.Livros = new List<Livro>();        
        }

        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Campo invalido")]
        public string Nome { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}