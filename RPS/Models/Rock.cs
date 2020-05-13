using System;
using System.Collections.Generic;

namespace RPS.Models
{
  public class RockPaperScissors
  {
    public static string GetWinner(string choice, string CPUchoice)
    {
      string winner = "";
      if(choice==CPUchoice)
      {
        winner = "draw";
      }
      else if((choice == "rock" && CPUchoice == "scissors") || (choice == "scissors" && CPUchoice == "paper") || (choice == "paper" && CPUchoice == "rock"))
      {
        winner = "player";
      }
      else 
      {
        winner = "cpu";
      }
     return winner;
    }

    public static string CPUMakeChoice()
    {
      List<string> options = new List<string>{"rock","paper","scissors"};
      Random random = new Random();
      int rIndex = random.Next(0, 4);
      string choosen = options[rIndex];
      return choosen;
    }






     public static void TypeSlow(string str)
    {
      for (int i = 0; i < str.Length; i++)
      {
        Console.Write(str[i]);
        System.Threading.Thread.Sleep(50);
      }
      Console.WriteLine();
    }
    public static void Main()
    {
      TypeSlow("Let's play a game of Rock, Paper, Scissors!");
      TypeSlow("Enter your choice: ");
      string choice = Console.ReadLine();
      string adversary = CPUMakeChoice();
      string winner = GetWinner(choice, adversary);
      TypeSlow($"You played: {choice}");
      TypeSlow(".........");
      TypeSlow($"CPU played {adversary}");
      
      if(winner=="draw")
      {
        TypeSlow(".........");
        TypeSlow("You Tied");
      }
      else
      {
      
        TypeSlow(".........");
        TypeSlow($"{winner} wins!");
      }
    }
  }
  

}