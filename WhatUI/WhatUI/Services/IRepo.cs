using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WhatUI.Models;

namespace WhatUI.Services
{
    public interface IRepo
    {
        Task<IEnumerable<Message>> GetMessages();
        Task<bool> AddMessage(Message message);
    }
}
