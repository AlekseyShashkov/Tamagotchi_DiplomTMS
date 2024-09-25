using System.IO;
using UnityEngine;

namespace Misc
{
    public class SaveLoadGame : MonoBehaviour
    {
        public Game.Tamagotchi Tamagotchi { get; set; }
        public Game.CoinSpawner CoinSpawner { get; set; }

        private string _saveFilePath;

        private void Start()
        {
            _saveFilePath = Path.Combine(Application.persistentDataPath, "savefile.json");
        }

        public void SaveGame()
        {
            SaveData saveData = new SaveData
            {
                CoinCounter = CoinSpawner.CoinCounter,

                Hunger = Tamagotchi.GetState(Game.Tamagotchi.HUNGER_STATE).State,
                Dirty = Tamagotchi.GetState(Game.Tamagotchi.DIRTY_STATE).State,
                Fatigue = Tamagotchi.GetState(Game.Tamagotchi.FATIGUE_STATE).State,
                Sick = Tamagotchi.GetState(Game.Tamagotchi.SICK_STATE).State,

                Happy = new HappySerialize(Tamagotchi.Happy.Happiness,
                    Tamagotchi.Happy.MaxHappiness),
                Level = new LevelSerialize(Tamagotchi.Level.Lvl,
                    Tamagotchi.Level.Experience,
                    Tamagotchi.Level.MaxExperience)
            };

            string json = JsonUtility.ToJson(saveData, false);
            File.WriteAllText(_saveFilePath, json);
        }

        public void LoadGame()
        {
            if (File.Exists(_saveFilePath))
            {
                string json = File.ReadAllText(_saveFilePath);
                SaveData saveData = JsonUtility.FromJson<SaveData>(json);

                CoinSpawner.CoinCounter = saveData.CoinCounter;

                Tamagotchi.SetStates(saveData.Hunger, saveData.Dirty, saveData.Fatigue, saveData.Sick);

                Tamagotchi.Happy = new Game.Happy(saveData.Happy.Happiness, saveData.Happy.MaxHappiness);
                Tamagotchi.Level = new Game.Level(saveData.Level.Lvl, saveData.Level.Experience, saveData.Level.MaxExperience);
            }
        }
    }
}