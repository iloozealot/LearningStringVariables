

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Justin";
lastName = "Spencer";
//filePath = "C:\\Temp\\Demo";
filePath = @"C:\Temp\Demo";
//firstName = "123";

string testString = $@"The file for {firstName} is at C:\SampleFiles";

Console.WriteLine($"Hello {firstName} {lastName}");
Console.WriteLine(filePath);
Console.WriteLine(testString);