package main

import "fmt"

func main() {
	fmt.Print("\n")
	// First dash line in table
	for i := 0; i <= 50; i++ {
		fmt.Print("-")
	}
	fmt.Print("\n")

	for i := 1; i <= 10; i++ {
		fmt.Print("|")
		for j := 1; j <= 10; j++ {
			// arrange cells
			if i*j >= 10 {
				fmt.Print("")
			} else {
				fmt.Print(" ")
			}
			fmt.Printf(" %v |", i*j)
		}

		fmt.Print("\n")
		// last dash line in table
		for i := 0; i <= 50; i++ {
			fmt.Print("-")
		}
		fmt.Print("\n")
	}
	fmt.Scanln()
}
