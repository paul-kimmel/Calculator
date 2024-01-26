
namespace CalculatorEngine
{
  public class Token
  {
    public string Name { get { return GetName(); } }
    protected virtual string GetName() { return "empty"; }
    public override string ToString()
    {
      return Name;
    }

    protected virtual int GetPrecedence(){ return 0; }
    public int Precedence
    {
      get{ return GetPrecedence() ; }
    }

    public static Token Create(string token)
    {
      double result = 0;
      if(double.TryParse(token, out result))
        return new Operand(token);

      return TryCreateOperator(token);
    }

    public static Token TryCreateOperator(string token)
    {
      return Operator.TryCreate(token);
    }

    private static Token empty = new Token();
    public static Token Empty{ get{ return empty; }}
  }
}
