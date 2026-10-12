using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using PostServiceAppMax.Models;

namespace PostServiceAppMax.Services
{
    public class PostalApiService
    {
        private readonly HttpClient _client;
        public string ServerAddress { get; set; } = "http://localhost:5000/postings";
        public bool IsOfflineMode { get; private set; } = false;

        private static readonly List<PostalItem> _localData = new()
        {
            new PostalItem { Id = 1, From = "Тернопіль", To = "Чернівці", Content = "Електроніка та кабель", DeliveryType = 0, Weight = 1.2m, Width = 25m, Height = 10m, Depth = 18m, Value = 1500m, Price = 110m },
            new PostalItem { Id = 2, From = "Житомир", To = "Вінниця", Content = "Книги та канцтовари", DeliveryType = 0, Weight = 3.4m, Width = 30m, Height = 20m, Depth = 20m, Value = 450m, Price = 95m },
            new PostalItem { Id = 3, From = "Ужгород", To = "Запоріжжя", Content = "Запчастини для авто", DeliveryType = 1, Weight = 5.0m, Width = 45m, Height = 25m, Depth = 30m, Value = 3200m, Price = 240m },
            new PostalItem { Id = 4, From = "Івано-Франківськ", To = "Миколаїв", Content = "Спортивний інвентар", DeliveryType = 1, Weight = 2.1m, Width = 35m, Height = 15m, Depth = 20m, Value = 900m, Price = 145m }
        };

        public PostalApiService()
        {
            _client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(3)
            };
        }

        public async Task<List<PostalItem>> GetItemsAsync()
        {
            try
            {
                var response = await _client.GetAsync(ServerAddress);
                if (response.IsSuccessStatusCode)
                {
                    var items = await response.Content.ReadFromJsonAsync<List<PostalItem>>();
                    IsOfflineMode = false;
                    return items ?? new List<PostalItem>();
                }
            }
            catch
            {
                IsOfflineMode = true;
            }

            return new List<PostalItem>(_localData);
        }

        public async Task<PostalItem> AddItemAsync(PostalItem item)
        {
            try
            {
                var response = await _client.PostAsJsonAsync(ServerAddress, item);
                if (response.IsSuccessStatusCode)
                {
                    var created = await response.Content.ReadFromJsonAsync<PostalItem>();
                    if (created != null) return created;
                }
            }
            catch
            {
                IsOfflineMode = true;
            }

            int nextId = _localData.Count > 0 ? _localData.Max(x => x.Id) + 1 : 1;
            item.Id = nextId;
            _localData.Add(item);
            return item;
        }

        public async Task<bool> UpdateItemAsync(int id, PostalItem item)
        {
            item.Id = id;
            try
            {
                var response = await _client.PutAsJsonAsync($"{ServerAddress}/{id}", item);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch
            {
                IsOfflineMode = true;
            }

            var found = _localData.FirstOrDefault(x => x.Id == id);
            if (found != null)
            {
                found.From = item.From;
                found.To = item.To;
                found.Content = item.Content;
                found.DeliveryType = item.DeliveryType;
                found.Weight = item.Weight;
                found.Width = item.Width;
                found.Height = item.Height;
                found.Depth = item.Depth;
                found.Value = item.Value;
                found.Price = item.Price;
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            try
            {
                var response = await _client.DeleteAsync($"{ServerAddress}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch
            {
                IsOfflineMode = true;
            }

            _localData.RemoveAll(x => x.Id == id);
            return true;
        }
    }
}
