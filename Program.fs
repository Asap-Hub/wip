open System

let  promptUser() =
    Console.WriteLine("(d)eposit, (w)ithdraw, e(x)ist:")
    Console.ReadLine()

let getAmount() =
    Console.WriteLine("Enter Amount to withdraw")
    Console.ReadLine() |> Decimal.Parse

[<EntryPoint>]
let main argv=
    Console.WriteLine("Hello from the transaction processor!")

    let mutable balance:decimal = 0m


    let mutable running = true
    printfn "Balance %A" balance
    while running do
      

        let action= promptUser()
        let inputAmount = getAmount()
        printfn "Available Balance is:  %A" balance

        balance <- 
        match action with 
        | "d" -> balance + inputAmount 
        | "w" -> balance - inputAmount 
        | _ -> 
            running <- action <> "x"
            balance 

    Console.WriteLine("Bye!")
    0

