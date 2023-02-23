namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    { 
      Console.Clear();
      Loader();
    }

    static void Loader(){
      Console.WriteLine("CLI Awesome Calculator - 1.00");
      Console.WriteLine("   - Press :q if you wanna quit");
      Console.WriteLine("   - Press :c to clean the screen");
      Console.WriteLine("   - Press :i to see what I can do");
      string? operation = Console.ReadLine();
      
        if (operation.Equals(":q"))
      {
        return;
      }
      else if(operation.Equals(":c"))
      {
        Console.Clear();
        Loader();
      }
      else if(operation.Equals(":i")){
        Console.Clear();
        Console.WriteLine("CLI Awesome Calculator - 1.00");
        Console.WriteLine("   - I can sum");
        Console.WriteLine("   - I can subtract");
        Console.WriteLine("   - I can multiply");
        Console.WriteLine("   - I can divide");
        Console.WriteLine("Press :cb to come back to CLI Calculator");
        
        string? comeBack = Console.ReadLine();
        if (comeBack.Equals(":cb"))
        {
          Console.Clear();
          Loader();
        }        

      }
      {
        string[] operationData = operation.Split(' ');
        float firstNumber = float.Parse(operationData[0]);
        char operatorSignal = char.Parse(operationData[1]);
        float secondNumber = float.Parse(operationData[2]);
        Calc(firstNumber, operatorSignal, secondNumber);
      }
    }
    
    static void Calc(float firstNumber, char operatorSignal, float secondNumber){

      float result = 0;
      switch (operatorSignal)
      {
        case '+':
        result = Sum(firstNumber, secondNumber);
        Console.WriteLine(result);
        Loader();
        break;

        case '-':
        result = Subtraction(firstNumber, secondNumber);
        Console.WriteLine(result);
        Loader();
        break;

        case '*':
        result = Multiplication(firstNumber, secondNumber);
        Console.WriteLine(result);
        Loader();
        break;

        case '/':
        Division(firstNumber, secondNumber);
        Loader();
        break;
      }
    }
    
    static float Sum(float firstNumber, float secondNumber){
      return firstNumber + secondNumber;
    }

    static float Subtraction(float firstNumber, float secondNumber){
      return firstNumber - secondNumber;
    }

    static float Division(float firstNumber, float secondNumber){
      return firstNumber / secondNumber;
    }
    
    static float Multiplication(float firstNumber, float secondNumber){
      return firstNumber * secondNumber;
    }
    
  }
}