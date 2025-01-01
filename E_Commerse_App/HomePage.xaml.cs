namespace LoginApp;

public partial class HomePage : ContentPage
{
	public HomePage(string name)
	{
		InitializeComponent();
		homeLable.Text = name;
	}
}