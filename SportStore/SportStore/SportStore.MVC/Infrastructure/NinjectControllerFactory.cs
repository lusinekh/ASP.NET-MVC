using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;
using Ninject;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entityes;

namespace SportStore.MVC.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        IKernel kernel;
        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBinding();
        }

        private void AddBinding()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product>
            {
                new Product{Name = "Gndak",Price=35.54m},
                new Product{Name = "Car",Price=7535m},
                new Product{Name = "kolbas",Price=5.4m},
                new Product{Name = "Botas",Price=85.54m},
            }.AsQueryable<Product>);
            kernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }
    }
}