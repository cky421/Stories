using System;
using System.Collections.Generic;

namespace Stories.Models
{
    public class Blog
    {
        public Guid ID { get; set; }

        /// <summary>
        /// 翻译后的title
        /// </summary>
        public string TranslationTitle { get; set; }

        /// <summary>
        /// 博客题目
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PublishDate { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public Author Author { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public Category Category { get; set; }
    }
}
