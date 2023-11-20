﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ForensicBones4.Models
{
    [Table("Relatorios")]
    public class Relatorio
    {
        [Key]
        public int RelatorioId { get; set; }

        [Required(ErrorMessage = "Código do relatório obrigatório")]
        [Display(Name = "Código do Relatório")]
        public string Codigo { get; set; }

        [Display(Name = "Id do Usuário")]
        [Required(ErrorMessage = "Obrigado informar o Id do usuário")]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        //[Display(Name = "Inventario do Esqueleto")]
        //public InventarioEsqueleto InventarioEsqueletoId { get; set; }

        [Required(ErrorMessage = "Obrigado informar a data")]
        public DateTime Data { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

    }
}
