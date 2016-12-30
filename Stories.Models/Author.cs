using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Stories.Models
{
    public class Author
    {
        public Guid ID { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }
    }
}