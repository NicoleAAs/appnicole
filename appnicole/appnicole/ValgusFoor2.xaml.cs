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
				TextColor = Color.Black,
				FontSize=30,
				FontAttributes = FontAttributes.Bold
			};
			Frame pun = new Frame()
			{
				BackgroundColor = Color.Red,
				Content = Red,
				CornerRadius = 110,
				Margin = new Thickness(130,0,130,0)
			};
			Label Yellow = new Label()
			{
				Text = "yellow",
				TextColor = Color.Black,
				FontSize = 30,
				FontAttributes = FontAttributes.Bold
			};
			Frame kol = new Frame()
			{
				BackgroundColor = Color.Yellow,
				Content = Yellow,
				CornerRadius = 110,
				Margin = new Thickness(130, 0, 130, 0)
			};
			Label Green = new Label()
			{
				Text = "green",
				TextColor = Color.Black,
				FontSize = 30,
				FontAttributes = FontAttributes.Bold
			};
			Frame gre = new Frame()
			{
				BackgroundColor = Color.Green,
				Content = Green,
				CornerRadius = 110,
				Margin = new Thickness(130, 0, 130, 0)
			};
			StackLayout stackLayout = new StackLayout()
			{
				Children = { pun, kol, gre }
			};
			Button off = new Button()
			{
				Text = "Sisse",
				BackgroundColor = Color.Green,
				BorderWidth = 2,
				FontSize = 20,
				FontAttributes = FontAttributes.Bold,
			};

			stackLayout.Orientation = StackOrientation.Vertical;
			Content = stackLayout;

			

			}
			
			}
	}
