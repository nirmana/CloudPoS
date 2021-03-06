﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("Institution")]
    public class Institution
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Guid CityId { get; set; }
        public Guid CountryId { get; set; }
        public Guid CurrencyId { get; set; }
        public string Language { get; set; }
        public string TimeZone { get; set; }
        public string ContractPerson { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }
        public byte[] Logo { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<UserLogin> UserLogins { get; set; }
        public virtual ICollection<HttpLog> HttpLogs { get; set; }
        public virtual ICollection<InstitutionSubsctiption> InstitutionSubsctiptions { get; set; }
    }
}
