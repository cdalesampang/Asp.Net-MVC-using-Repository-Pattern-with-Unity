using System.Web.Mvc;
using AspNetMVC.BAL.Interfaces;
using AspNetMVC.BAL.Services;
using AspNetMVC.DAL.Interfaces;
using AspNetMVC.DAL.Repositories;
using AspNetMVC.DAL.Shared;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

namespace AspNetMVC.Web
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>(); 

            container.RegisterType<ICourseRepository, CourseRepository>();
            container.RegisterType<ICourseService, CourseService>();

            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<IStudentService, StudentService>();

            container.RegisterType<IStudentCourseRepository, StudentCourseRepository>();
            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}