using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Stories.Models
{
    public class Account
    {
        /// <summary>
        /// 账户名（唯一标识）
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// 登陆的密码
        /// </summary>
        public byte[] Password { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string PhoneNum { get; set; }
    }
}