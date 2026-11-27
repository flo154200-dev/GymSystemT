using System.ComponentModel.DataAnnotations.Schema;

namespace GymSystem.Entities
{
	public class MemberShip:BaseEntity
	{
		public DateTime StartDate { get; set; } = default;
		public  DateTime EndDate { get; set; }
		[ForeignKey("Member")]
		public int MemberId { get; set; }
		[ForeignKey ("Plans")]
		public int PlaneId { get; set; }
		public Plans Plans { get; set; } = default;
		public Member Member { get; set; } = default;
		public string Status => EndDate > DateTime.Now ? "Active" : "Expired";

	}
}
