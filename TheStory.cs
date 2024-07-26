using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      
      //The intro to the story along with the first choice.
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go invstigate?");

     Console.WriteLine("Yes or No?");
     string answer1 = Console.ReadLine();
     answer1 = answer1.ToLower();
      //Choices and the continuity based on the first answer.
     if(answer1=="no")
     {
      Console.WriteLine("No need to run and hide if we don't leave our room. It is safer in here!");
      Console.WriteLine("The End.");
     }
     else if(answer1=="yes")
     {
      Console.WriteLine("You walk into the hallway and see a light coming from under the bathroom door. You walk towards it, Do you open instantly or do you knock politly?");
      Console.WriteLine("Open or Knock?");
      string answer2= Console.ReadLine();
      answer2= answer2.ToLower();
      //The second branch of the story.
      if(answer2=="knock")
      {
       Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
       Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
       Console.WriteLine("What is your answer?");
       string answer3 = Console.ReadLine();
       answer3= answer3.ToLower();
       //The third branch of the story.
       if(answer3=="nothing"){
         Console.WriteLine("The door opens and nothing is there. You turn off the light and run back to your room and lock the door. \"Just what was that\". The End.");
       }
       else{
         Console.WriteLine("You answered incorrectly. The door is not opening, guess you will never be able to use this bathroom ever again. The End.");
       }
      }
      else if(answer2=="open")
      {
       Console.WriteLine("The door is locked?! See if one of your three spare keys will open it.");
       Console.WriteLine("Which key will you choose? 1,2 or 3?");
       string answer4= Console.ReadLine();
       answer4= answer4.ToLower();
       //The alternative third branch of the story.
       switch(answer4){
         case "1":
           Console.WriteLine("Lucky Choice! The door apens and NOTHING is there? Strange, I should stay alert. The End.");
           break;
         case "2":
           Console.WriteLine("The door does not open and the noisy sounds are gone.. What?  The End.");
           break;
         case "3":
           Console.WriteLine("The door is not openning? But the noisy sounds are still there... I am goiung to call ghost busters.");
           break;
      }
      }
     }
    }
  }
}



