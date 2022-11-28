using System;
using static System.Console;

Clear();

string[] AskArray() {
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}

int CountLessThan(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}