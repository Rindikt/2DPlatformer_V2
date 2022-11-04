using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI
{
    internal class MainMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonStart;
        [SerializeField] private Button _buttonSetting;
        [SerializeField] private Button _buttonExit;

        public void Init(UnityAction startGame, UnityAction setting, UnityAction exitGame)
        {
            _buttonStart.onClick.AddListener(startGame);
            _buttonSetting.onClick.AddListener(setting);
            _buttonExit.onClick.AddListener(exitGame);
        }

        public void OnDistroy()
        {
            _buttonStart.onClick.RemoveAllListeners();
            _buttonSetting.onClick.RemoveAllListeners();
            _buttonExit.onClick.RemoveAllListeners();
        }
    }
}
