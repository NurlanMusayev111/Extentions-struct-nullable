using Extentions_Struct_Nullable;
using Extentions_Struct_Nullable.Helpers.Extentions;

//int a = 5;
//int b = 10;

//var res = b.ShowNums(a);

//Console.WriteLine(res);


//string str1 = "Mercedes";

//string str2 = "E-class";

//int int3 = 2023;

//var res = str1.ShowText(str2, int3);

//Console.WriteLine(res);


//Person person = new("nurlanmailcom");



//int num = 5;

//var result = num.FinfFactorial();

//Console.WriteLine(result);




//Console.WriteLine("Please enter email :");
//Email: string email = Console.ReadLine();

//if (!email.CheckEmailAndPassword("@"))
//{
//    Console.WriteLine("Email is incorrect");
//    goto Email;
//}

//Console.WriteLine("Please enter password :");
//Password: string password = Console.ReadLine();

//if (!password.CheckEmailAndPassword(@"\W"))
//{
//    Console.WriteLine("Passwors is incorrect");
//    goto Password;
//}
//Console.WriteLine("Login success");




//int num = 5;

//var result = num.PowOfNums(3);
//Console.WriteLine(result);



//string text = "922";

//Console.WriteLine(text.IsConvertStringToNumber());


//Car car;

//car.name = "bmw";

//Console.WriteLine(car.name);




static void ChecUsers(string name,string surname,int? age = null)
{
    if(name == null || surname == null || age == null)
    {
        Console.WriteLine("Please fill all inputs");
        return;
    }

    Console.WriteLine(name + " " + surname + " " + age);
}


ChecUsers("Nurlan", "Musayev");