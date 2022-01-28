
using Bossfight;

var player1 = new GameCharacter("Hero", 100, 20, 40);
var player2 = new GameCharacter("Boss", 400, 30, 10);

var Alive = true;
while (Alive)
{
    player1.Fight(player2);
    await Task.Delay(1000);
    player2.Fight(player1);
    if (player1.Health <= 0 || player2.Health <= 0)
    {
        Alive = false;
        if (player1.Health <= 0)
        {
            Console.WriteLine($"{player2.Player} wins!");
        } else if(player2.Health <= 0) Console.WriteLine($"{player1.Player} wins!");

    }
    await Task.Delay(1000);

}