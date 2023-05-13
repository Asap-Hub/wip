module Transaction.Driver
open System

module userConsole = 
    let private promptUser() =
        Console.WriteLine("(d)eposit, (w)ithdraw, e(x)ist:")
        Console.ReadLine()

    let private getAmount() =
        Console.WriteLine("Enter Amount to withdraw")
        Console.ReadLine() |> Decimal.Parse

    let userLoop() = 
        let mutable balance:decimal = 0m


        let mutable running = true
        while running do
            printfn "Balance %A" balance
        

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