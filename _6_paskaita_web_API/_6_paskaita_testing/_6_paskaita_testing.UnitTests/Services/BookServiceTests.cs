using _6_paskaita_testing.Models;
using _6_paskaita_testing.Repositories;
using _6_paskaita_testing.Services;
using _6_paskaita_testing.UnitTests.Attributes;
using _6_paskaita_testing.UnitTests.SpecimenBuilders;
using AutoFixture;
using AutoFixture.Xunit2;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _6_paskaita_testing.UnitTests.Services
{
    public class BookServiceTests
    {
        private readonly Mock<IBookRepository> _mockRepo;
        private readonly IBookService _sut;
        private readonly Fixture _fixture;

        public BookServiceTests()
        {
            _mockRepo = new Mock<IBookRepository>();
            _fixture = new Fixture();
            _fixture.Customizations.Add(new BookSpecimenBuilder());
            _sut = new BookService(_mockRepo.Object);
        }

        [Theory, CustomData]
        public void GetBook_ExistingId_ReturnsBook(Book book)
        {
            _mockRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns(book);
            var result = _sut.GetBook(3);

            Assert.NotNull(result);
            Assert.Equal(book.Id, result.Id);
        }

        //[Fact]
        //public void GetBook_ExistingId_ReturnsBook()
        //{
        //    var book = new Book { Id = 1 };
        //    _mockRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns(book);
        //    var result = _sut.GetBook(3);

        //    Assert.NotNull(result);
        //    Assert.Equal(book.Id, result.Id);
        //}

        [Theory, AutoData]
        public void GetBook_NonExistingId_ReturnsNull(Book book)
        {
            _mockRepo.Setup(x => x.GetById(2)).Returns(book);
            var result = _sut.GetBook(3);

            Assert.Null(result);
        }

        [Theory, AutoData]
        public void GetBooks_ReturnsBooks(List<Book> books)
        {
            _mockRepo.Setup(x => x.GetAll()).Returns(books);
            var result = _sut.GetAllBooks();

            Assert.NotNull(result);
            Assert.Equal(3, result?.Count());
        }

        [Theory, AutoData]
        public void CreateBook_ValidBook_ReturnsCreatedBook(Book newBook, Book createdBook)
        {
            createdBook.Id = 100;
            _mockRepo.Setup(x => x.Add(It.IsAny<Book>())).Returns(createdBook);

            var result = _sut.CreateBook(newBook);
            Assert.Equal(100, result.Id);
        }

        [Theory, AutoData]
        public void UpdateBook_BookExists_ReturnsUpdatedBook(Book existingBook, Book updatedBook)
        {
            var updatedTitle = "new book";
            updatedBook.Title = updatedTitle;
            _mockRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns(existingBook);
            _mockRepo.Setup(x => x.Update(It.IsAny<Book>())).Returns(updatedBook);

            var result = _sut.UpdateBook(existingBook);

            Assert.NotNull(result);
            Assert.Equal(updatedTitle, updatedBook.Title);
        }

        [Theory, AutoData]
        public void UpdateBook_BookDoesntExist_ReturnsNull(Book existingBook)
        {
            _mockRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns((Book)null);

            var result = _sut.UpdateBook(existingBook);

            Assert.Null(result);
        }

        [Theory, AutoData]
        public void DeleteBook_BookExists_ReturnsTrue()
        {
            _mockRepo.Setup(x => x.Delete(It.IsAny<int>())).Returns(true);

            var result = _sut.DeleteBook(100);

            Assert.True(result);
        }

        [Theory, AutoData]
        public void DeleteBook_BookDoesNotExists_ReturnsFalse()
        {
            _mockRepo.Setup(x => x.Delete(It.IsAny<int>())).Returns(false);

            var result = _sut.DeleteBook(100);

            Assert.False(result);
        }
    }
}
