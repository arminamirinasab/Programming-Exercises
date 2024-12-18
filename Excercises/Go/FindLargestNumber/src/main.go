package main

import "fmt"

func main() {
	var largest int
	var number int
	fmt.Print("Enter 0 To Show Result :) \n\n")
	for i := 1; true; i++ {
		fmt.Printf(" Enter number %v: ", i)
		fmt.Scanln(&number)
		// Break loop for show result
		if number == 0 {
			break
		}
		// compare & set largest number
		if number > largest {
			largest = number
		}
	}
	fmt.Printf("\n Largest number is (%v)", largest)
	fmt.Scanln()
}
