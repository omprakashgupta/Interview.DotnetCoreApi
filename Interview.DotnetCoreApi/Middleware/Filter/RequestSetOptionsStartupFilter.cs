using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Interview.DotnetCoreApi.Middleware.Filter
{
	public class RequestSetOptionsStartupFilter : IStartupFilter
	{
		public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
		{
			return builder =>
			{
				builder.UseMiddleware<RequestSetOptionsMiddleware>();
				next(builder);
			};
		}
	}
}
