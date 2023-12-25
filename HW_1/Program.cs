Console.Write("Enter a number 1: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write("Enter a number 2: ");
int secondNumber = int.Parse(Console.ReadLine()!);
//static void CompareNumbers(int firstNumber, int secondNumber);
{
    // Введите свое решение ниже
    if (firstNumber == secondNumber){
    Console.WriteLine("Введенные числа равны `" + firstNumber + "`");
 } else {
    if (firstNumber < secondNumber) {
        Console.WriteLine("Первое число `" + firstNumber + "` меньше чем второе число `" + secondNumber + "` ");
    } else {
        Console.WriteLine("Первое число `" + firstNumber + "` больше чем второе число `" + secondNumber + "` ");
    }
    }

    

    
}
