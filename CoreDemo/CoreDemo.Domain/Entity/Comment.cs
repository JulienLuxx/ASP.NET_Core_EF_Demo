using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreDemo.Domain
{
    [Table("Comment")]
    public class Comment
    {
        public Comment()
        {
            //Status = 0;
            //IsDelete = false;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsDelete { get; set; }

        [StringLength(256)]
        public string Creator { get; set; }

        [StringLength(1024)]
        public string Content { get; set; }

        public int? ParentId { get; set; }

        public CommentStatusEnum Status { get; set; }

        public int? ArticleId { get; set; }

        //[Timestamp]
        //public byte[] Timestamp { get; set; }

        //[ForeignKey("ArticleId")]
        //public virtual Article Article { get; set; }
    }
}
