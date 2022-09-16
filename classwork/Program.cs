System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(System.Console.ReadLine());

int result = num*num;
System.Console.WriteLine($"Квадрат числа {num} ->{result}");



System.Console.Write("Введите число а:");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());

if (a==b*b) {
    System.Console.WriteLine("Число a является квадратом числа b");
}
else {
    System.Console.WriteLine("Число a не является квадратом числа b");
}



Console.Write("Введите номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());

if (day ==1){
    System.Console.WriteLine("Monday");
}
if (day ==2){
    System.Console.WriteLine("Tuesday");
}
if (day ==3){
    System.Console.WriteLine("Wednesday");
}
if (day ==4){
    System.Console.WriteLine("Thursday");
}
if (day ==5){
    System.Console.WriteLine("Friday");
}
if (day ==6){
    System.Console.WriteLine("Saturday");
}
if (day ==7){
    System.Console.WriteLine("Sunday");
}
else {System.Console.WriteLine("Wrong number");
}


System.Console.WriteLine("Enter number");
int n = Convert.ToInt32(Console.ReadLine());

int a = -n;

while (a<=n){
    System.Console.Write(a+" ");
    a++;
}


System.Console.WriteLine("Enter number");
int n = Convert.ToInt32(Console.ReadLine());

int lastDigit = n % 10;
Console.WriteLine(lastDigit);
