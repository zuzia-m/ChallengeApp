namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public char AverageLetter
        {
            get
            {
                switch (Average)
                {
                    case >= 80:
                        return 'A';
                    case >= 60:
                        return 'B';
                    case >= 40:
                        return 'C';
                    case >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            Count = 0;
            Sum = 0.0f;
            Max = float.MinValue;
            Min = float.MaxValue;
        }

        public void Add(float grade)
        {
            Sum += grade;
            Count++;
            Min = Math.Min(grade, Min);
            Max = Math.Max(grade, Max);
        }
    }
}
