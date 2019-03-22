using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE.Models
{
    public class Feedback
    {
        [BindNever]
        public int FeedbackId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage ="Your name is required")]
        public string Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Your email is required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        public string Email { get; set; }
        [Required]
        [StringLength(5000, ErrorMessage ="Your message is required")]
        public string Message { get; set; }

        public bool ContactMe { get; set; }
    }
}
