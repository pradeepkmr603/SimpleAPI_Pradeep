using  SimpleAPI.Controllers;
namespace SimpleAPI.Tests;

public class UnitTest1
{
     ValuesController controller = new ValuesController();
    [Fact]
    public void GetReturnsCorrectNumber()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("sandeep", returnValue);
    }

    // ValuesController valuesController = new ValuesController();     //Arrange
   
    // [Fact]
    // public void GetReturnedCollectNumber()
    // {
    //     var getValue = valuesController.GetName();                     //Act
       
    //     Assert.Equal("pradeep kumar", getValue);                        //Assert
    // }
}   