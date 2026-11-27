namespace GymSystem.Entities
{
	public class Member: GymUser
	{
		public  string?  Photo { get; set; }
		public ICollection<MemberShip> MemberShip { get; set; } = new HashSet<MemberShip>();
	}
}
