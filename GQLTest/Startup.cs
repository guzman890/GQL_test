
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GQLTest.Repository;
using GQLTest.Helpers;
using GQLTest.Repository.repository;
using GQLTest.Models;
using GQLTest.models;
using GraphQL.Types;
using GraphQL;
using GraphiQl;


namespace GQLTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
            services.AddHttpContextAccessor();
            services.AddSingleton<ContextServiceLocator>();
            services.AddDbContext<StatsContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddTransient<IPedidoQueryRepository, PedidoQueryRepository>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<StatsQuery>();
            services.AddSingleton<PedidoQueryType>();
            var sp = services.BuildServiceProvider();
            services.AddSingleton<ISchema>(new StatsSchema(new FuncDependencyResolver(type => sp.GetService(type))));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, StatsContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphiQl();
            app.UseMvc();
            //db.EnsureSeedData();
        }
    }
}
