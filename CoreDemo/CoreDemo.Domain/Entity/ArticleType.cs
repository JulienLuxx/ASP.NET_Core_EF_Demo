using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreDemo.Domain
{
    [Table("ArticleType")]
    public class ArticleType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(64)]
        public string EditerName { get; set; }

        public ArticleTypeStatusEnum Status { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
