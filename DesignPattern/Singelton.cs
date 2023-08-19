namespace Singelton{

public class Singelton{

private static Singelton? Instance = null;
private static readonly Object _lock = new Object();
    public static Singelton GetInstance(){

    if(Instance == null){
        lock(_lock){

        Instance = new Singelton();
        }
    }
    return Instance;
}
     private Singelton(){}

    }
}