namespace Sample.Droid
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();

			builder.ConfigureMauiHandlers(
				handlers =>
				{
					handlers.AddHandler(typeof(Image2), typeof(ImageHandler2));
					handlers.AddHandler(typeof(ContentPage), typeof(PageHandler2));
				});
			builder.UseSharedMauiApp();

			return builder.Build();
		}
	}
}
