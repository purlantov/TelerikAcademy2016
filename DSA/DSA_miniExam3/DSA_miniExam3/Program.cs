using System;

namespace DSA_miniExam3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int max = 20;

			int 
		}
	}
}


/*
# include <iostream>
# include <algorithm>

#define MAX 20
using namespace std;
 
int dp[MAX] = { 0 };

int main()
{
	int n, k;
	cin >> n >> k;
	dp[1] = k - 1;
	dp[2] = k * (k - 1);
	for (int i = 3; i <= n; i++)
	{
		dp[i] = (k - 1) * dp[i - 1] + (k - 1) * dp[i - 2];
	}
	cout << dp[n] << endl;
	return 0;
}
*/