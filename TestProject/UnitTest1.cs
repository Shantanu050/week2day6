using System;
using System.Reflection;
using NUnit.Framework;
using dotnetapp.Models;
using System.ComponentModel.DataAnnotations;
using dotnetapp.Controllers;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Moq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace dotnetapp.Tests
{
    [TestFixture]
    public class PostTests
    {
        private Type _productType;

        private OrderController _OrderController;
        private DbContextOptions<AppDbContext> _dbContextOptions;


        [SetUp]
        public void Setup()
        {
            _dbContextOptions = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryTestDatabase")
                .Options;

            var dbContext = new AppDbContext(_dbContextOptions);
            _OrderController = new OrderController(dbContext);

        }

        [TearDown]
        public void TearDown()
        {
            //_postcontroller = null;
        }

           [Test]
        public void Session_2_TestProduct_ClassExists()
        {
            // Load the assembly at runtime
            Assembly assembly = Assembly.Load("dotnetapp");
            Type postType = assembly.GetType("dotnetapp.Models.Product");
            Assert.NotNull(postType, "Product class does not exist.");
        }
        [Test]
        public void Session_2_TestCategory_ClassExists()
        {
            // Load the assembly at runtime
            Assembly assembly = Assembly.Load("dotnetapp");
            Type postType = assembly.GetType("dotnetapp.Models.Category");
            Assert.NotNull(postType, "OrderCard class does not exist.");
        }
        [Test]
        public void Session_2_TestOrder_ClassExists()
        {
            // Load the assembly at runtime
            Assembly assembly = Assembly.Load("dotnetapp");
            Type postType = assembly.GetType("dotnetapp.Models.Order");
            Assert.NotNull(postType, "AppDbContext class does not exist.");
        }
        [Test]
        public void Session_2_TestCustomer_ClassExists()
        {
            // Load the assembly at runtime
            Assembly assembly = Assembly.Load("dotnetapp");
            Type postType = assembly.GetType("dotnetapp.Models.Customer");
            Assert.NotNull(postType, "Customer class does not exist.");
        }
        [Test]
        public void Session_2_TestOrderDetail_ClassExists()
        {
            // Load the assembly at runtime
            Assembly assembly = Assembly.Load("dotnetapp");
            Type postType = assembly.GetType("dotnetapp.Models.OrderDetail");
            Assert.NotNull(postType, "OrderDetails class does not exist.");
        }
        [Test]
        public void Session_2_TestOrdersDbContext_ClassExists()
        {
            // Load the assembly at runtime
            Assembly assembly = Assembly.Load("dotnetapp");
            Type postType = assembly.GetType("dotnetapp.Models.OrdersDbContext");
            Assert.NotNull(postType, "OrdersDbContext class does not exist.");
        }

        [Test]
        public void Session_2_TestDiscountPropertyType_OrderDetail_table()
        {
            Assembly assembly = Assembly.Load("dotnetapp");
            _productType = assembly.GetType("dotnetapp.Models.OrderDetail");
            PropertyInfo DiscountProperty = _productType.GetProperty("Discount");
            Assert.NotNull(DiscountProperty, "Discount property does not exist.");
            Assert.AreEqual(typeof(float), DiscountProperty.PropertyType, "Discount property should be of type float.");
        }

        [Test]
        public void Session_2_TestPicturePropertyType_Category_Table()
        {
            Assembly assembly = Assembly.Load("dotnetapp");
            _productType = assembly.GetType("dotnetapp.Models.Category");
            PropertyInfo PictureProperty = _productType.GetProperty("Picture");
            Assert.NotNull(PictureProperty, "Picture property does not exist.");
            Assert.AreEqual(typeof(byte[]), PictureProperty.PropertyType, "Picture property should be of type byte[].");
        }

        [Test]
        public void Session_2_TestMigrationExists()
        {
            bool viewsFolderExists = Directory.Exists(@"/home/coder/project/workspace/dotnetapp/Migrations");

            Assert.IsTrue(viewsFolderExists, "Migrations does not exist.");
        }


    }
}
