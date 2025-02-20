#include <iostream>
#include <conio.h>

using namespace std;
int main()
{
  /* Non-optimal algorithm

  for (int i = 100; i < 1000; i++)
    if (i / 100 == i % 10)
      cout << i << endl;
  */

  /* Optimal algorithms

  int c = 0;
  for (int i = 101; i < 1000; i += 10)
  {
    c++;
    cout << i << endl;
    if (c > 9)
    {
      c = 0;
      i++;
    }
  }

  int x = 91;
  for (int i = 0; i < 9; i++)
    for (int j = 0; j < 10; j++)
    {
      x += 10;
      cout << x << endl;
    }
    x++;
  }
  */

  for (int i = 1; i < 10; i++)
    for (int j = 0; j < 10; j++)
      cout << (i * 100) + j * 10 + i << endl;

  return _getch();
}