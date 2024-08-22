namespace Game
{
    public class Happy
    {
        public float Happiness { get; private set; }
        public float MaxHappiness { get; private set; }

        public Happy(float happiness, float maxHappiness)
        {
            Happiness = happiness;
            MaxHappiness = maxHappiness;
        }

        public void UpdateHappy(float happiness) => Happiness = happiness;

        public float HappinessCoef() => Happiness / MaxHappiness;
    }
}