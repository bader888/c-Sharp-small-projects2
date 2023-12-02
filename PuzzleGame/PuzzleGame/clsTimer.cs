namespace PuzzleGame
{
    public class clsTimer
    {

        private int _TimerNumber;
        public int IncreaseTimer()
        {
            return _TimerNumber++;

        }

        public int RefrechTimer()
        {
            _TimerNumber = 0;

            return _TimerNumber;
        }

        public bool CheckTimerNumber()
        {
            return _TimerNumber == 50;

        }

        public int TimerNumber()
        {
            return _TimerNumber;
        }
    }
}
