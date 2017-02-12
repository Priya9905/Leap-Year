using Xunit;
namespace LeapYear
{
  public class LeapYearTest
  {
    [Fact]
    public void IsLeapYear_ForNumberDivisibleByFour_true()
    {
      // eventually your testing code will go here
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(true,testLeapYear.IsLeapYear(2016));

    }
    [Fact]
    public void IsLeapYear_ForNumberDivisibleByHundred_false()
    {
      // eventually your testing code will go here
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(false,testLeapYear.IsLeapYear(1900));

    }
    [Fact]
    public void IsLeapYear_ForNumberDivisibleByFourHundred_true()
    {
      // eventually your testing code will go here
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(true,testLeapYear.IsLeapYear(2000));

    }
  }
}
