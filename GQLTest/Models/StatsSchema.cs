using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GQLTest.Models
{
    public class StatsSchema : Schema
    {
        public StatsSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<StatsQuery>();
        }
    }
}
