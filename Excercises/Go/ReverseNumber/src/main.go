package main
import "fmt"

func main() {
	var number int;
	fmt.Print("Enter your number to reverse: ")
	fmt.Scanln(&number)

	fmt.Print("\n Your reversed number is: ")
	// Reverse number with devide
	for i := 0; number > 0; i++ {
		fmt.Print(number % 10)
		number /= 10
	}

	fmt.Scanln()
}
