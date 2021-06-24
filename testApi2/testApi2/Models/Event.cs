using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testApi2.Models
{
    [Table("Events")]
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        [MaxLength(4000)]
        public string Description { get; set; }
        public int? TimeZone  { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime Enddate { get; set; }        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ModiﬁedDate { get; set; }
    }
}
