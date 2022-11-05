using UnityEngine;
using Object = UnityEngine.Object;
using Profile;

namespace UI
{
    internal class MainMenuController : BaseController
    {
        private readonly string _resurcePath = "Prefabs/MainMenu";
        private readonly MainMenuView _menuView;
        private readonly ProfilePlayer _profilePlayer;


        public MainMenuController(Transform placeForUI, ProfilePlayer profilePlayer)
        {
            _profilePlayer = profilePlayer;
            _menuView = LoadView(placeForUI);
            Debug.Log("it");
            _menuView.Init(StartGame, Seting, Exit);
        }

        private MainMenuView LoadView(Transform placeForUI)
        {
            GameObject prefab = Resources.Load<GameObject>(_resurcePath);
            GameObject objectView = Object.Instantiate(prefab, placeForUI);
            AddGameObject(objectView);

            return objectView.GetComponent<MainMenuView>();
        }

        private void StartGame() => 
            _profilePlayer.CurrentState.Value = GameState.Game;

        private void Seting() =>
            _profilePlayer.CurrentState.Value = GameState.Setting;

        private void Exit() =>
            _profilePlayer.CurrentState.Value = GameState.Exit;

    }
}
