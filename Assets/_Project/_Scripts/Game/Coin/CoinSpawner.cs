using System.Collections;
using UnityEngine;

namespace Game
{
    public class CoinSpawner : MonoBehaviour
    {
        public int CoinCounter { get; set; }

        private float _width;
        private float _height;

        private CoinPool _coinPool;

        private void Start()
        {
            RectTransform rectTransform = gameObject.GetComponent<RectTransform>();

            _width = rectTransform.rect.width;
            _height = rectTransform.rect.height;

            _coinPool = GetComponent<CoinPool>();
        }

        public void SpawnCoin(int coinsCount)
        {
            CoinCounter += coinsCount;

            GameObject coin = _coinPool.GetCoin();

            coin.transform.SetParent(gameObject.transform, false);
            coin.GetComponent<RectTransform>().localPosition = GetRandomPosition();

            StartCoroutine(ReturnToPoolAfterDelay(coin));
        }

        private IEnumerator ReturnToPoolAfterDelay(GameObject coin)
        {
            yield return new WaitForSeconds(1.0f);
            _coinPool.ReturnCoin(coin);
        }

        private Vector2 GetRandomPosition()
        {
            return new Vector2(
                Random.Range(-_width / 2 + 50.0f, _width / 2 - 50.0f),
                Random.Range(-_height / 2 + 50.0f, _height / 2 - 50.0f)
            );
        }
    }
}