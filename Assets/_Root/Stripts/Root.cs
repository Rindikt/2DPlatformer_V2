using UnityEngine;
using Profile;

public sealed class Root : MonoBehaviour
{
    private const GameState gameState = GameState.Start;

    [SerializeField] private Transform _placeForUI;

    private MainController _mainController;

    private void Start()
    {
        var profilePlayer = new ProfilePlayer(gameState);
        _mainController = new MainController(_placeForUI, profilePlayer);
    }


}
