package main

import (
	"fmt"
	"github.com/fatih/color"
)

func main() {
// Colors sample
color.Red("This is colorful text *_*")
color.Cyan("This is colorful text too :)")
color.Green("This is colorful text too :)")
color.Yellow("This is colorful text too :)")
color.Blue("This is colorful text too :)")
color.Magenta("This is colorful text too :)")

// Color package for GO
fmt.Print("\n Learn more in: ")
c := color.New(color.FgWhite).Add(color.Underline).Add(color.BgBlue)
c.Println("https://github.com/fatih/color")

fmt.Scanln()
}