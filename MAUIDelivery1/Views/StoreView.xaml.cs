using MAUIDelivery1.Models;

namespace MAUIDelivery1.Views;

public partial class StoreView : ContentPage
{
	public List<Store> Stores { get; set; }
	public StoreView()
	{
		InitializeComponent();
		LoadData();
		BindingContext = this;
	}

    private void LoadData()
    {
        Stores = new List<Store>
          {
               new Store
               {
                    Id = 1,
                    Header = "header1.jpg",
                    Logo = "logo1.jpg",
                    Name = "maugly",
                    DeliveryTime = "30 - 40 mins",
                    Minimum = 50,
                    ServiceFee = 10,
                    Rating = 4.5
               },
               new Store
               {
                    Id = 2,
                    Header = "header2.jpg",
                    Logo = "logo2.jpg",
                    Name = "Tacos MAUIciosos",
                    DeliveryTime = "1 - 3 hours",
                    Minimum = 150,
                    ServiceFee = 5,
                    Rating = 4.8
               },
               new Store
               {
                    Id = 1,
                    Header = "header3.jpg",
                    Logo = "logo3.jpg",
                    Name = "Burguermauia",
                    DeliveryTime = "15 - 30 mins",
                    Minimum = 250,
                    ServiceFee = 0,
                    Rating = 4.3
               },
               new Store
               {
                    Id = 1,
                    Header = "header4.jpg",
                    Logo = "logo4.jpg",
                    Name = "Captain MAUI",
                    DeliveryTime = "25 - 40 mins",
                    Minimum = 100,
                    ServiceFee = 25,
                    Rating = 4.6
               },
               new Store
               {
                    Id = 1,
                    Header = "header5.jpg",
                    Logo = "logo5.jpg",
                    Name = "MAUI's",
                    DeliveryTime = "45 - 60 mins",
                    Minimum = 5,
                    ServiceFee = 18,
                    Rating = 4.3
               },
          };

    }
}