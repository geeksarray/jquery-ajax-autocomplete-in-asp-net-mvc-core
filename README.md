# jQuery AJAX AutoComplete In ASP.NET MVC Core
This tutorial explains how to use the jQuery AJAX AutoComplete feature in your ASP.NET MVC Core application. For this, you will use Visual Studio 2019, NET5, EF Core, Web API controller, and AdventureWorks database of SQL Server.

You will use jQuery AJAX call to Web API controller and render JSON result. This also explains how to secure your AJAX requests using AntiForgeryToken.

Files

1. **[Web API Controller](https://github.com/geeksarray/jquery-ajax-autocomplete-in-asp-net-mvc-core/blob/main/jquery-autocomplete-aspnet-mvc-core/Areas/Purchasing/Controllers/VendorAPIController.cs)** - having Web API method with name Search to fetch vendor names from database.

1. **[VendorContext](https://github.com/geeksarray/jquery-ajax-autocomplete-in-asp-net-mvc-core/blob/main/jquery-autocomplete-aspnet-mvc-core/Areas/Purchasing/Models/VendorContext.cs)** - inherited from Entity Framework DataContext, used for configuring Model creation.

1. **[Site.js](https://github.com/geeksarray/jquery-ajax-autocomplete-in-asp-net-mvc-core/blob/main/jquery-autocomplete-aspnet-mvc-core/wwwroot/js/site.js)** - having code for AutoComplete text box that triggers jQuery AJAX call.

After Implementation, you will see output like

![jquery ajax autocomplete aspnet mvc core](https://geeksarray.com/images/blog/jquery-ajax-autocomplete-aspnet-mvc-core.png)

For more information see - https://geeksarray.com/blog/jquery-ajax-autocomplete-in-asp-net-mvc-core
