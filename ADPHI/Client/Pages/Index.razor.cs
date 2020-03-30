using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;

namespace ADPHI.Client.Pages
{
    public partial class Index
    {

        [Inject] private HttpClient http { get; set; }
        [Inject] private NavigationManager navi { get; set; }
        [Inject] private IJSRuntime js { get; set; }
        [Inject] private Blazored.LocalStorage.ILocalStorageService oLocalStore { get; set; }

        string SessionValue = "";
        string Message = "";

        protected override async Task OnInitializedAsync()
        {

            SessionValue = await oLocalStore.GetItemAsync<string>("MySessionValue");
        }

        public async void SaveSession()
        {
            Message = "Session Saved";
            await oLocalStore.SetItemAsync("MySessionValue", SessionValue);
        }

        public async void ClearSession()
        {
            Message = "Session Clear";
            SessionValue = "";
            await oLocalStore.ClearAsync();
        }






        private Car[] cars = new[]
        {
                new Car("Volkswagen Golf", 10000, 220),
                new Car("Volkswagen Passat", 11000, 240),
                new Car("Volkswagen Polo", 12000, 110),
                new Car("Ford Focus", 13000, 200),
                new Car("Ford Fiesta", 14000, 160),
                new Car("Ford Fusion", 15000, 260),
                new Car("Ford Mondeo", 16000, 120),
            };
    }

    public class Car
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Horsepower { get; set; }

        public Car(string name, double price, int horsepower)
        {
            Name = name;
            Price = price;
            Horsepower = horsepower;
        }
    }
}
