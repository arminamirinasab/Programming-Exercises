package main

import "fmt"

func main() {
	var number int
	var sum int
	fmt.Print("Enter your number for sum digits: ")
	fmt.Scanln(&number)
	// Calculate sum
	for i := 0; number > 0; i++ {
		sum += number % 10
		number /= 10
	}
	// Show result
	fmt.Printf("\n Sum of digits of the number is: %v", sum)
	fmt.Scanln()
}
