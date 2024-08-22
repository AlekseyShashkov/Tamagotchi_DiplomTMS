using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

namespace Misc
{
    public class SceneLoader : MonoBehaviour
    {
        public async Task LoadSceneAsync(string sceneName)
        {
            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);

            while (!asyncOperation.isDone)
            {
                Debug.Log($"Loading progress: {asyncOperation.progress * 100}%");
                await Task.Yield();
            }

            Debug.Log("Scene loaded successfully!");
        }

        public async void ChangeScene(string sceneName)
        {
            Debug.Log("Starting scene change...");

            await Task.Delay(1000);
            await LoadSceneAsync(sceneName);
        }
    }
}