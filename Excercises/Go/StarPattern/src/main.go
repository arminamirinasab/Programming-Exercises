package main

import "fmt"

func main() {
	var stars int
	fmt.Print("How many star do you need: ")
	fmt.Scanln(&stars)
	// Star pattern loop
	for j := 1; j <= stars; j++ {
		for i := 0; i < j; i++ {
			fmt.Print("*")
		}
		fmt.Println()
	}

	fmt.Scanln(&stars)
}
