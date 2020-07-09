using GQLTest.Repository.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace GQLTest.Helpers
{
    public class ContextServiceLocator
    {
        public IPedidoQueryRepository PedidoQueryRepository => _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<IPedidoQueryRepository>();

        private readonly IHttpContextAccessor _httpContextAccessor;

        public ContextServiceLocator(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
