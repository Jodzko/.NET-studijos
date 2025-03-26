using _6_paskaita_testing.Models;
using _6_paskaita_testing.Repositories;
using _6_paskaita_testing.Services;
using _6_paskaita_testing.UnitTests.Attributes;
using _6_paskaita_testing.UnitTests.SpecimenBuilders;
using AutoFixture;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace _6_paskaita_testing.UnitTests.Services
{
    public class AuthorServiceTests
    {
        private readonly Mock<IAuthorRepository> _mockRepo;
        private readonly IAuthorService _sut;
        private readonly Fixture _fixture;

        public AuthorServiceTests()
        {
            _mockRepo = new Mock<IAuthorRepository>();
            _fixture = new Fixture();
            //_fixture.Customizations.Add(new BookSpecimenBuilder());
            _sut = new AuthorService(_mockRepo.Object);
        }
        [Theory, CustomData]
        public void CreateAuthor_ReturnsAuthor(Author newAuthor, Author createdAuthor)
        {
            createdAuthor.Id = 100;
            _mockRepo.Setup(x => x.Add(It.IsAny<Author>())).Returns(createdAuthor);
            var result = _sut.CreateAuthor(newAuthor);
            Assert.Equal(100, result.Id);
        }

        [Theory, CustomData]
        public void GetAuthor_AuthorExists_ReturnsAuthor(Author author)
        {
            _mockRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns(author);
            var result = _sut.GetAuthor(2);
            Assert.Equal(author.Id, result.Id);
        }

        [Theory, CustomData]
        public void GetAuthors_ReturnsAuthors(List<Author> authors)
        {
            _mockRepo.Setup(x => x.GetAll()).Returns(authors);
            var result = _sut.GetAllAuthors();

            Assert.NotNull(result);
            Assert.Equal(3, result?.Count());
        }

        [Theory, CustomData]
        public void DeleteAuthor_AuthorExists_ReturnsTrue()
        {
            _mockRepo.Setup(x => x.Delete(It.IsAny<int>())).Returns(true);
            var result = _sut.DeleteAuthor(5);
            Assert.True(result);
        }
        
        [Theory, CustomData]
        public void DeleteAuthor_AuthorDoesNotExist_ReturnsFalse()
        {
            _mockRepo.Setup(x => x.Delete(It.IsAny<int>())).Returns(false);
            var result = _sut.DeleteAuthor(5);
            Assert.False(result);
        }

        [Theory, CustomData]
        public void UpdateAuthor_AuthorExists_ReturnsUpdatedAuthor(Author existingAuthor, Author updatedAuthor)
        {
            var newFullName = "Tomas Tomaitis";
            updatedAuthor.FullName = newFullName;
            _mockRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns(existingAuthor);
            _mockRepo.Setup(x => x.Update(It.IsAny<Author>())).Returns(updatedAuthor);
            var result = _sut.UpdateAuthor(existingAuthor);

            Assert.NotNull(existingAuthor);
            Assert.Equal(updatedAuthor.FullName, newFullName);
        }
        [Theory, CustomData]
        public void UpdateAuthor_AuthorDoesntExist_ReturnNull(Author author)
        {
            _mockRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns((Author)null);

            var result = _sut.UpdateAuthor(author);

            Assert.Null(result);
        }
    }
}
