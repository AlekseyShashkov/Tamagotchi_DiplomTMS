using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

namespace Misc
{
    public class SceneLoader : MonoBehaviour
    {
        public async UniTaskVoid ChangeScene(string sceneName)
        {
            Debug.Log("Starting scene change...");

            await UniTask.Delay(1000);
            await LoadSceneAsync(sceneName);
        }

        private async UniTask LoadSceneAsync(string sceneName)
        {
            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);

            while (!asyncOperation.isDone)
            {
                Debug.Log($"Loading progress: {asyncOperation.progress * 100}%");
                await UniTask.Yield();
            }

            Debug.Log("Scene loaded successfully!");
        }
    }
}