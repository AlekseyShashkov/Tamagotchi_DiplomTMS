using UnityEngine;

namespace Game
{
    public class Level
    {
        public int Lvl { get; private set; }
        public float Experience { get; private set; }
        public float MaxExperience { get; private set; }

        public Level()
        {
            Lvl = 1;
            Experience = 0.0f;
            MaxExperience = 50.0f;
        }

        public Level(int level, float experience, float maxExperience)
        {
            Lvl = level;
            Experience = experience;
            MaxExperience = maxExperience;
        }

        public void UpExperience(float happinessCoef)
        {
            Experience += Time.deltaTime * happinessCoef;

            if (Experience >= MaxExperience)
            {
                Lvl++;
                Experience -= MaxExperience;
                MaxExperience *= Lvl;
            }
        }
    }
}