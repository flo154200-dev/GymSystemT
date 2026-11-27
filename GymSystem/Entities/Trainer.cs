namespace GymSystem.Entities
{
	public class Trainer : GymUser
	{
		public  DateTime HireDate { get; set; }
		public string Speciality { get; set; }
		public ICollection<Session> Sessions { get; set; } = new HashSet<Session>();
	}
}
