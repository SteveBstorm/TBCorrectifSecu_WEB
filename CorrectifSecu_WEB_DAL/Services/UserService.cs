using ApiToolbox;
using CorrectifSecu_WEB_DAL.Entities;
using CorrectifSecu_WEB_DAL.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifSecu_WEB_DAL.Services
{
    public class UserService : IUserRepository
    {
        private ApiRequester _requester;
        public UserService()
        {
            _requester = new ApiRequester("https://localhost:7111/api/");
        }

        public AppUser Login(string email, string password)
        {
            string json = JsonConvert.SerializeObject(new { email = email, password = password });
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (HttpResponseMessage message = _requester._httpClient.PostAsync("user/login", content).Result)
            {
                message.EnsureSuccessStatusCode();
                string response = message.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<AppUser>(response);
            }
        }

        public void Register(RegisterUserModel m)
        {
            _requester.Post(m, "user");
        }

        public IEnumerable<AppUser> GetAll()
        {
            return _requester.Get<IEnumerable<AppUser>>("user");
        }

        public UserDetails GetById(int id)
        {
            return _requester.Get<UserDetails>("user/" + id);
        }
    }
}
