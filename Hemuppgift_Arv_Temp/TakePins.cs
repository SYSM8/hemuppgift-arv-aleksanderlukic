﻿using System;

namespace Game
{
    class TakePinsGame
    {
        static void Main(string[] args)
        {
            Board board = new Board(10); // Starta med 10 stickor
            Player human = new HumanPlayer("Alex");
            Player computer = new ComputerPlayer("Datorn");

            while (!board.IsEmpty())
            {
                human.TakePins(board);
                if (board.IsEmpty())
                {
                    Console.WriteLine($"{human.Name} vinner!");
                    break;
                }

                computer.TakePins(board);
                if (board.IsEmpty())
                {
                    Console.WriteLine($"{computer.Name} vinner!");
                }
            }
        }
    }
}
