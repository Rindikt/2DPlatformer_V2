using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;


namespace UI
{
    internal class SettingMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonClose;

        public void Init(UnityAction close)
        {
            _buttonClose.onClick.AddListener(close);
        }

        public void OnDestroy()
        {
            _buttonClose.onClick.RemoveAllListeners();
        }
    }
}
