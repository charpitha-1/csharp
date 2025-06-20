using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace RoomManagerMvcApp.Data
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResId { get; set; }
        [Required]
        [ForeignKey("ReservedByUser")]
        public Guid ReservedBy {  get; set; }
        [Required]
        [ForeignKey("RoomData")]
        public Guid RoomId {  get; set; }
        [Required]
        [StringLength(300)]
        public string Reason { get; set; }
        [Required]
        public DateTime ReservationDate { get; set; }
        //navigation
        public UserInfo ReservedByUser { get; set; }
        public MeetingRoom RoomData {  get; set; }
    }
}
