/*
Carlos Felipe
10/19/22
Mini Challenge #5 - Mad Lib
This program asks the user for various verbs, nouns, and adjectives. It then prints out a predetermined story where the blank spaces are filled in with the user's input.
*/

Console.Clear();
bool run = true;

while(run){

bool wordOne = true;
bool wordTwo = true;
bool wordThree = true;
bool wordFour = true;
bool wordFive = true;
bool wordSix = true;
bool wordSeven = true;
bool wordEight = true;
bool wordNine = true;
bool wordTen = true;
bool wordEleven = true;

string adjOne = "";
string adjTwo = "";
string adjThree = "";
string adjFour = "";
string adjFive = "";
string verbOne = "";
string verbTwo = "";
string nounOne = "";
string nounTwo = "";
string nounThree = "";
string nounFour = "";
   
    while(wordOne){
Console.Write("Give me an adjective: ");
adjOne = Console.ReadLine().ToLower();
bool isadjOne = Int32.TryParse(adjOne, out int num);
if(isadjOne){
    Console.Write("That is not a word.\nTry again. ");
}
else{
    wordOne = false;
}
}

    while(wordTwo){
Console.Write("Now a verb please: ");
verbOne = Console.ReadLine().ToLower();
bool isverbOne = Int32.TryParse(verbOne, out int num);
if(isverbOne){
    Console.Write("That is not a word.\nTry again. ");
}
else{
    wordTwo = false;
}
}

    while(wordThree){
Console.Write("Give me another adjective: ");
adjTwo = Console.ReadLine().ToLower();
bool isadjTwo = Int32.TryParse(adjTwo, out int num);
if(isadjTwo){
    Console.WriteLine("That is not a word.\nTry again. ");
}
else{
    wordThree = false;
}
}
    while(wordFour){
Console.Write("I need a noun: ");
nounOne = Console.ReadLine();
bool isnounOne = Int32.TryParse(nounOne, out int num);
if(isnounOne){
    Console.WriteLine("That is not a word.\nTry again. ");
} 
else{
    wordFour = false;
}
}
    while(wordFive){
Console.Write("Now I need a verb: ");
verbTwo = Console.ReadLine().ToLower();
bool isverbTwo = Int32.TryParse(verbTwo, out int num);
if(isverbTwo){
    Console.WriteLine("That is not a word.\nTry again. ");
} 
else{
    wordFive = false;
}
}

    while(wordSix){
Console.Write("Give me an adjective: ");
adjThree = Console.ReadLine().ToLower();
bool isadjThree = Int32.TryParse(adjThree, out int num);
if(isadjThree){
    Console.WriteLine("That is not a word.\nTry again. ");
}
else{
    wordSix = false;
}
}

    while(wordSeven){
Console.Write("Do have a noun for me?: ");
nounTwo = Console.ReadLine();
bool isnounTwo = Int32.TryParse(nounTwo, out int num);
if(isnounTwo){
    Console.WriteLine("That is not a word.\nTry again. ");
}
else{
    wordSeven = false;
}
}

    while(wordEight){
Console.Write("One adjective: ");
adjFour = Console.ReadLine().ToLower();
bool isadjFour = Int32.TryParse(adjFour, out int num);
if(isadjFour){
    Console.WriteLine("That is not a word.\nTry again. ");
}
else{
    wordEight = false;
}
}

    while(wordNine){
Console.Write("Another adjective: ");
adjFive = Console.ReadLine().ToLower();
bool isadjFive = Int32.TryParse(adjFive, out int num);
if(isadjFive){
    Console.WriteLine("That is not a word.\nTry again. ");
}
else{
    wordNine = false;
}
}

    while(wordTen){
Console.Write("Noun please: ");
nounThree = Console.ReadLine();
bool isnounThree = Int32.TryParse(nounThree, out int num);
if(isnounThree){
    Console.WriteLine("That is not a word.\nTry again. ");
}
else{
    wordTen = false;
}
}

    while(wordEleven){
Console.Write("Finally a noun: ");
nounFour = Console.ReadLine();
bool isnounFour = Int32.TryParse(nounFour, out int num);
if(isnounFour){
    Console.WriteLine("That is not a word.\nTry again. ");
}
else{
    wordEleven = false;
}
}

Console.WriteLine($"Our school cafeteria has really {adjOne} food. Just thinking about it makes my stomach {verbOne}. The spaghetti is {adjTwo} and tastes like {nounOne}. One day, I swear one of the meatballs started to {verbTwo}! The turkey tacos are totally {adjThree} and look kind of like old {nounTwo}. My friend Dana actually likes the meatloaf, even though it's {adjFour} and {adjFive}. I call it 'mystery meatloaf' and think it's really made out of {nounThree}. My dad said he'd make my lunches, but the first day, he actually made me a sandwich out of {nounFour} and peanut butter. I think I'd rather take my chances with the cafeteria.");

Console.Write("Thanks for playing! Want to go again?\nType YES or NO: ");
string runChoice = Console.ReadLine().ToLower().ToUpper();
while(runChoice != "YES" && runChoice != "NO"){
    Console.WriteLine("I said 'YES' or 'NO'\nTry again. ");
    runChoice = Console.ReadLine().ToLower().ToUpper();
}
if(runChoice == "NO"){
    run = false;
    Console.WriteLine("Okay maybe next time.");
}
else if(runChoice == "YES"){
    run = true;
}
}









