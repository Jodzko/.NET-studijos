using _6_paskaita_testing.Repositories;
using _6_paskaita_testing.Services;
using AutoFixture;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_paskaita_testing.UnitTests.Services
{
    public class InventoryServiceTests
    {
        private readonly Mock<IBookRepository> _mockRepo;
        private readonly IInventoryService _sut
;
        private readonly Fixture _fixture;

        public InventoryServiceTests()
        {
            _mockRepo = new Mock<IBookRepository>();
            _sut = new InventoryService(_mockRepo.Object);
            _fixture = new Fixture();
        }
        [Fact]
        public void AreBooksInStock_ReturnsTrue()
        {
            // Arange
            var bookIds = new List<int> { 1, 2, 3 };
            foreach (var item in bookIds)
            {
                _mockRepo.Setup(x => x.GetById(item))
                    .Returns(new Models.Book { Id = item});
            }

            // Act
            var result = _sut.AreBooksInStock(bookIds);

            // Assert
            Assert.True(result);
        }
    }
}
