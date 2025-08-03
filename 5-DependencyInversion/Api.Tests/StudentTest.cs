using Xunit;
using DependencyInversion.Controllers;
using Moq;
using DependencyInversion;
using Repository;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Api.Tests;

public class StudentTest 
{
    [Fact]
    public void GetStudent()
    {
        // Arrange
        var logbookMock = new Mock<ILogbook>();
        var studentRepositoryMock = new Mock<IStudentRepository>();
        studentRepositoryMock.Setup(p => p.GetAll())
            .Returns(new List<Student>()
            {
                new Student(1, "Pepito Pérez", new List<double>() { 3, 4.5 }),
                new Student(2, "Mariana Lopera", new List<double>() { 4, 5 }),
                new Student(3, "José Molina", new List<double>() { 2, 3 })
            });

        var studentController = new StudentController(studentRepositoryMock.Object, logbookMock.Object);

        // Act
        var resultGetStudents = studentController.Get();

        // Assert
        Assert.NotNull(resultGetStudents);
        Assert.Equal(3, resultGetStudents.Count());
    }
}