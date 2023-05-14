using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace F_Delegation.Sticks
{
    public class SticksGame
    {
        private readonly Random randomaizer;

        public int InitialSticksNumber { get; }

        public Player Turn { get; private set; }

        public int RemaningSticks { get; private set; }

        public GameStatus GameStatus { get; private set; }

        public event Action<int> MachinePlayed;
        public event EventHandler<int> HumanTurnToMakeMove;

        public event Action<Player> EndOfGame;

        public SticksGame(int initialSticksNumber, Player whoMakesFirsMove)
        {
            if (initialSticksNumber < 7 || initialSticksNumber > 30)
            {
                throw new ArgumentException("Initial number of sticks should be <= 7 and <= 30");
            }

            randomaizer = new Random();
            GameStatus = GameStatus.NotStarted;
            InitialSticksNumber = initialSticksNumber;
            RemaningSticks = InitialSticksNumber;
            Turn = whoMakesFirsMove;
        }

        public void HumanTakes(int sticks)
        {
            if (sticks < 1 || sticks > 3)
            {
                throw new ArgumentException("You can take from 1 to 3 sticks in a single move");
            }

            if (sticks > RemaningSticks)
            {
                throw new ArgumentException($"You can't tale more than remaining. Remains: {RemaningSticks}");
            }
            TakeSticks(sticks);
        }

        public void Start()
        {
            if (GameStatus == GameStatus.GameIsOver)
            {
                RemaningSticks = InitialSticksNumber;
            }

            if (GameStatus == GameStatus.InProgress)
            {
                throw new InvalidOperationException("Can't call Start when game is already in progress.");
            }

            GameStatus = GameStatus.InProgress;
            while (GameStatus == GameStatus.InProgress)
            {
                if (Turn == Player.Computer)
                {
                    CompMakesMove();
                }
                else
                {
                    HumanMakesMove();
                }

                FireEnsOfGameIfRequired();

                Turn = Turn == Player.Computer ? Player.Human : Player.Computer;
            }
        }

        private void FireEnsOfGameIfRequired()
        {
            if (RemaningSticks == 0)
            {
                GameStatus = GameStatus.GameIsOver;
                if (EndOfGame != null)
                {
                    EndOfGame(Turn == Player.Computer ? Player.Human : Player.Computer);
                }
            }
        }


        private void HumanMakesMove()
        {
            if (HumanTurnToMakeMove != null)
            {
                HumanTurnToMakeMove(this, RemaningSticks);
            }
        }

        private void CompMakesMove()
        {
            int maxNumber = RemaningSticks >= 3 ? 3 : RemaningSticks;
            int sticks = randomaizer.Next(1, maxNumber);

            TakeSticks(sticks);
            if (MachinePlayed != null)
            {
                MachinePlayed(sticks);
            }
        }

        private void TakeSticks(int sticks)
        {
            RemaningSticks -= sticks;
        }
    }
}
;