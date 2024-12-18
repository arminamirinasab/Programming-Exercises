package main

import "fmt"

func main() {
	var number int
	for true {
		fmt.Print("Enter your number: ")
		// Get value and error handling
		_, error := fmt.Scanln(&number)
		if error != nil {
			panic("Number is invalid")
		}

		// Check odd or even
		if number%2 == 0 {
			fmt.Printf("\n %v is odd\n\n", number)
		} else {
			fmt.Printf("\n %v is even\n\n", number)
		}
	}
}
