// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int result1 = num / 100;// сотни
// Console.WriteLine (result1);
int result2 = (num - (100 * result1)) / 10;
//  Console.WriteLine (result2);
int result3 = (num - (100 * result1) - (10 * result2));
Console.WriteLine(result3);
 if (num<100)
 {
Console.WriteLine("Третья цифра отсутствует ");
 }






