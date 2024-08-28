using UnityEngine;

namespace View
{
    public class SideBarButtonRepository : MonoBehaviour
    {
        [SerializeField] private CustomButton _save;
        [SerializeField] private CustomButton _load;
        [SerializeField] private CustomButton _back;

        public CustomButton GetSave() => _save;
        public CustomButton GetLoad() => _load;
        public CustomButton GetBack() => _back;
    }
}