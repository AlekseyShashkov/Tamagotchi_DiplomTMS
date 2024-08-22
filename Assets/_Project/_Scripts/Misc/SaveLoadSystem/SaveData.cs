namespace Misc
{
    [System.Serializable]
    public class SaveData
    {
        public float Hunger;
        public float Dirty;
        public float Fatigue;
        public float Sick;

        public HappySerialize Happy;
        public LevelSerialize Level;

        public int CoinCounter;
    }
}