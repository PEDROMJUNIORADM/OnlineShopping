﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "nadaerealmente@gmail.com";
        public string MailFromAddress = "nadaerealmente@gmail.com";
        public bool UseSsl = true;
        public string Username = "nadaerealmente@gmail.com";
        public string Password = "830524titi"; // Create your own google app password, In the video I have shown you how to create app password.
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
