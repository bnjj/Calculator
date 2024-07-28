namespace Calculadora
{
    public class CalculatorLogic : ICalculatorLogic
    {
        public double Calcute(string num1,string num2,string operation)
        {
            double result = 0;
            double number1 = double.Parse(num1);
            double number2 = double.Parse(num2);

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 != 0)
                        result = number1 / number2;
                    else
                        throw new Exception("Cant Divide by 0.");
                    break;
            }
            return result;
        }
    }
}
