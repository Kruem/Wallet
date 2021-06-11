using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Wallet.Common.Entities
{
    public class DocumentType
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The filed {0} must contain less than {1} characteres.")]
        [Required]
        [Display(Name = "Document Type")]
        public string Name { get; set; }
    }
}
