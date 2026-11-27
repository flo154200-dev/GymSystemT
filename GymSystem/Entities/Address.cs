using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.Entities
{
	[Owned]
	public class Address
	{
		
		public int BuildNumber { get; set; }
		public string street { get; set; } = default;
		public string City { get; set; } = default;
		
	}
}
