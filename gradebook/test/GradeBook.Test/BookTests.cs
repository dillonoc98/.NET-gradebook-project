using Xunit;
using System; 

namespace GradeBook.Test;


public class BookTests
{
    [Fact]
    public void BookCalculatesAverageGrade()
    {
        //arrange section
        var x= 5 ;
        var y=2;

        var expected = 7;
        //Act section
        var actual = x + y;

        //Aseert Section
        Assert.Equal(expected,actual);

    }

    [Fact]
    public void BookTests_ShowStatistics()
    {
        //arrange section
        var book= new Book("Dillon's Grade Book");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);


        //Act section
        var result = book.ShowStatistics();

        //Aseert Section
        Assert.Equal(85.6, result.Average, 1);
        
        Assert.Equal(90.5, result.High,1);
        
        Assert.Equal(77.3, result.Low,1);

    }

}