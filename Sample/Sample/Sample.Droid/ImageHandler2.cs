using Android.Widget;
using Microsoft.Maui.Handlers;

namespace Sample.Droid
{
	public class ImageHandler2 : ImageHandler
	{
		public ImageHandler2()
		{

		}

		protected override void ConnectHandler(ImageView platformView)
		{
			base.ConnectHandler(platformView);
		}

		protected override void DisconnectHandler(ImageView platformView)
		{
			base.DisconnectHandler(platformView);
		}
	}
}
