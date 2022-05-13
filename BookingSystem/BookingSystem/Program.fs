open System

//Task 4
type Ticket = {seat:int; customer:string}
let mutable tickets = [for n in 1..10 -> {Ticket.seat = n; Ticket.customer = ""}]

let BookSeat =
    Console.WriteLine("Enter seat number:")
    let seatNumber = int(Console.ReadLine())
    Console.WriteLine("Enter customer name:")
    let customerName = Console.ReadLine()
    Console.Write(seatNumber) //so da merda para baixo
    let book seatNumber customerName tickets = 
        tickets |> List.map (fun ticket ->
            if ticket.seat = seatNumber then { ticket with customer = customerName }
            else ticket )    
    tickets <- book seatNumber customerName tickets

let DisplayTickets = Console.WriteLine(tickets)