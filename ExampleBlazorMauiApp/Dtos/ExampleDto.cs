using System.ComponentModel.DataAnnotations;

namespace ExampleModernBlazorApp.Dtos
{
	public class ExampleDto
	{
		public ExampleDto(string title, string body, string userGuid)
		{
			Id = Guid.NewGuid();
			Title = title;
			Body = body;
			UserGuid = userGuid;
		}

		[Key]
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
		public string UserGuid { get; internal set; }
	}
}
