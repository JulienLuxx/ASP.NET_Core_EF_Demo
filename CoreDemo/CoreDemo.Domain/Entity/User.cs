using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreDemo.Domain
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Password { get; set; }

        public UserStatusEnum Status { get; set; }

        [StringLength(512)]
        public string Mobile { get; set; }

        [StringLength(512)]
        public string MailBox { get; set; }

        [StringLength(512)]
        public string SaltValue { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
