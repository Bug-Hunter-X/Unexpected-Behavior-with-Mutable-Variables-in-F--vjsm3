let mutable x = 10
let mutable y = 20

let add x y =  x + y

let result = add x y
printfn "%d" result

x <- 30
y <- 40

result <- add x y
printfn "%d" result // This line will not update the result variable