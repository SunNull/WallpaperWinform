using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper.DataEntity
{
    public class DiaryContent
    {
        public int ID { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 日记内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 天气
        /// </summary>
        public string Wather { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        public int UserID { get; set; }
    }
}
