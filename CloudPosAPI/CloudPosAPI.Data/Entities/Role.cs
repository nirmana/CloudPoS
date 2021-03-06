﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        public Guid InstitutionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive  { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }    

        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<ScreenAccess> ScreenAccesses { get; set; }
        public virtual ICollection<ScreenEndpointAccess> ScreenEndpointAccesses { get; set; }
    }
}
