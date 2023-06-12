namespace AspNetIden.RazorPage.Models
{
	public class User
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Status { get; set; }
		public DateTime LastLoggedIn { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}
