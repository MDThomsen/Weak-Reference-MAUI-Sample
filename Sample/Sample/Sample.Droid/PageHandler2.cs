using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace Sample.Droid
{
	public class PageHandler2 : PageHandler
	{
		protected override void ConnectHandler(ContentViewGroup platformView)
		{
			base.ConnectHandler(platformView);
		}

		protected override void DisconnectHandler(ContentViewGroup platformView)
		{
			base.DisconnectHandler(platformView);
		}
	}
}
