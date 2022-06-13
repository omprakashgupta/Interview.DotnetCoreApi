using Microsoft.AspNetCore.Http;
using System.Net;
using System.Threading.Tasks;

namespace Interview.DotnetCoreApi.Middleware.Filter
{
	public class RequestSetOptionsMiddleware
	{
		private readonly RequestDelegate _next;

		public RequestSetOptionsMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		// Test with https://localhost:5001/Privacy/?option=Hello
		public async Task Invoke(HttpContext context)
		{
			var option = context.Request.Query["option"];
			if (!string.IsNullOrWhiteSpace(option))
			{
				context.Items["option"] = WebUtility.HtmlEncode(option);
			}
			await _next(context);
		}
	}
}
