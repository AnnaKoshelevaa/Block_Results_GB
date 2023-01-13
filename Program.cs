using System;
using static System.Console;

Clear();

string[] array = AskArray();
string[] result = FindLessThan(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] input, int z) {
    string[] output = new string[CountLessThan(input, z)];

    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= z) 
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int z) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= z) {
            count++;
        }
    }

    return count;
}

string[] AskArray() {
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}
