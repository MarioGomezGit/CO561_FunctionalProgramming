open System

type Account = class
    val accountNumber:string
    val balance:float

    new (account_, balance_) =
        {accountNumber = account_; balance = balance_}

    member x.Print =
        printfn "Account:%s  Balance:%s" x.accountNumber, x.balance
end

type Costumer(account_, balance_) =
    inherit Account(account_, balance_)

    member x.Deposit =
        Console.Write("Deposit amount:")
        let amount = float(Console.ReadLine())
        let total:float = amount + balance_
        printfn "Current balance: %f" total
        
    member x.Withrawal=
        Console.Write("Withrawl amount:")
        let amount = float(Console.ReadLine())
        let total:float = balance_ - amount
        if amount < balance_ then printfn "No funds" 
        else printfn "Current balance: %f" total  

    member x.CheckAccount =
        match account_ with
        | Costumer.balance_ < 10.00 -> Console.WriteLine("Balance is low")
        | Costumer.balance_ >= 10.00 and <= 100.00 -> Console.WriteLine("Balance is OK")
        | Costumer.balance_ > 100.00 -> Console.WriteLine("Balance is high")
        | _ -> ()

