using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class CoinPool : MonoBehaviour
    {
        [SerializeField] private GameObject _coinPrefab;
        [SerializeField] private int _poolSize = 5;

        private Queue<GameObject> _coinPool;

        private void Awake()
        {
            _coinPool = new Queue<GameObject>();

            for (int i = 0; i < _poolSize; ++i)
            {
                GameObject coin = Instantiate(_coinPrefab);
                coin.SetActive(false);
                _coinPool.Enqueue(coin);
            }
        }

        public GameObject GetCoin()
        {
            if (_coinPool.Count > 0)
            {
                GameObject coin = _coinPool.Dequeue();
                coin.SetActive(true);
                return coin;
            }
            else
            {
                GameObject coin = Instantiate(_coinPrefab);
                coin.SetActive(true);
                return coin;
            }
        }

        public void ReturnCoin(GameObject coin)
        {
            coin.SetActive(false);
            _coinPool.Enqueue(coin);
        }
    }
}