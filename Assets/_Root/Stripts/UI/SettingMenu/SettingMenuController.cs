using Profile;
using UnityEngine;

namespace UI
{
    internal class SettingMenuController : BaseController
    {
        private readonly string _resurcePrefab = "Prefabs/SettingsMenu";
        private readonly ProfilePlayer _profilePlayer;
        private SettingMenuView _view;

        public SettingMenuController(Transform placeForUI, ProfilePlayer profilePlayer)
        {
            _profilePlayer = profilePlayer;
            _view = LaodView(placeForUI);
            _view.Init(StartMenu);
        }

        private SettingMenuView LaodView(Transform placeForUI)
        {
            GameObject prefab = Resources.Load<GameObject>(_resurcePrefab);
            GameObject objectView = Object.Instantiate(prefab, placeForUI);
            AddGameObject(objectView);

            return objectView.GetComponent<SettingMenuView>();
        }
        private void StartMenu() =>
            _profilePlayer.CurrentState.Value = GameState.Start;
    }
}
