let x = ref 10
let y = ref 20

let add () = !x + !y

let result = add()
printfn "%d" result

x := 30
y := 40

let newResult = add ()
printfn "%d" newResult