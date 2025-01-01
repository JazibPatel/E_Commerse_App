namespace LoginApp;
using Microsoft.Maui.Graphics;
using LoginApp.Helpers;
public partial class RegisterPage : ContentPage
{

    int count = 0;
    Dictionary<string, string> userData = new Dictionary<string, string>();
    public RegisterPage()
    {
        InitializeComponent();
    }

    private void CheckBox_Pass(object sender, CheckedChangedEventArgs e)
    {
        bool isChecked = e.Value;
        passBtn.IsPassword = !isChecked;
    }

    private void CheckBox_Conf(object sender, CheckedChangedEventArgs e)
    {
        bool isChecked = e.Value;
        confBtn.IsPassword = !isChecked;
    }

    private async void regBtn_Clicked(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(nameBox.Text) ||
            String.IsNullOrEmpty(emailBox.Text) ||
            String.IsNullOrEmpty(passBtn.Text) ||
            String.IsNullOrEmpty(confBtn.Text))
        {
            await DisplayAlert("Message", "Please Fill All Info...", "Ok");
            return;
        }

        if (passBtn.Text != confBtn.Text)
        {
            await DisplayAlert("Message", "Password Don't Match. Pls Check...", "Ok");
            return;
        }

        string email = emailBox.Text;
        string pass = confBtn.Text;

        if (userData.ContainsKey(email)){
            await DisplayAlert("Message", "User Already Register. Try New ID", "ok");
            return;
        }

        userData.Add(email, pass);

        await DisplayAlert("Message", "Registration Successful :)", "Ok");

        await Navigation.PushAsync(new LoginPage(email, pass, userData));
    }

    private void WDbtn_Clicked(object sender, EventArgs e)
    {
        Helper.ToggalTheme(myGrid, WDbtn, regBtn, hading, ref count);
    }

    private void genderBox_PropertyChanged(object sender, EventArgs e)
    {
        genderLable.Text = "";
    }
}