package main

import "fmt"

func main() {
	// Get count of numbers for average
	fmt.Print("Enter your number count: ")
	var count int
	var sum int
	fmt.Scanln(&count)
	// Create slice
	var numbers = make([]int, count)
	// get numbers and sum
	for i := 0; i < len(numbers); i++ {
		fmt.Printf("\nEnter number (%v): ", i+1)
		fmt.Scanln(&numbers[i])
		sum += numbers[i]
	}

	fmt.Printf("\n Average: %v \r\n", float64(sum)/float64(count))
	fmt.Scanln()
}
