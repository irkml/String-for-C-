//methods have () and properties do not
//experiment with Console.WriteLine() Console.Write() string.Trim(), TrimEnd(), TrimStart() 
//Experiment with string.ToUpper string.ToLower 
//String.ToUpper and string.ToLower return copy string
//Trim by itself only trims for the beginning and end of the string with spaces
//string interplation means letting the program check for variables within your Console statement and it is activated using $ right outside the "" and having the string variable inside "" and in quotes.
//Examples below


Console.WriteLine("Hello, World!");
string myname = "Azhar    ";
string najibsname= "   Najib";
string yourname = "   Pinksay  ";

Console.WriteLine(myname); // simple print using console
Console.WriteLine(myname.Length); // finds the number of character in a string
Console.WriteLine($"The name Azhar has  {myname.Length} characters"); // string interpolation
string newName = yourname.Trim(); //you can trim the spaces of a string
Console.WriteLine(yourname.Trim()); // you can also print out your new trim as a variable newName
Console.WriteLine($"**** {yourname} ***"); // remember creating a new variable after trimming does not change original
string najibupper = najibsname.ToUpper(); //calls a method to change string to Uppercase

string sentencepractice = $"My name is Azhar and I am the CEO of sableSync my favorite language is C# and my favorite hobby is developing VR applications. I want to hear about {myname.Length} hobbies of yours"; 

Console.WriteLine(sentencepractice.Replace("Azhar", "full stack software developer"));
string newSentencepractice = sentencepractice.Replace("Azhar", "full stack software developer");
Console.WriteLine(newSentencepractice.Length);

Console.WriteLine(newSentencepractice.Replace("full stack software developer", "Azhar"));
Console.WriteLine(newSentencepractice.ToUpper());

//Sample program utilizing all the concepts.
Console.WriteLine("Azhar     "); //simple print
string myName = "Azhar";
Console.Write($"My name is {myName.TrimEnd()}  and it has {myName.Length} characters. Jokes it is Actually 5 Characters.");
Console.WriteLine($" It can also be written in uppercase like this {myname.Trim().ToUpper()} and now I will share a bit about my history");
string history = $"As I said my name is {myname.Trim()} and it is made up of {myname.Length} letters. {newSentencepractice.Replace("My name is", "My job description is")}";
Console.WriteLine(history);

//The best part about programs is asking questions to get a result and learn from the program.
//here is a simple program that utilizes methods suchs as string.StartWith & String.EndWith, StringContains 
//The focus here is to get a steady introduction to booleans

if(myName.StartsWith("a") == true) {
    Console.WriteLine("yey");
} else if (myName.StartsWith("Ahar") == true) {
    Console.Write("I would have never known");
} else {
    Console.WriteLine(false);
}


 var newmyname= myname.ToCharArray();
 Console.WriteLine(newmyname.Reverse());

if(myName.EndsWith("R")==true) {
    Console.Write("hmm, are you a genius");
} else if ( myName.EndsWith("ar")==false) {
    Console.WriteLine("ha, got em");
} else {
    Console.WriteLine(" I think soon we will get the hang of this if we keep experimenting");
}