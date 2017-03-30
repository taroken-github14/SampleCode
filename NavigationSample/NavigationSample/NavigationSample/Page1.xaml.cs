using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NavigationSample
{
    public partial class Page1 : ContentPage
    {
        // 遷移元 MainEntry.Text = parameter に名前データを受け渡す
        public Page1(string parameter)
        {
            InitializeComponent();

            // 遷移元 MainEntry.Text 名前データを表示
            MainLabel.Text = "こんにちは" +　parameter +"さん";
        }
    }
}