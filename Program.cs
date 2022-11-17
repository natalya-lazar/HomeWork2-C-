//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//Решение:

/*int SecondDigit (int num){
    int two_digit = num / 10;
    int second = two_digit % 10;
    return second;
}
Console.WriteLine("Введите трехзначное число: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if (user_num > 99 && user_num < 1000){
    Console.WriteLine("Вторая цифра Вашего числа " + SecondDigit(user_num));
}
else if (user_num < 0){
    Console.WriteLine("Вы ввели отрицательное число!");
}
else Console.WriteLine("Вы ввели не трехзначное число.");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//Решение:

/*void WeekEnd (int day){
    if (day > 0 && day < 8){
        if (day > 5){
            Console.WriteLine($"День недели {day} является выходным");
        }
        else Console.WriteLine($"День недели {day} не является выходным.");
    }
    else {Console.WriteLine("Вы ввели цифру вне заданного интервала.");};
}
Console.WriteLine("Введите число, обозначающее день недели.");
int user_day = Convert.ToInt32(Console.ReadLine());
WeekEnd(user_day);
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Решение:
// При вводе отрицательного числа, содержащего 3 и более цифры, показывает третью цифру со знаком минус "-". Не знаю, как это исправить. 

void ThirdDigit (int num){
    int divided;
    while (num > 999 || num < -999){
        divided = num / 10;
        num = divided;
    }
int res = num % 10;
Console.WriteLine("Третья цифра заданного числа " + res);
}
Console.WriteLine("Введите ваше число: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if (user_num <100 && user_num > -100){
 Console.WriteLine("В заданном числе нет третьей цифры.");   
}
else ThirdDigit(user_num);









