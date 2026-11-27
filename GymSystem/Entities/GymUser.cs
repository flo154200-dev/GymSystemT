using GymSystem.Enums;

namespace GymSystem.Entities
{
	public  abstract  class GymUser: BaseEntity
	{
		public string Name { get; set; } = default;
		public string  Email { get; set; } = default;
		public  int  Phone { get; set; } = default;
		public  DateTime DateOfBirth { get; set; } = default;

		public Gender gender { get; set; } = default;
		public  Address Address { get; set; } = default;

	}
}
