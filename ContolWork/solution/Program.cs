using System;
using static System.Console;

Clear();

string[] AskArray() {
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}