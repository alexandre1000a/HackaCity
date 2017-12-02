using Microsoft.Practices.Unity;
using System.Web.Http;
using Cejen.Infra.Data;

namespace Cejen.WebApi.Controllers
{
    public class ApiControllerBase : ApiController
    {
        [Dependency]
        public IUnitOfWork UnitOfWork { get; set; }
    }
}