#include <iostream>
using namespace std;

int main()
{
  for (; true;)
  {
    int command = 0;
    cout << "1. Plus" << endl;
    cout << "2. Minus" << endl;
    cout << "3. Division" << endl;
    cout << "4. Multiplication" << endl;
    cout << " Enter your command: ";
    cin >> command;

    int num1 = 0;
    int num2 = 0;
    switch (command)
    {
      // Plus
    case 1:
      cout << "Enter number one: ";
      cin >> num1;
      cout << "Enter number two: ";
      cin >> num2;
      cout << to_string(num1) + " + " + to_string(num2) + " = " + to_string(num1 + num2) << endl;
      cout << endl;
      break;
      // Minus
    case 2:
      cout << "Enter number one: ";
      cin >> num1;
      cout << "Enter number two: ";
      cin >> num2;
      cout << to_string(num1) + " - " + to_string(num2) + " = " + to_string(num1 - num2) << endl;
      cout << endl;
      break;
      // Division
    case 3:
      cout << "Enter number one: ";
      cin >> num1;
      cout << "Enter number two: ";
      cin >> num2;
      cout << to_string(num1) + " / " + to_string(num2) + " = " + to_string(num1 / num2) << endl;
      cout << endl;
      break;
      // Multiplication
    case 4:
      cout << "Enter number one: ";
      cin >> num1;
      cout << "Enter number two: ";
      cin >> num2;
      cout << to_string(num1) + " * " + to_string(num2) + " = " + to_string(num1 * num2) << endl;
      cout << endl;
      break;
    default:
      cout << endl
           << "Your command is invalid !" << endl;
      break;
    }
  }
}