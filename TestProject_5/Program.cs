//----------------Homework Lesson 3---------------------


//----------------1st task------------------------------

// Console.WriteLine("|-----------------Calculator-5000-Tron-*Started*-------|");
// Console.Write("Hello, to calculate:\nPlease enter 1st number: ");
// double operand1 = double.Parse(Console.ReadLine());
// Console.Write("Please, choose your operation from available: \n+   -   *   /   %\n\n");
// string sign =Console.ReadLine();
// if (sign != "+" && sign != "-" && sign != "*" && sign != "/" && sign != "%")
// {
//     Console.WriteLine("Chosen operation isn't supported, please, try again.");
//     Console.WriteLine("|-----------------Calculator-5000-Tron-*Finished*------|");
//     return;
// }
// Console.Write("Please, enter 2nd number: ");
// double operand2 = double.Parse(Console.ReadLine());
// double result = 0;
// if (sign == "/" && operand2 == 0)
// {
//     Console.WriteLine("You can't devide by zero, plase, try again.");
//     Console.WriteLine("|-----------------Calculator-5000-Tron-*Finished*------|");
//     return;
// }
// switch (sign)
// {
//     case "+":
//         result = operand1 + operand2;
//         Console.WriteLine($"Your calculation is: {operand1} + {operand2} = {result}");
//         break;
//     case "-":
//         result = operand1 - operand2;
//         Console.WriteLine($"Your calculation is: {operand1} - {operand2} = {result}");
//         break;
//     case "*":
//         result = operand1 * operand2;
//         Console.WriteLine($"Your calculation is: {operand1} * {operand2} = {result}");
//         break;
//     case "/":
//         result = operand1 / operand2;
//         Console.WriteLine($"Your calculation is: {operand1} / {operand2} = {result}");
//         break;
//     case "%":
//         result = operand1 % operand2;
//         Console.WriteLine($"Your calculation is: {operand1} % {operand2} = {result}");
//         break;
// }
// Console.WriteLine("|-----------------Calculator-5000-Tron-*Finished*------|");


//----------------2nd task------------------------------


// Console.Write("This program defines interval of entered value.\nPlease, enter your number from 0 to 100: ");
// double num1 = double.Parse(Console.ReadLine());
// if (num1 >= 0 && num1 <= 14)
// {
//     Console.Write($"Your number {num1} is in [0 - 14] interval.");
// }
// else if (num1 >=15 && num1 <=35)
// {
//     Console.Write($"Your number {num1} is in [15 - 35] interval.");
// }
// else if (num1 == 50)
// {
//     Console.Write($"Your number {num1} is in [36 - 50] and [50 - 100] intervals.");
// }
// else if (num1 >=36 && num1 <50)
// {
//     Console.Write($"Your number {num1} is in [36 - 50] interval.");
// }
// else if (num1 > 50 && num1 <= 100)
// {
//     Console.Write($"Your number {num1} is in [50 - 100] interval.");
// }
// else
// {
//     Console.Write($"Your number {num1} is incorrect, please, try again.");
// }


//----------------3rd task------------------------------


// using System.Text;
// Console.OutputEncoding = Encoding.Unicode;
// Console.InputEncoding = Encoding.Unicode;
// Console.WriteLine("------------------Weather Translator App------------------");
// Console.Write("Пожалуйста, введите слово о погоде на русском языке для перевода на английский язык: ");
// string word = Console.ReadLine();
// switch (word)
// {
//     case "солнце":
//         string eng1 = "sun";
//         Console.Write($"Ваше слово {word} переводится на английский язык как: {eng1}");
//         break;
//     case "облако":
//         string eng2 = "cloud";
//         Console.Write($"Ваше слово {word} переводится на английский язык как: {eng2}");
//         break;
//     case "дождь":
//         string eng3 = "rain";
//         Console.Write($"Ваше слово {word} переводится на английский язык как: {eng3}");
//         break;
//     case "туман":
//         string eng4 = "fog";
//         Console.Write($"Ваше слово {word} переводится на английский язык как: {eng4}");
//         break;
//     case "влага":
//         string eng5 = "wet";
//         Console.Write($"Ваше слово {word} переводится на английский язык как: {eng5}");
//         break;
//     case "сухо":
//         string eng6 = "dry";
//         Console.Write($"Ваше слово {word} переводится на английский язык как: {eng6}");
//         break;
//     case "лето":
//         string eng7 = "summer";
//         Console.Write($"Ваше слово {word} переводится на английский язык как: {eng7}");
//         break;
//     case "зима":
//         string eng8 = "winter";
//         Console.Write($"Ваше слово {word} переводится на английский язык как: {eng8}");
//         break;
//     case "осень":
//         string eng9 = "fall";
//         Console.Write($"Ваше слово {word} переводится на английский язык как: {eng9}");
//         break;
//     case "весна":
//         string eng10 = "spring";
//         Console.Write($"Ваше слово {word} переводится на английский язык как: {eng10}");
//         break;
//     default:
//         Console.Write($"Перевод для слова {word} отсутствует, попробуйте другое слово.");
//         break;
// }


//----------------4th task------------------------------

//----------------1st way------------------------------

// Console.WriteLine("--------------------Parity check app-------------------");
// Console.Write("Enter your number: ");
// int number1 = int.Parse(Console.ReadLine());
// int calc = number1 % 2;
// if(calc == 0)
// {
//     Console.WriteLine($"Number {number1} is even");
// }
// else
// {
//     Console.WriteLine($"Number {number1} is odd");
// }

//----------------2nd way------------------------------

// Console.WriteLine("--------------------Parity check app-------------------");
// Console.Write("Enter your number: ");
// string num1 = Console.ReadLine();
// string num2 = num1.Substring(num1.Length - 1);   //Нашёл функцию 'Substring', которая позволяет
// switch(num2)                                     //забрать последнее число из строки для сравнения
// {
//     case "0":
//         Console.Write($"Number {num1} is even");
//         break;
//     case "1":
//         Console.Write($"Number {num1} is odd");
//         break;
//     case "2":
//         Console.Write($"Number {num1} is even");
//         break;
//     case "3":
//         Console.Write($"Number {num1} is odd");
//         break;
//     case "4":
//         Console.Write($"Number {num1} is even");
//         break;
//     case "5":
//         Console.Write($"Number {num1} is odd");
//         break;
//     case "6":
//         Console.Write($"Number {num1} is even");
//         break;
//     case "7":
//         Console.Write($"Number {num1} is odd");
//         break;
//     case "8":
//         Console.Write($"Number {num1} is even");
//         break;
//     case "9":
//         Console.Write($"Number {num1} is odd");
//         break;
// }  