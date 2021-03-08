package main

import "fmt"

func GCD(a int, b int) int {
	if b == 0 {
		return a
	} else {
		r := a % b
		return GCD(b, r)
	}
}

func main() {
	fmt.Println(GCD(20, 8))
}
