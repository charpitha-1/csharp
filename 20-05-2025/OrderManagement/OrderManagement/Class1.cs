using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomAttributes;

namespace OrderManagement
{
    //[Serializable]
    [DebugInfoAttr("critical issue",23,Description ="Detailed desc of issue")]
    [DebugInfoAttr("critical issue1", 25, Description = "Detailed desc of issue")]

    public class User
    {
       

        private static int UserCount=0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public User() {
            Id = 1;
            Name = "Default";
            Email = "name@gmail.com";
            ++UserCount;
        }
        public User(int uid, string uname, string uemail)
        {
            Id = uid;
            Name = uname;
            Email = uemail;
            ++UserCount;
        }
        public string GetUserInfo()
        {
            return $"{Id}  -{Name}--{Email}";
        }
        public static int GetUserCount()
        {
            return UserCount;
        }
    }
}
