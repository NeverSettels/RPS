using System;
using RPS.Models;
namespace RPS
{
  public class Program
  {
    
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
      if(winner=="draw")
      {
        TypeSlow("You Tied");
      }
      else
      {
        TypeSlow($"You played: {choice}");
        TypeSlow(".........");
        TypeSlow($"CPU played {adversary}");
        TypeSlow(".........");
        TypeSlow($"{winner} wins!");
      }
    }
  }
}