﻿using System.ComponentModel.DataAnnotations;

namespace AppLogin.Models
{
    public class Cliente
    {
        [Display(Name = "Código", Description = "Código.")]
        public int Id { get; set; }

        [Display(Name = "Nome completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        public string Nome { get; set; }

        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "A data é obrigatória")]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "O Sexo é obrigatório")]
        [StringLength(1, ErrorMessage = "Deve conter 1 caracter")]
        public string Sexo { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O celular é obrigatório")]
        public string Telefone { get; set; }


        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "O Email não é válido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A senha é obrigatória")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 10 caracteres")]
        public string Senha { get; set; }

        [Display(Name = "Situação")]
        [Required(ErrorMessage = "A situação é obrigatória")]
        public string Situacao { get; set; }
    }
}
