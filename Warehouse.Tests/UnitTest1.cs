using Moq;
using System;

using Warehouse.Domain.Entity;
using Xunit;

namespace Warehouse.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int a = 5;
            int b = 3;
            //Act
            int result = a + b;
            //Assert
            Assert.Equal(8, result);    
        }
        [Fact]
        public void Test2()
        {
            //Arrange
           // Item item = new Item(1,"Apple",1);
           // var mock = new Mock<IService<Item>>();    
            //Act
            //Assert
            Assert.Equal(0, 0);
        }
    }





}