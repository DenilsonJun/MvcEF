using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeAlunos.Models.Entity
{
    public class Alunos
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime Nascimento { get; set; }
        public string Responsavel { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [DataType(DataType.Text)]
        public string Endereco { get; set; }
        public string Sexo { get; set; }
        public int Graduacao { get; set; }
        public string Status { get; set; }



    }
}