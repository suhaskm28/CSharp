using System;class Program
{
static void Main()
{
Console.Write("Enter the number of rows for Pascal's Triangle: ");
int numRows = int.Parse(Console.ReadLine());
Console.Write("Pascal's Triangle:\n");
PrintPascalsTriangle(numRows);
}
static void PrintPascalsTriangle(int numRows)
{
for (int i = 0; i < numRows; i++)
{
for (int j = 0; j < numRows - i - 1; j++)
{
Console.Write("  ");
}for (int j = 0; j <= i; j++)
{
Console.Write("*   ");
}Console.WriteLine();
}
}
}