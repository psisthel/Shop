namespace Shop.UIForms.ViewModels
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Views;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(Login);

        public LoginViewModel()
        {
            this.Email = "p.ariashorna@gmail.com";
            this.Password = "123456";
        }
        private async void Login()
        {
            if(string.IsNullOrEmpty(this.Email)) 
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an Email",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an Password",
                    "Accept");
                return;
            }

            if(!this.Email.Equals("p.ariashorna@gmail.com") || !this.Password.Equals("123456"))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or Password wrong.",
                    "Accept");
                return;
            }

            //await Application.Current.MainPage.DisplayAlert(
            //    "Ok",
            //    "Fuck yhaeea !!!",
            //    "Accept");

            MainViewModel.GetInstance().Products = new ProductsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ProductsPage());

        }
    }
}
