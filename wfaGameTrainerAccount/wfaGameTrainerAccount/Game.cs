namespace wfaGameTrainerAccount
{
    internal class Game
    {
        private Random rnd = new();
        public int CountCorrect { get; private set; }
        public int CountWrong { get; private set; }
        public string CodeText { get; private set; }

        private bool answerCorrect;
        private int maxValue = 20;

        public event EventHandler Change;
        internal void DoReset()
        {
            CountCorrect = 0;
            CountWrong = 0;
            DoContinue();
        }

        private void DoContinue()
        {
            //CodeText = "11 + 22 = 33";
            //answerCorrect = true;
            int xValue1 = rnd.Next(maxValue);
            int xValue2 = rnd.Next(maxValue);
            int xResult = xValue1 + xValue2;
            int xResultNew = xResult;
            if (rnd.Next(2) == 1) 
            {
                xResultNew += rnd.Next(1, 7) * (rnd.Next(2) == 1? 1 : -1);
            }

            CodeText = $"{xValue1} + {xValue2} = {xResultNew}";
            answerCorrect = (xResultNew == xResult);

            Change?.Invoke(this, EventArgs.Empty);
        }

        public void DoAnswer(bool v)
        {
            if (v == answerCorrect)
                CountCorrect++;
            else
                CountWrong++;
            DoContinue();
        }
    }
}