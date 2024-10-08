﻿using System.ComponentModel.DataAnnotations;

namespace CustomerMessageRepository.Entities
{
    public class CustomerMessage
    {
        [Key]
        public int IdCustomerMessage { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }
    }
}
