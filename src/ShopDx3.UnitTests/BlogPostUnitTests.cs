using System.Linq;
using Autofac.Events;
using Moq;
using NUnit.Framework;
using ShopDx3.DomainModels;
using ShopDx3.Mocks;

namespace ShopDx3.UnitTests
{

    [TestFixture, Category("UnitTests")]
    public class BlogPostUnitTests
    {
        private Mock<IEventPublisher> _mockEventPublisher;
       

        [SetUp]
        public void Setup()
        {
            _mockEventPublisher = new Mock<IEventPublisher>(MockBehavior.Strict);
           
        }

        [Test]
        public void Should_Create_Instance_Of_Title()
        {
            //Arrange
            const string lang = "en";
            const string val = "need to translate";
            
            //Act
            var sut = new Title(lang,val);

            //Assert
           
            Assert.IsInstanceOf<Title>(sut);
            Assert.AreEqual(lang, sut.lang);

        }

        [Test]
        public void Should_Create_Instance_Of_BlogPost()
        {
            var Blog = new BlogPost(DataMocks.TitleMocks().ToList(), "My blog description", DataMocks.CommentMocks().ToList());

            Assert.IsInstanceOf < BlogPost >( Blog );
        }

       

    }
}
