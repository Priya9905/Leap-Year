namespace LeapYear
{
  public class LeapYear
  {
    public bool IsLeapYear(int year)
    {
      // eventually your code will go here
    if( year % 400 == 0){
        return true;
      }else if( year % 100 ==0){
        return false;
      }else if (year % 4 == 0){
        return true;
      }else {
        return false;
      }


    }
  }
}
