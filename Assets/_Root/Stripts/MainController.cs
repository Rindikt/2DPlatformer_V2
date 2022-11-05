using Profile;
using UnityEngine;
using UI;
using Game;

internal class MainController : BaseController
{
    private readonly Transform _placeForUI;
    private readonly ProfilePlayer _profilePlayer;


    private MainMenuController _mainMenuController;
    private SettingMenuController _settingMenuController;
    private GameController _gameController;
    public MainController(Transform placeForUI, ProfilePlayer profilePlayer)
    {
        _placeForUI = placeForUI;
        _profilePlayer = profilePlayer;
        _profilePlayer.CurrentState.SubscribeOnChange(OnChangeGameState);
        OnChangeGameState(_profilePlayer.CurrentState.Value);
    }

    protected override void OnDispose()
    {
        _mainMenuController?.Dispose();
    }

    private void OnChangeGameState(GameState gameState)
    {
            switch (gameState)
            {
                case GameState.Start:
                _mainMenuController = new MainMenuController(_placeForUI, _profilePlayer);
                        Debug.Log("it1");
                _settingMenuController.Dispose();
                _gameController.Dispose();
                break;
                case GameState.Setting:
                _settingMenuController = new SettingMenuController(_placeForUI, _profilePlayer);
                _mainMenuController.Dispose();
                _gameController.Dispose();
                    break;
                case GameState.Game:
                _gameController = new GameController(_profilePlayer, _placeForUI);
                _mainMenuController.Dispose();
                _settingMenuController.Dispose();
                break;
                default:
                _settingMenuController.Dispose();
                _gameController.Dispose();
                _mainMenuController.Dispose();
                break;
            }
    }

}

