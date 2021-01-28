using System;
using Xamarin.Forms;

namespace XFLab.ViewModels
{
    public class ViewModelLocalizator
    {
        public static readonly BindableProperty AutoWireViewModelProperty =
              BindableProperty.CreateAttached("AutoWireViewModel", typeof(bool), typeof(ViewModelLocalizator), default(bool), propertyChanged: OnAutoWireViewModelChanged);

        public static bool GetAutoWireViewModel(BindableObject bindable)
        {
            return (bool)bindable.GetValue(AutoWireViewModelProperty);
        }

        public static void SetAutoWireViewModel(BindableObject bindable, bool value)
        {
            bindable.SetValue(AutoWireViewModelProperty, value);
        }

        /// <summary>
        /// VERIFY THE VIEW NAME AND ASSOCIATE IT WITH THE VIEW MODEL OF THE SAME NAME. REPLACING THE 'View' suffix WITH THE 'ViewModel'
        /// </summary>
        private static void OnAutoWireViewModelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is Element view))
            {
                return;
            }

            var viewType = view.GetType();

            var viewModelName = viewType.FullName.Replace(".Views.", ".ViewModels.").Replace("Page", "ViewModel");
            var viewModelType = Type.GetType(viewModelName);

            if (viewModelType == null) { return; }

            var vmInstance = Activator.CreateInstance(viewModelType);

            if (vmInstance != null)
            {
                view.BindingContext = vmInstance;
            }
        }
    }
}
