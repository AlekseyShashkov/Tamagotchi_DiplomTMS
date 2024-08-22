using System.Collections;
using UnityEngine;

namespace Game
{
    public class CoinSpawner : MonoBehaviour
    {
        public Level TamagotchiLevel { get; set; }
        public int CoinCounter { get; set; } = 0;

        private CoinPool _coinPool;

        private float _width;
        private float _height;

        private void Start()
        {
            RectTransform rectTransform = gameObject.GetComponent<RectTransform>();

            _coinPool = GetComponent<CoinPool>();

            _width = rectTransform.rect.width;
            _height = rectTransform.rect.height;
        }

        public void SpawnCoin()
        {
            CoinCounter += 1 * TamagotchiLevel.Lvl;

            Vector2 randomPosition = new Vector2(
                Random.Range(-_width / 2 + 50.0f, _width / 2 - 50.0f),
                Random.Range(-_height / 2 + 50.0f, _height / 2 - 50.0f)
            );

            GameObject coin = _coinPool.GetCoin();

            coin.transform.SetParent(gameObject.transform, false);
            coin.GetComponent<RectTransform>().localPosition = randomPosition;

            StartCoroutine(ReturnToPoolAfterDelay(coin, 1.0f));
        }

        private IEnumerator ReturnToPoolAfterDelay(GameObject coin, float delay)
        {
            yield return new WaitForSeconds(delay);
            _coinPool.ReturnCoin(coin);
        }
    }
}