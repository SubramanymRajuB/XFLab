using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using XFLab.Models;

namespace XFLab
{
    public partial class PopUp : PopupPage
    {
        TaskCompletionSource<Contact> _tcs = null;
        public PopUp()
        {
            InitializeComponent();
        }

        void BtnSend(System.Object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
            Contact contact = new Contact();
            contact.Name = txtFName.Text + " " + txtLName.Text;
            _tcs?.SetResult(contact);
        }

        public async Task<Contact> Show()
        {
            _tcs = new TaskCompletionSource<Contact>();
            await PopupNavigation.Instance.PushAsync(this);

            return await _tcs.Task;
        }
    }
}
