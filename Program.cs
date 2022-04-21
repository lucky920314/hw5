using System;

string Name;
string Gender;
string Birthday;
string StudentID;
string check ="2";

while(check == "2")
{
    Console.WriteLine("你好，現在需要你輸入你的基本資料");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("1.姓名");
    Console.WriteLine("2.性別");
    Console.WriteLine("3.出生年月日");
    Console.WriteLine("4.學號");
    Console.WriteLine("------------------------------------");

    Console.WriteLine("請問姓名是？");
    Name = Console.ReadLine();

    Console.WriteLine("請問性別是？(1)男生，(2)女生，(其他)保密");
    Gender = Console.ReadLine();

    if(Gender == "1")
    {
        Gender = "男生";
    }
    else if(Gender == "2")
    {
        Gender = "女生";
    }
    else
    {
        Gender = "保持秘密";
    }

    Console.WriteLine("請問出生年月日？");
    Birthday = Console.ReadLine();

    Console.WriteLine("學號多少？");
    StudentID = Console.ReadLine();

    Console.WriteLine("以下是您的基本資料請確認");
    Console.WriteLine("你的名字是：" + Name);
    Console.WriteLine("性別：" + Gender);
    Console.WriteLine("你的出生年月日是：" + Birthday);
    Console.WriteLine("你的學號是：" + StudentID);
    Console.WriteLine("確認資料無誤後請按 (1) 若要重新填寫請按(2)");
    check = Console.ReadLine();
}

    while(check == "1")
    {
        Console.WriteLine("感謝您的填寫，期待下次再見");
        check = "0";
    }