namespace GymSystem.Entities
{
	public  abstract class BaseEntity
	{
		public int Id { get; set; }
		public DateTime CreatAt { get; set; }
		public DateTime? UpdateAt { get; set; }
		public string? CreatedBy { get; set; }
	}
}
