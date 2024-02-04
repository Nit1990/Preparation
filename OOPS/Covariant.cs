interface ICovariant<out X>{
    X GetData();
}
class StringCovariantClass : ICovariant<int>
{
    public int GetData()
    {
        throw new NotImplementedException();
    }
  
}

interface IContravariant<in Y>{
    void SetData(Y data);
}