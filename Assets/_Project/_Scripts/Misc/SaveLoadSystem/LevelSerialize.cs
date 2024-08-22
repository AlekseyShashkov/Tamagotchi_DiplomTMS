namespace Misc
{
    [System.Serializable]
    public class LevelSerialize
    {
        public int Lvl;
        public float Experience;
        public float MaxExperience;

        public LevelSerialize(int lvl, float experience, float maxExperience)
        {
            Lvl = lvl;
            Experience = experience;
            MaxExperience = maxExperience;
        }
    }
}