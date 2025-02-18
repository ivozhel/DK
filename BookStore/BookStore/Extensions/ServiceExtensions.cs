﻿using BookStore.BL.Interfaces;
using BookStore.BL.Providers;
using BookStore.BL.Providers.Interfaces;
using BookStore.BL.Services;
using BookStore.DL.Interfaces;
using BookStore.DL.Repositories.InMemoryRepos;
using BookStore.DL.Repositories.MongoRepos;
using BookStore.DL.Repositories.MsSQL;

namespace BookStore.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterRepos(this IServiceCollection services)
        {
            services.AddSingleton<IPersonRepo, PersonInMemoryRepo>();
            services.AddSingleton<IAuthorRepo, AuthorRepository>();
            services.AddSingleton<IBookRepo, BookRepository>();
            services.AddSingleton<IEmployeeRepo, EmployeeRepository>();
            services.AddSingleton<IPurchaseRepo, PurchaseRepository>();
            services.AddSingleton<IShoppingCartRepo, ShoppingCartRepository>();
            //services.AddSingleton<IUserRepo, UserStore>();
            return services;
        }
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IPersonService, PersoneService>();
            services.AddSingleton<IEmplyeeService, EmplyeeService>();
            services.AddSingleton<IPurchaseService, PurchaseService>();
            services.AddTransient<IIdentityService, IdentityService>();
            services.AddSingleton<IShoppingCartService, ShoppingCartService>();
            services.AddSingleton<IBookService, BookService>();
            services.AddSingleton<IAdditionalInfoClientProvider, AdditionalInfoClientProvider>();
            //services.AddSingleton<IUserService, EmplyeeService>();
            //services.AddSingleton<IAuthorService, AuthorService>();
            return services;
        }

    }
}
