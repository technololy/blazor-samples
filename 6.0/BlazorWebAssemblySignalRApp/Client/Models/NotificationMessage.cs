using System;
namespace BlazorWebAssemblySignalRApp.Client.Models
{
	public class NotificationMessage
	{
        public string UserId { get; set; }

        public long RefId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public string Type { get; set; }
        public object Data { get; set; }
        public DateTime DateAdded { get; set; }
    }
}

