using Domain.Repository;
using Infra.Context;
using Infra.Repository.UsuarioRepository;
using Infra.Repository.DocumentosUsuarioRepository;
using Microsoft.Extensions.DependencyInjection;
using Service;
using Infra.Repository.TemaRepository;
using Infra.Repository.EditaisRepository;

namespace Infra.Ioc
{
    public static class ServiceConfiguration
    {
        public static void RegisterServices(IServiceCollection services)
        {

            services.AddDbContext<PostgresContext>();

            //Repositorios
            services.AddScoped<IUsuarioRepo, UsuarioRepo>();
            services.AddScoped<ITemaRepo, TemaRepo>();
            services.AddScoped<IDocumentosUsuarioRepo, DocumentosUsuarioRepo>();
            services.AddScoped<IEditaisRepo, EditaisRepo>();

            //Servicos
            services.AddScoped<Servico>();
        }
    }
}
