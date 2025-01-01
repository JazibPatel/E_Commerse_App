using LoginApp.Helpers;
namespace LoginApp;

public partial class LoginPage : ContentPage
{
    int count = 0;
    private Dictionary<string, string> _userDictionary;
    public LoginPage(string email, string pass, Dictionary<string, string> userDictionary)
	{
		InitializeComponent();
		emailLable.Text = email;
		passLable.Text = pass;
        _userDictionary = userDictionary;

    }

    private async void loginBtn_Clicked(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(emailLable.Text) ||
            String.IsNullOrEmpty(passLable.Text))
        {
            await DisplayAlert("Message", "Please Fill All Info...", "Ok");
            return;
        }

        string email = emailLable.Text;
        string pass = passLable.Text;
        
        if(_userDictionary.ContainsKey(email) && _userDictionary.ContainsValue(pass))
        {
            string user = emailLable.Text;
            await Navigation.PushAsync(new HomePage(user));
        }
        else
        {
            await DisplayAlert("Login Failed","Invalid credentials.","OK");
            return;
        }

        
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        bool isChecked = e.Value;
        passLable.IsPassword = !isChecked;
    }

    private void WDbtn_Clicked(object sender, EventArgs e)
    {
        Helper.ToggalTheme(myGrid, WDbtn, loginBtn, hading, ref count);
    }
}