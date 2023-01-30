//int balance = 600;

//Console.WriteLine("Type 1 for even numbers\nType 2 for odd numbers\nType 3 for red numbers\nType 4 for black numbers\nType 5 for 1st 12\nType 6 for 2nd 12\nType 7 for 3rd 12");













Roulette roulette = new();
Bets bets = new();
DataModel model = new();
model.Balance = 500;

Color color;

int outcome = roulette.Spin();
color = roulette.ColorOutcome(outcome);
int bet = Convert.ToInt32(Console.ReadLine());
if (bets.BalanceCheck(bet, model))
{
    Console.WriteLine("JA");
}
else
{
    Console.WriteLine("NO");
}
//bets.BetRoulette(bet, model);
Console.WriteLine($"The result is: {outcome} {color.ToString()}");