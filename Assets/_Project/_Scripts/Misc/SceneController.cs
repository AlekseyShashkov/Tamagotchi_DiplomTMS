using UnityEngine;
using UnityEngine.UI;

namespace Misc
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField] private Slider _volumeSlider;

        private void Start()
        {
            if (AudioSystem.Instance != null)
            {
                AudioSystem.Instance.UpdateSliderReference(_volumeSlider);
            }
        }
    }
}