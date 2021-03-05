using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;// this is so the error messeages are imported
using System.ComponentModel.DataAnnotations.Schema;

namespace CS_Bank_Accounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        public decimal Amount { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}