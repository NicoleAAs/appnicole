using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appnicole
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ValgusFoor2 : ContentPage
	{
		public ValgusFoor2()
		{
			//InitializeComponent();
			Label Red = new Label()
			{
                Text ="red",
				TextColor = Color.Red,
				FontSize=30,
				FontAttributes = FontAttributes.Bold
			};
			Label Yellow = new Label()
			{
				Text = "yellow",
				TextColor = Color.Yellow,
				FontSize = 30,
				FontAttributes = FontAttributes.Bold
			};
			Label Green = new Label()
			{
				Text = "green",
				TextColor = Color.Green,
				FontSize = 30,
				FontAttributes = FontAttributes.Bold
			};
			StackLayout stackLayout = new StackLayout()
			{
				Children = { Red, Yellow, Green }
			};
		
			stackLayout.Orientation = StackOrientation.Horizontal;
			Content = stackLayout;

			Random rnd = new Random();
		
			{
				int c = rnd.Next(1, 4);
				if (c == 1)
				{
					Red.BackgroundColor = Color.FromRgb(255, 0, 0);
					Green.BackgroundColor = Color.FromRgb(100, 100, 100);
					Yellow.BackgroundColor = Color.FromRgb(100, 100, 100);
				}
				else if (c == 2)
				{
					Red.BackgroundColor = Color.FromRgb(100, 100, 100);
					Green.BackgroundColor = Color.FromRgb(255, 215, 0);
					Yellow.BackgroundColor = Color.FromRgb(100, 100, 100);
				}
				else
				{
					Red.BackgroundColor = Color.FromRgb(100, 100, 100);
					Green.BackgroundColor = Color.FromRgb(100, 100, 100);
					Yellow.BackgroundColor = Color.FromRgb(0, 255, 0);
				}
			}
	}
}