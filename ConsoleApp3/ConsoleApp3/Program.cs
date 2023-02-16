// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
#region Program to loop from 1..100 and print letters
string letter;
for(int i = 0; i < 100; i++)
{
    letter = string.Empty;

    letter = (i / 3 == 0 && i / 5 == 0) ? "fizzbuzz" : (i / 3 == 0 ? "fizz" : (i / 5 == 0 ? "buzz" : "Not dividable"));
    Console.WriteLine(letter);  
}

#endregion
#region Reverse string without using common functionalities
string word = "abcdef";
char[] chars=word.ToCharArray();
StringBuilder stringBuilder = new StringBuilder();
for (int i = chars.Length-1; i ==0; i--)
{
    stringBuilder.Append(chars[i]);
}
Console.WriteLine(stringBuilder);
#endregion