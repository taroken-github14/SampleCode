
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NavigationSample
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        // ログインボタンの押下
        private async void Button_OnClicked(object sender, EventArgs e)
        {

            if (string.Format(UserId.Text).Equals("nagai") &&
                string.Format(Password.Text).Equals("pass"))
            {
                await Navigation.PushAsync(new Page1(UserId.Text));
                ErrorMessageLabel.Text = "";
                return;
            }

            ErrorMessageLabel.Text = "ログインIDまたはパスワードが誤っています";

        }

  
    }
}
