namespace GymSystem.Entities
{
	public class Plans:BaseEntity
	{
		public string Name { get; set; } = default;
		public string? Description { get; set; } = default;
		public  int  DurationDays { get; set; }
		public  decimal Price { get; set; }
		public  bool IsActive { get; set; }
		public ICollection<MemberShip> MemberShip { get; set; } = new HashSet<MemberShip>();

	}
}
