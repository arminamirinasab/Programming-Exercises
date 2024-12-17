package main

import "fmt"

func main() {
	var count int
	var sum int
	fmt.Print("How many numbers you want to sum: ")
	fmt.Scanln(&count)

	for i := 1; i <= count; i++ {
		// if for Remove '+' from start
		if i != 1 {
			fmt.Print(" + ", i)
		} else {
			fmt.Print(i)
		}
		sum += i
	}

	fmt.Print(" = ", sum)
	fmt.Scanln()
}
