namespace TheatricalPlayersRefactoringKata
{
    public class Play
    {
        public string Name { get; set; }
        public string Type { get; set; }

        private int _baseAmount;
        private int _audienceThreshold;
        private int _basePerAudience;
        
        private int _bonusBase;
        private int _bonusPerAudience;

        public Play(string name, string type)
        {
            Name = name;
            Type = type;

            if (type == "tragedy")
            {
                _baseAmount = 40000;
                _audienceThreshold = 30;
                _basePerAudience = 0;
                _bonusBase = 0;
                _bonusPerAudience = 1000;
            }
            else if (type == "comedy")
            {
                _baseAmount = 30000;
                _audienceThreshold = 20;
                _basePerAudience = 300;
                _bonusBase = 10000;
                _bonusPerAudience = 500;
            }
        }

        public int CalculateAmount(int audienceCount)
        {
            var totalAmount = _baseAmount + _basePerAudience * audienceCount;
            if (audienceCount > _audienceThreshold)
            {
                totalAmount += _bonusBase + _bonusPerAudience * (audienceCount - _audienceThreshold);
            }

            return totalAmount;
        }
    }
}
