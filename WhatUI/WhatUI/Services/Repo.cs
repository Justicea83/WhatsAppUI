using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WhatUI.Models;

namespace WhatUI.Services
{
    public class Repo : IRepo
    {
        Repository Repository;
        public Repo(Repository data)
        {
            Repository = data;
        }

        public async Task<bool> AddMessage(Message message)
        {
            await Repository.Messages.AddAsync(message);
            await Repository.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Message>> GetMessages()
        {
            return await Repository.Messages.ToListAsync();
        }
    }
}
