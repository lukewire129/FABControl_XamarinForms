using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FABControl_XamarinForms
{
        public partial class MainPage : ContentPage
        {
                public MainPage()
                {
                        InitializeComponent();
                }
                private void Button1Clicked(object sender, EventArgs e)
                {
                        ButtonClickedResult.Text = "SubButton 1번 클릭되었습니다.";
                }

                private void Button2Clicked(object sender, EventArgs e)
                {
                        ButtonClickedResult.Text = "SubButton 2번 클릭되었습니다.";
                }

                private void Button3Clicked(object sender, EventArgs e)
                {
                        ButtonClickedResult.Text = "SubButton 3번 클릭되었습니다.";
                }
        }
}
