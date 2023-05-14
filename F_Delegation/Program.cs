using System.Timers;
using F_Delegation.Sticks;
using Timer = System.Timers.Timer;
using F_Delegation.Sticks;
using System.Numerics;

namespace F_Delegation
{

    public class CarArgs : EventArgs
    {
        public CarArgs(int currentSpeed)
        {
            CurrentSpeed = currentSpeed;
        }

        public int CurrentSpeed;
    }

    public class Car
    {
        public event EventHandler<CarArgs> TooFastDriving;

        private int speed = 0;

        //public delegate void TooFast(int currentSpeed);

        //private TooFast tooFast;

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
            {
                if (TooFastDriving != null)
                {
                    TooFastDriving(this, new CarArgs(speed));
                }
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        //public void RegisterOnTooFast(TooFast tooFast)
        //{
        //    this.tooFast += tooFast;
        //}

        //public void UnregisterOnTooFast(TooFast tooFast)
        //{
        //    this.tooFast -= tooFast;
        //}

    }

    class Program
    {
        static void Main(string[] args)
        {
            var game = new SticksGame(10, Player.Human);
            game.MachinePlayed += Game_MachinePlayed;
            game.HumanTurnToMakeMove += Game_MachineTurnToMakeMove;
            game.EndOfGame += Game_EndOfGame;

            game.Start();
        }

        private static void Game_EndOfGame(Player player)
        {
            Console.WriteLine($"Winner: {player}");
        }

        private static void Game_MachineTurnToMakeMove(object? sender, int remaningSticks)
        {
            Console.WriteLine($"Remaining sticks: {remaningSticks}");
            Console.WriteLine("Take some sticks");

            bool takenCorrectly = false;
            while (!takenCorrectly)
            {
                if (int.TryParse(Console.ReadLine(), out int takenSticks))
                {
                    var game = (SticksGame)sender;

                    try
                    {
                        game.HumanTakes(takenSticks);
                        takenCorrectly = true;
                    }
                    catch(ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

        }

        private static void Game_MachinePlayed(int sticksTaken)
        {
            Console.WriteLine($"Machine took: {sticksTaken}");
        }


        static void EV()
        {
            Timer timer = new Timer();
            timer.Elapsed += Timer_Elapsed;

            var interval = 5000;
            timer.Interval = interval;
            timer.Start();


            Console.ReadLine();

            Car car = new Car();
            car.TooFastDriving += HandleOnTooFast;
            car.TooFastDriving += HandleOnTooFast;
            car.TooFastDriving += HandleOnTooFast;

            car.TooFastDriving -= HandleOnTooFast;

            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }

            Console.ReadLine();

        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //var timer = (Timer)sender;
            Console.WriteLine("Handling Timer Elapsed Event");
        }

        private static void HandleOnTooFast(object obj, CarArgs speed)
        {
            Console.WriteLine($"Oh, I got it, calling stop! Current speed = {speed.CurrentSpeed}");
            var car = (Car)obj;
            car.Stop();
        }
    }
}