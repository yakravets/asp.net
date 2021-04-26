using Autofac;
using Autofac.Integration.Mvc;
using BookStore.BLL.Implementation;
using BookStore.BLL.Interfaces;
using BookStore.DAL;
using BookStore.DAL.Repository;
using BookStore.DAL.Repository.Interface;
using System.Data.Entity;
using System.Web.Mvc;
using AutoMapper;

namespace BookStore.UI.Utils
{
    public static class AutofacConfiguration
    {
        public static void Configurate()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<ApplicationContext>().As<DbContext>();
            builder.RegisterGeneric(typeof(EFRepository<>)).As(typeof(IGenericRepository<>));
            builder.RegisterType<GameService>().As<IGameService>();

            var configurationManager = new MapperConfiguration(cfg => cfg.AddProfile(new AutomapperConfiguration()));
            builder.RegisterInstance(configurationManager.CreateMapper());

            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}