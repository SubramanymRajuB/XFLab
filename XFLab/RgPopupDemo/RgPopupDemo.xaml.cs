using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;  

namespace XFLab
{
    public partial class RgPopupDemo : ContentPage
    {
        public RgPopupDemo()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var pr = new PopUp();
            var scaleAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Right,
                PositionOut = MoveAnimationOptions.Left
            };

            pr.Animation = scaleAnimation;
            //await PopupNavigation.Instance.PushAsync(pr);


            var contact = await pr.Show();
            if (!string.IsNullOrEmpty(contact?.Name?.Trim()))
            {
                await DisplayAlert("Alert", "Selected Name is "+ contact.Name, "Ok");
            }
            else
            {
                await DisplayAlert("Alert", "Please enter all details.", "Ok");
            }
        }

    }
}
