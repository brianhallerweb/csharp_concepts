using System;
using System.Collections.Generic;

namespace TicTacToe
{
  class Program
  {
    class Game
    {
      public Board board = new Board();
      public UI ui = new UI();
    }
    class Board
    {
      public List<int> board = new List<int>() { 1, 2, 3 };
    }

    class UI
    {
      public void ShowBoard(Board b)
      {
        foreach (var spot in b.board)
        {
          System.Console.WriteLine(spot);
        }

      }
    }
    static void Main(string[] args)
    {
      var ticTacToe = new Game();
      ticTacToe.ui.ShowBoard(ticTacToe.board);
    }
  }
}
