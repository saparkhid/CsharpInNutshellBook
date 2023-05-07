// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//SendEmail("a", "b", "hello", OnEmailSentCallback);
SendEmail2("a", "b", "hello", OnEmailSentCallback2);

Func<int, int, double> ArithmiticFunctionsDelegate;
ArithmiticFunctionsDelegate = Sum;
double result = ArithmiticFunctionsDelegate(3, 4);

double Sum(int x,int y)
{
    return x + y;
}

void SendEmail(string from,string to, string body,Action<string> callback)
{
    Console.WriteLine("Email was sent");
    callback.Invoke(DateTime.Now.ToString());
}
void SendEmail2(string from, string to, string body, Action<string,string,string> callback)
{
    Console.WriteLine("Email was sent");
    callback.Invoke(from,to,DateTime.Now.ToString());
}

void OnEmailSentCallback(string x)
{
    Console.WriteLine("Message sent on: " + x);
}
void OnEmailSentCallback2(string from,string to,string date)
{
    Console.WriteLine("Message sent on from "+ from +" to "+ to +" on date :"+ date);
}