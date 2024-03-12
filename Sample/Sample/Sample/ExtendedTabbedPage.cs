namespace Sample;

public class ExtendedTabbedPage : TabbedPage
{
	public ExtendedTabbedPage()
	{
		Children.Add(new NavigationPage(new MainPage()));
	}

	public void Reset()
	{
		Children.Clear();
		
		Children.Add(new MainPage());
	}
}