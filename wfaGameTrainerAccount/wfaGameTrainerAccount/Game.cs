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
            int xValue3 = rnd.Next(4);
            int xResult;
            int xResultNew;
            switch (xValue3)
            {
                case 0:
                    xResult = xValue1 + xValue2;
                    xResultNew = xResult;
                    if (rnd.Next(2) == 1) 
                    {
                        xResultNew += rnd.Next(1, 7) * (rnd.Next(2) == 1? 1 : -1);
                    }

                    CodeText = $"{xValue1} + {xValue2} = {xResultNew}";
                    answerCorrect = (xResultNew == xResult);

                    Change?.Invoke(this, EventArgs.Empty);
                    break;
                case 1:
                    xResult = xValue1 - xValue2;
                    xResultNew = xResult;
                    if (rnd.Next(2) == 1)
                    {
                        xResultNew += rnd.Next(1, 7) * (rnd.Next(2) == 1 ? 1 : -1);
                    }

                    CodeText = $"{xValue1} - {xValue2} = {xResultNew}";
                    answerCorrect = (xResultNew == xResult);

                    Change?.Invoke(this, EventArgs.Empty);
                    break;
                case 2:
                    xResult = xValue1 * xValue2;
                    xResultNew = xResult;
                    if (rnd.Next(2) == 1)
                    {
                        xResultNew += rnd.Next(1, 7) * (rnd.Next(2) == 1 ? 1 : -1);
                    }

                    CodeText = $"{xValue1} * {xValue2} = {xResultNew}";
                    answerCorrect = (xResultNew == xResult);

                    Change?.Invoke(this, EventArgs.Empty);
                    break;
                case 3:
                    xResult = xValue1 / xValue2;
                    xResultNew = xResult;
                    if (rnd.Next(2) == 1)
                    {
                        xResultNew += rnd.Next(1, 7) * (rnd.Next(2) == 1 ? 1 : -1);
                    }

                    CodeText = $"{xValue1} / {xValue2} = {xResultNew}";
                    answerCorrect = (xResultNew == xResult);

                    Change?.Invoke(this, EventArgs.Empty);
                    break;
            }
            if (answerCorrect == true)
            {
                switch (CountCorrect)
                {
                    case 2:
                        maxValue = 40;
                        break;
                    case 4:
                        maxValue = 60;
                        break;
                    case 7:
                        maxValue = 100;
                        break;
                }
            }
            
        }

        public void DoAnswer(bool v)
        {
            if (v == answerCorrect)
                CountCorrect++;
            else
                CountWrong++;
            DoContinue();
        }
        
        public void DoPropusk()
        {
            DoContinue();
        }

        internal void DoRestart()
        {
            CountCorrect = 0;
            CountWrong = 0;
            DoContinue();
        }
    }
}