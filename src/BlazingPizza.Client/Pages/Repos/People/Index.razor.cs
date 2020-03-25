using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BlazingPizza.Client.Helpers;
using BlazingPizza.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazingPizza.Client.Pages.Repos.People
{
    public partial class Index
    {
        [Inject] HttpClient http { get; set; }

        [Inject] IJSRuntime js { get; set; }


        private List<Person> people { get; set; }
        private int totalPageQuantity;
        private int currentPage = 1;
        private string nameFilter = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            await LoadPeople();
        }

        private async Task SelectedPage(int page)
        {
            currentPage = page;
            await LoadPeople(page);
        }

        private async Task Filter()
        {
            currentPage = 1;
            await LoadPeople();
        }

        private async Task Clear()
        {
            nameFilter = string.Empty;
            currentPage = 1;
            await LoadPeople();
        }

        private async Task LoadPeople(int page = 1, int quantityPerPage = 50)
        {
            var httpResponse = await http.GetAsync($"api/people?page={page}&quantityPerPage={quantityPerPage}&name={nameFilter}");
            if (httpResponse.IsSuccessStatusCode)
            {
                totalPageQuantity = int.Parse(httpResponse.Headers.GetValues("pagesQuantity").FirstOrDefault());
                var responseString = await httpResponse.Content.ReadAsStringAsync();
                people = JsonSerializer.Deserialize<List<Person>>(responseString,
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
            else
            {
                // handle error
            }
        }

        private async Task DeletePerson(int personId)
        {
            //await js.DisplayMessage("削除確認","削除しますか?",SweetAlertMessageType.success);
            var personSeleted = people.First(x => x.Id == personId);
            if (await js.Confirm("ユーザー削除", $"ユーザー:{personSeleted.Name}を削除しますか?", SweetAlertMessageType.question))
            {
                await http.DeleteAsync($"api/people/{personId}");
                await LoadPeople();
            }
        }

        private void ExportAsCSV()
        {
            using (var ms = new MemoryStream())
            {
                using (var writer = new StreamWriter(ms))
                {
                    using (var csv = new CsvHelper.CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords(people);
                    }
                }

                var arr = ms.ToArray();
                js.SaveAs("people.csv", arr);
            }
        }
    }
}