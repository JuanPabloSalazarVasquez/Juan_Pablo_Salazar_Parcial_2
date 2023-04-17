using System.ComponentModel.DataAnnotations;

namespace ConcertDB.DAL.Entities
{
    public class Ticket
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public DateTime? UseDate { get; set; }
        public bool IsUsed { get; set; }
        public string? EntranceGate { get; set; }

    }
}
