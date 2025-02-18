let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 which is expected

//Corrected version:
let swap3 (x:byref<int>) (y:byref<int>) = 
    let temp = x
    x <- y
    y <- temp

let x2 = ref 10
let y2 = ref 20
swap3 x2 y2
printf "%d %d" (!x2) (!y2) //This will print 20 10

//alternative version
let swap4 (x:int) (y:int) = 
    (y,x)

let x3 = 10
let y3 = 20
let (x4, y4) = swap4 x3 y3
printf "%d %d" x4 y4 //This will print 20 10