float x = 15;

int y = 10;

string name = "Ilkin";

string surname = "Allahverdiyev";

bool isMarried = true;


char groupName = 'C';

bool havaIstidi = false;

//Console.WriteLine(isMarried);

//if (havaIstidi)
//{
//    Console.WriteLine("Kondisioneri yandir");
//}
//else
//{

//    Console.WriteLine("Kondisioneri sondur");
//}






//string surname = Console.ReadLine();


//Console.WriteLine("Hello, " + surname + " " + name);



//int z = 15;

//string result = "-e bolunur";


//if(z%3 == 0)
//{
//    Console.WriteLine("3"+result);
//}
//else if(z%5 == 0)
//{
//    Console.WriteLine("5"+result);
//}
//else
//{
//    Console.WriteLine("Uygun deyil");
//}

// Istifadechi reqem edir, ona uygun ay console-a yazilir.
// Mes: 1 -> Yanvar
// Qeyd: sehv reqem gonderilibse bildirilsin

//while (true)
//{

//string valueFromUser = Console.ReadLine();

//int valueFromUserConvertedToInt = int.Parse(valueFromUser);


//switch (valueFromUserConvertedToInt)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    default:
//        Console.WriteLine("Duzgun deyer daxil et");
//        break;
//}
//}



//if(valueFromUserConvertedToInt == 1)
//{
//    Console.WriteLine("Monday");
//}
//else if(valueFromUserConvertedToInt == 2)
//{
//    Console.WriteLine("Tuesday");
//}
//else if(valueFromUserConvertedToInt == 3)
//{
//    Console.WriteLine("Wednesday");
//}
//else if (valueFromUserConvertedToInt == 4)
//{
//    Console.WriteLine("Thursday");
//}
//else if (valueFromUserConvertedToInt == 5)
//{
//    Console.WriteLine("Friday");
//}
//else if (valueFromUserConvertedToInt == 6)
//{
//    Console.WriteLine("Saturday");
//}
//else if (valueFromUserConvertedToInt == 7)
//{
//    Console.WriteLine("Sunday");
//}
//else
//{
//    Console.WriteLine("Duzgun deyer daxil edin!");
//}


// 1-den 30-a qeder ededlerin cemini tapin

//int sum = 0;

//for(int i = 1; i<31; i++)
//{
//    sum += i;
//}

//Console.WriteLine(sum);

//int i = 1;
//int sum = 0;

//while (i < 31)
//{
//    sum += i;
//    i++;
//}

//Console.WriteLine(sum);


// istifadechinin daxil etdiyi ededin faktoriyalini tapin.
// 5! = 2*3*4*5


string userInput = Console.ReadLine();

int userInputToInt = int.Parse(userInput);

int result = 1;

for(int i = 2; i<= userInputToInt; i++)
{
    result *= i;
}

Console.WriteLine(result);