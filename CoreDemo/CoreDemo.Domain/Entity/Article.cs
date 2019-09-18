using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreDemo.Domain
{
    [Table("ArticleType")]
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Required]
        public bool IsDeleted { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        [StringLength(1024)]
        public string Content { get; set; }

        //[Required]
        //[ForeignKey("")]
        public int TypeId { get; set; }

        public ArticleStatusEnum Status { get; set; }

        public int UserId { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
