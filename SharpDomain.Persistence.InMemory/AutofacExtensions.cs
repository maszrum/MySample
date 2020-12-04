﻿using System.Reflection;
using Autofac;
using SharpDomain.Persistence.InMemory.Datastore;

namespace SharpDomain.Persistence.InMemory
{
    public static class AutofacExtensions
    {
        public static ContainerBuilder RegisterInMemoryPersistence(this ContainerBuilder containerBuilder)
        {
            return containerBuilder
                .RegisterRepositories()
                .RegisterInMemoryDatasource();
        }
        
        private static ContainerBuilder RegisterRepositories(this ContainerBuilder containerBuilder)
        {
            var assembly = typeof(AutofacExtensions).GetTypeInfo().Assembly;
            
            containerBuilder
                .RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.Contains("Repository") && !t.IsAbstract)
                .InstancePerLifetimeScope()
                .AsImplementedInterfaces();
            
            return containerBuilder;
        }
        
        private static ContainerBuilder RegisterInMemoryDatasource(this ContainerBuilder containerBuilder)
        {
            containerBuilder
                .RegisterType<InMemoryDatastore>()
                .As<IDatastore>()
                .InstancePerLifetimeScope();
            
            return containerBuilder;
        }
    }
}