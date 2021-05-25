using System;
using System.ComponentModel.DataAnnotations;
using HuaweiReg.Data.IRepositories;
using Microsoft.AspNetCore.Identity;

namespace HuaweiReg.Data.Models
{
    public class User: IdentityUser, ITrackedEntity
    {
        [Required]
        [Display(Name = "User name")]
        [MaxLength(255)]
        public override string UserName { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
    }

    public enum UserRole
    {
        ADMIN = 1
    }
}
