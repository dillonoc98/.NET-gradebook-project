using Xunit;
using System; 

namespace GradeBook.Test;


public class TypeTests
{
    [Fact]
    public void ValueTypeAlsoPassByValue()
    {
        var x= GetInt();
        Assert.Equal(x, 3);
        
        SetInt(ref x);
        
        Assert.Equal(x, 33);
    }

    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
     var book1= GetBook("Book 1");
     var book2= book1;

     Assert.Same(book1, book2);
     Assert.True(Object.ReferenceEquals(book1,book2));
    }

    [Fact]
    public void CSharpCanPassByValue()
    {
     var book1= GetBook("Book 1");
     SetBookName(book1, "New Name");

     Assert.Equal("New Name", book1.Name);
    }

    [Fact]
    public void CSharpCanPassByRef()
    {
     var book1= GetBook("Book 1");
     //Day to day you will not pass a value by reference. 
     GetBookSetName(ref book1, "New Name");

     Assert.Equal("New Name", book1.Name);
    }

    [Fact]
    public void GetBookReturnsSameObjects()
    {
     var book1= GetBook("Book 1");
     var book2= GetBook("Book 2");

     Assert.Equal("Book 1", book1.Name);
     Assert.Equal("Book 2", book2.Name);
    }

    [Fact]
    public void StringBehavesLikeValueType()
    {
        string name ="Test";
        var nameUpperCase = MakeUpperCase(name);
        Assert.Equal(nameUpperCase, "TEST");
    }

    private string MakeUpperCase(string name)
    {
        return name.ToUpper();
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }
    
    private void GetBookSetName(ref Book book, string newName)
    {
        book.Name=newName;
    }
    private int GetInt()
    {
        return 3;
    }
    private void SetInt(ref int z)
    {
        z=33;
    }
    private void SetBookName(Book book, string newName)
    {
        book.Name=newName;
    }

}