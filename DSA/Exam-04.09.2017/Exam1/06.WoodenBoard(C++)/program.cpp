// C++ program to find minimum number of insertions
// on left side to form a palindrome.

#include <bits/stdc++.h>
using namespace std;
 
// Returns true if a string str[st..end] is palindrome
bool isPalin(char str[], int st, int end)
{
    while (st < end)
    {
        if (str[st] != str[end])
            return false;
        st++;
        end--;
    }
    return true;
}
 
// Returns count of insertions on left side to make
// str[] a palindrome
int findMinInsert(char str[], int n)
{
    // Find the largest prefix of given string
    // that is palindrome.
    for (int i=n-1; i>=0; i--)
    {         
        // Characters after the palindromic prefix
        // must be added at the beginning also to make
        // the complete string palindrome
        if (isPalin(str, 0, i))
            return (n-i-1);
    }
}
 
// Driver program
int main()
{
    char Input[]="baobab";
    printf("%d", findMinInsert(Input, strlen(Input)));
    return 0;
}
