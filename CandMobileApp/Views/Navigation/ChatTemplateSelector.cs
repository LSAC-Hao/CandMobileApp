using System;
using Xamarin.Forms;
namespace CandMobileApp
{
	public class ChatTemplateSelector : DataTemplateSelector
	{
		public DataTemplate IncomingDataTemplate { get; set; }
		public DataTemplate OutgoingDataTemplate { get; set; }
		
		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var chatMessage = item as ChatMessage;

			if ( chatMessage != null && chatMessage.IsInbound) {
				return OutgoingDataTemplate;
			}

			return IncomingDataTemplate;
		}
	}
}
