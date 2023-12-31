---
title: Compare ASP.NET Web API 2 and ASP.NET Core
description: How do web APIs differ between ASP.NET Web API 2 apps and ASP.NET Core apps?
author: ardalis
ms.date: 12/10/2021
---

# Compare ASP.NET Web API 2 and ASP.NET Core

[!INCLUDE [download-alert](includes/download-alert.md)]

ASP.NET Core offers iterative improvements to ASP.NET Web API 2, but should feel familiar to developers who have used Web API 2. ASP.NET Web API 2 was developed and shipped alongside ASP.NET MVC. This meant the two approaches had similar-but-different approaches to things like attribute routing and dependency injection. In ASP.NET Core, there's no longer any distinction between MVC and Web APIs. There's only [ASP.NET Core](/aspnet/core/introduction-to-aspnet-core), which includes support for view-based scenarios, API endpoints, Razor Pages, health checks, SignalR, and more.

In addition to being consistent and unified within ASP.NET Core, APIs built in .NET Core are much easier to test than those built on ASP.NET Web API 2. We'll cover [testing differences](testing-differences.md) in more detail in a moment. The built-in support for hosting ASP.NET Core apps, in a test host that can create an `HttpClient` that makes in-memory requests to the app, is a huge benefit when it comes to automated testing.

See [Incremental ASP.NET to ASP.NET Core migration](/aspnet/core/migration/inc/overview) for an incremental approach to migrating to ASP.NET Core.

## References

- [Migrate from ASP.NET Web API to ASP.NET Core](/aspnet/core/migration/webapi)
- [Ardalis.ApiEndpoints NuGet package](https://www.nuget.org/packages/Ardalis.ApiEndpoints/)

>[!div class="step-by-step"]
>[Previous](comparing-razor-pages-aspnet-mvc.md)
>[Next](authentication-differences.md)
