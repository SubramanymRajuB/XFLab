﻿using Xamarin.Forms;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using XFLab.Models;

namespace XFLab
{
	public class LoadResourceXml : ContentPage
	{
		public LoadResourceXml ()
		{
			#region How to load an XML file embedded resource
			var assembly = typeof(LoadResourceJson).GetTypeInfo().Assembly;
			Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{"FilesDemo.LibXmlResource.xml"}");

			List<Animal> monkeys;
			using (var reader = new StreamReader (stream)) 
            {
				var serializer = new XmlSerializer(typeof(List<Animal>));
                monkeys = (List<Animal>)serializer.Deserialize(reader);
			}
			#endregion

			this.Title = "Load XML";

			var listView = new ListView ();
            listView.ItemTemplate = new DataTemplate(() =>
            {
                var textCell = new TextCell();
                textCell.SetBinding(TextCell.TextProperty, "Name");
                textCell.SetBinding(TextCell.DetailProperty, "Location");
                return textCell;
            });
			listView.ItemsSource = monkeys;

			Content = new StackLayout 
            {
                Margin = new Thickness(20),
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = 
                {
					new Label { Text = "Embedded Resource XML File", 
						FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
						FontAttributes = FontAttributes.Bold
					}, listView
				}
			};

			// NOTE: use for debugging, not in released app code!
			//foreach (var res in assembly.GetManifestResourceNames()) 
			//	System.Diagnostics.Debug.WriteLine("found resource: " + res);
		}
	}
}

