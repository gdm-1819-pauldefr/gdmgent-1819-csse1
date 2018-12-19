namespace Singleton {
  public class DbConnect
  {
    private static DbConnect instance;

    protected DbConnect()
    {

    }

    public static DbConnect Instance() {
      if(instance == null) 
      {
        instance = new DbConnect();
      } 
      
      return instance;
    }
  }
}
