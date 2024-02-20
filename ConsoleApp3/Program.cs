
int[] numbers = { 451, 189, 4869, 1347, 45682, 182672 };
double result = 0;
int multi = 1;
int sumOfFiveDigit = 0;
int multiOfThreeDigits = 1;
int sumOfThreeDigits = 0;
int sumOfFourDigits = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int num = numbers[i];
    int count = 0;
    while (num > 0)
    {
        count++;
        num /= 10;
    }
    if (count == 3)
    {
        sumOfThreeDigits += num;
        multiOfThreeDigits *= num;
    }
    else if (count == 4)
    {
        multi *= num;
        sumOfFourDigits += num;
    }
    else if (count == 5)
    {
        sumOfFiveDigit += num;
    }
    else if (count == 6)
    {
        result += num;
    }
}
result += sumOfThreeDigits;
result += multi;
result *= 10;
result += 7;
result += sumOfFiveDigit;
multiOfThreeDigits *= 10;
multiOfThreeDigits += 1;
result -= multiOfThreeDigits;
result -= sumOfThreeDigits;
result -= sumOfFourDigits;
result *= 0.18 * 0.03 * 0.01;
result += sumOfFiveDigit;
Console.WriteLine(result);

