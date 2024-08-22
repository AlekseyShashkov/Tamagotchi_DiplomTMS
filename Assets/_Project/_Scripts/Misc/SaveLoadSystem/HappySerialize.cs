namespace Misc
{
    [System.Serializable]
    public class HappySerialize
    {
        public float Happiness;
        public float MaxHappiness;

        public HappySerialize(float happiness, float maxHappiness)
        {
            Happiness = happiness;
            MaxHappiness = maxHappiness;
        }
    }
}