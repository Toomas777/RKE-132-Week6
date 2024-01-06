string hello = "  you are the champions?";

int stringLength = hello.Length; 

hello = hello.Trim();

char firstletter = hello[0];
Console.WriteLine(firstletter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstletter = hello[0];
Console.WriteLine(firstletter);

Console.WriteLine(hello);






//nt wordCounter = 1;

//string trimmedString = hello.Trim();    







//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");