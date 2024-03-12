namespace Sample
{
	public partial class MainPage : ContentPage
	{
		public MainPage(string text = null)
		{
			InitializeComponent();

			if (text != null)
				Btn.Text = text;
		}

		private async void OnBtnClicked(object sender, EventArgs e)
		{
			WeakReference pageReference;

			{
				var page = new MainPage("New Modal");
				pageReference = new WeakReference(page);

				await Navigation.PushModalAsync(page);
				await Navigation.PopModalAsync();
			}

			await Task.Yield();
			GC.Collect();
			GC.WaitForPendingFinalizers();

			Console.WriteLine($"Page still alive: {pageReference?.IsAlive}");
		}
	}
}
