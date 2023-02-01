//int balance = 600;

//Console.WriteLine("Type 1 for even numbers\nType 2 for odd numbers\nType 3 for red numbers\nType 4 for black numbers\nType 5 for 1st 12\nType 6 for 2nd 12\nType 7 for 3rd 12");













Roulette roulette = new();
Bets bets = new();
DataModel model = new();
model.Balance = 500;



model.Outcome = roulette.Spin();
model.Bet = Convert.ToInt32(Console.ReadLine());
model.BetAmount = Convert.ToInt32(Console.ReadLine());
model.ColorOutcome = roulette.ColorOutcome(model.Outcome);
bets.BetRoulette(model);



if (bets.BalanceCheck(model.BetAmount, model))
{
    Console.WriteLine("JA");
}
else
{
    Console.WriteLine("NO");
}
Console.WriteLine("Bal: "+model.Balance);
//bets.BetRoulette(bet, model);
Console.WriteLine($"The result is: {model.Outcome} {model.ColorOutcome.ToString()}");