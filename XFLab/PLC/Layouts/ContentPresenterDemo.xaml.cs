using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XFLab.ViewModels;

namespace FormsGallery.XamlExamples
{
    public partial class ContentPresenterDemo : ContentPage
    {
        int templateIndex = 0;

        //Templates
        ControlTemplate template1 = new ControlTemplate(typeof(TemplateOne));
        ControlTemplate template2 = new ControlTemplate(typeof(TemplateTwo));
        ControlTemplate template3 = new ControlTemplate(typeof(TemplateThree));
        ControlTemplate template4 = new ControlTemplate(typeof(TemplateFour));

        public ContentPresenterDemo()
        {
            InitializeComponent();
            BindingContext = new ContentPresenterDemoViewModel();
            picker.SelectedIndex = 0;
            ControlTemplate = template1;


        }

        void SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var index = picker.SelectedIndex;
            if (index != templateIndex)
            {
                switch (index)
                {
                    case 0:
                        ControlTemplate = template1;
                        break;
                    case 1:
                        ControlTemplate = template2;
                        break;
                    case 2:
                        ControlTemplate = template3;
                        break;
                    case 3:
                        ControlTemplate = template4;
                        break;
                }

                templateIndex = index;
            }
        }
    }
}
