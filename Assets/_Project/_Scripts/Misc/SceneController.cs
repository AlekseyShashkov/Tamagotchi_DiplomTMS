using UnityEngine;
using UnityEngine.UI;

namespace Misc
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField] private Slider volumeSlider;

        private void Start()
        {
            if (AudioSystem.Instance != null)
            {
                AudioSystem.Instance.UpdateSliderReference(volumeSlider);
            }
        }
    }
}