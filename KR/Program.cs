using System;
using static System.Console;

Clear();

string [] FirstArray = new string [5] {"Hello", "Goodbay", "ok", "23", "Russia"};
string[] SecondArray = new string[FirstArray.Length];

void SearchElements (string [] FirstArray, string [] SecondArray)
{
   int count = 0;
   for (int i = 0; i < FirstArray.Length; i++)
   {
    if (FirstArray[i].Length<=3)
    {
        SecondArray[count] = FirstArray[i];
        count++;
    }
   }
}
