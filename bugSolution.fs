let mutable x = 0
let y = ref 0 // Use a reference cell for mutable behavior

// Assign initial value to y
!y <- x + 1

x <- 10

printf "%d" !y // Accessing value requires dereferencing using ! operator
printf "%d" x