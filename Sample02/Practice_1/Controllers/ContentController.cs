using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Practice_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Controllers
{
    public class ContentController:Controller
    {
        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        /// 
        private readonly Content contents;
        public ContentController(IOptions<Content> option) //构造函数注入
        {
            contents = option.Value;
        }
        public IActionResult Index()
        {

            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }


    }
}
