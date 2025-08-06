using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using WebAtividadeEntrevista.CustomValidationAttributes;

namespace WebAtividadeEntrevista.Models
{
    /// <summary>
    /// Classe de Modelo de Cliente
    /// </summary>
    public class BeneficiariosModel
    {
        public long? Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        [Required]
        public string CPF { get; set; }
    }
}