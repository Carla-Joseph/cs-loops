using System;
using System.Collections.Generic;

namespace cs_loops
{
  class Program
  {
    static void Main(string[] args)
    {
      var suits = new List<string>() { "Spades", "Clubs", "Diamonds", "Hearts"};
      var ranks = new List<string>() {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
      var deck = new List<string> ();
      var shuffled = new List<string>();
      // create deck, maybe with loop
      for (var suitIndex = 0; suitIndex < suits.Count; suitIndex++)
        {
          for (var rankIndex = 0; rankIndex < ranks.Count; rankIndex++)
          {
            deck.Add($"{suits[suitIndex]} of {ranks[rankIndex]}");
   
          }  
        } 
        for (var deckIndex = 0; deckIndex < deck.Count; deckIndex++)
          {
            Console.WriteLine(deck[deckIndex]);
          }

      while (deck.Count > 0)
      {
         Random rnd = new Random();
         var x = rnd.Next(deck.Count);
         shuffled.Add(deck[x]);
         Console.WriteLine(deck[x]);
         deck.RemoveAt(x);
         Console.WriteLine(deck.Count);
         Console.WriteLine(shuffled.Count); 
      }

      Console.WriteLine($"{shuffled[0]}");
      Console.WriteLine($"{shuffled[1]}");
      

      // shuffle deck
      // loop within a loop
      // make n = 52 since we are dealing with 52 elements
      // for firstIndex from n - 1 down to 1 do:
      // secondIndex = random integer that is greater than or equal to 0 and LESS than firstIndex
      // Now swap the values at firstIndex and secondIndex by doing this:
      // firstValue = the value from items[firstIndex]
      // secondValue = the value from items[secondIndex]
      // items[firstIndex] = secondValue
      // items[secondIndex] = firstValue
    
    }
  }
}
