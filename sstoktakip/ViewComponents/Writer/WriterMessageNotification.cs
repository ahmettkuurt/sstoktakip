﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace sstoktakip.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        Message2Manager mm = new Message2Manager(new EFMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id = 2;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
