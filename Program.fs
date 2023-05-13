open System

[<EntryPoint>]

let main argv=
    Console.WriteLine("Hello from the transaction processor!")

    Transaction.Driver.userConsole.userLoop()
 

    Console.WriteLine("Bye!")
    0

