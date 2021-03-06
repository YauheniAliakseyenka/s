﻿using System;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TicketManagementMVC.App_Start;
using TicketManagementMVC.Infrastructure.Attributes;

namespace TicketManagementMVC
{
	public class Global : System.Web.HttpApplication
	{
		protected void Application_Start(object sender, EventArgs e)
		{
			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			ContainerConfig.Config();
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(ValidIntegerAttribute), typeof(ValidIntegerValidator));

			// override default "property value is not valid" error
			ClientDataTypeModelValidatorProvider.ResourceClassKey = "InvalidValueError";
			DefaultModelBinder.ResourceClassKey = "InvalidValueError";
		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{
			HttpCookie cultureCookie = Request.Cookies["_culture"];

			if (cultureCookie != null)
            {
                var cultureName = cultureCookie.Value;
                Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureName);
                Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            }
		}
	}
}