﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDemo
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int RoleId {  get; set; } 
        public string Email {  get; set; }
        public string Password { get; set; }
        public string Phone {  get; set; }
    }
}
