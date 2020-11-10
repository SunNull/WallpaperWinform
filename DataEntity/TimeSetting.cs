using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Wallpaper.DataEntity
{
    public class TimeSetting
    {
        public int ID { get; set; }
        /// <summary>
        /// 时间长度
        /// </summary>
        public decimal Time { get; set; }
        /// <summary>
        /// 设置时间
        /// </summary>
        public DateTime DatetimeSetting { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        public int UserID { get; set; }
    }
}
