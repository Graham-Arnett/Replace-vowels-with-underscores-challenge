namespace Replacechars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! This is my character replacing program!");
            Console.WriteLine(); //this adds a line between here and the below console.write, not really needed I just like a space after the caption

            Program program = new Program();

            //here we will prompt for a sentence
            Console.Write("Please enter a sentence. Try to have some fun with it: ");
            string sentence = Console.ReadLine(); //we're entering a string, so a normal readline is fine
            //I suppose the altered string will probably be called newSentence or something similar

            string replacedSentence = program.ReplaceVowelsWithUnderscores(sentence);

            //display end result
            Console.Write($"Your modified sentence is: {replacedSentence}");
            
        }
        public String ReplaceVowelsWithUnderscores(String s)
        {
            //I am guessing I need a strng array with a list of vowels, update, turns out using a string with all the vowels works
            //I guess a string is basically an array of chars, but I didn't expect that to actually work
            
            string vowels = "aeiouAEIOU"; //for the purposes of this I am not counting y, I had initially expected having to use toupper and tolower, but turns out just typing lower and uppercase works fine

            //making an array for the underscoreschar, not a fan of the autocomplete
            char[] underScoredArray = new char[s.Length];

            for (int v = 0; v < s.Length; v++) { //I know i is traditional with for loops, but I'm using v for vowels because that makes sense to me
                if (vowels.IndexOf(s[v]) >= 0) 
                {
                    underScoredArray[v] = '_'; //name is straight forward its an array of underscores
                }
                else
                {
                    underScoredArray[v] = s[v];
                }
            }
           // char underScore = '_'; //if I do this right this should be what we plug in for vowels

            return new string(underScoredArray);
        }
    }
}
