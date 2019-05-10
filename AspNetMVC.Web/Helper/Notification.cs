using AspNetMVC.Web.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Web.Helper
{
    public static class Notification
    {
        public static void SendNotification(Controller controller,string msg, int type = 0)
        {
            string alertType = "alert ";
            switch (type)
            {
                case (int)NotificationEnum.error:
                    alertType += "alert-danger";
                    break;

                case (int)NotificationEnum.success:
                    alertType += "alert-success";
                    break;

                default:
                    alertType += "alert-info";
                    break;
            }

            controller.TempData["msg"] = String.Format("<div class='{0}'>{1}</div>", alertType, msg);
        }
    }
}