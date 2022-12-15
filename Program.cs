using System.Threading;
class Battle{

    static int Randomizer(int x, int y){
        Random rnd = new();
        return rnd.Next(x, y);
    }
    static int DiceRoll(){
        Random dice = new();
        return dice.Next(0, 21);
    }

    static void Statistic(int heroHp, int enemyHp){
        Console.WriteLine($"Здоровье Героя: {heroHp}\nЗдоровье Врага: {enemyHp}\n");
    }
    
    static void Main(){
        int round = 1;
        Fighter Hero = new Fighter(Randomizer(100, 121),Randomizer(10, 16));
        Fighter Enemy = new Fighter(Randomizer(100, 121),Randomizer(10, 16));

        Statistic(Hero.HP, Enemy.HP);
        
        Console.WriteLine("Fight!\n");
        
        while (true){
            Console.WriteLine($"Раунд: {round++}\n");

            if (DiceRoll() > 17){
                Enemy.HP -= Hero.Str * 2;
                Console.WriteLine($"Крит!\nГерой наносит: {Hero.Str * 2} урона\n");
                Statistic(Hero.HP, Enemy.HP);
            }
            else if (DiceRoll() < 6){
                Console.WriteLine("Герой промахнулся!\n");
            }
            else{
                Enemy.HP -= Hero.Str;
                Console.WriteLine($"Герой наносит: {Hero.Str} урона\n");
                Statistic(Hero.HP, Enemy.HP);
            }
            if (Enemy.HP <= 0){
                Console.WriteLine("Герой победил!\n");
                break;
            }

            Thread.Sleep(1500);
            
            if (DiceRoll() > 17){
                Hero.HP -= Enemy.Str * 2;
                Console.WriteLine($"Крит!\nВраг наносит: {Enemy.Str * 2} урона\n");
                Statistic(Hero.HP, Enemy.HP);
            }
            else if (DiceRoll() < 6){
                Console.WriteLine("Враг промахнулся!\n");
            }
            else{
                Hero.HP -= Enemy.Str;
                Console.WriteLine($"Враг наносит: {Enemy.Str} урона\n");
                Statistic(Hero.HP, Enemy.HP);
            }
            if (Hero.HP <= 0){
                Console.WriteLine("Враг победил!");
                break;
            }
            Thread.Sleep(1500);
        }
    }
}