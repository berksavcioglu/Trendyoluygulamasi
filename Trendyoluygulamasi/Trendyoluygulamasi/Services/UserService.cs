﻿using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyoluygulamasi.Models;
using Firebase.Database.Query;


namespace Trendyoluygulamasi.Services
{
    public class UserService 
    {
        FirebaseClient _client;

        public UserService()
        {
            _client = new FirebaseClient("https://trendyoluygulamasi-default-rtdb.firebaseio.com/");
        }
        public async Task<bool> IsUserExists(string uname)
        {
            var user = (await _client.Child("Users")
                .OnceAsync<Kullanici>()).Where(u => u.Object.Username == uname).FirstOrDefault();
            return (user != null);
        }

        public async Task<bool> RegisterUser(string uname, string passwd)
        {
            if (await IsUserExists(uname) == false)
            {
                await _client.Child("Users")
                    .PostAsync(new Kullanici()
                    {
                        Username = uname,
                        Password = passwd,
                    }
                    );
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> LoginUser(string uname, string passwd)
        {
            var user = (await _client.Child("Users")
                .OnceAsync<Kullanici>()).Where(u => u.Object.Username == uname)
                .Where(u => u.Object.Password == passwd).FirstOrDefault();
            return (user != null);
        }
    }
}