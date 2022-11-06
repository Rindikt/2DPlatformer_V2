using UnityEngine;
using Game;
using Game.Player;

public class RootGame : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private PlayerView _playerView;

    private CameraController _cameraController;
    private PlayerController _playerController;
    private void Start()
    {
        _cameraController = new CameraController(_player);
        _playerController = new PlayerController(_playerView);
    }
}
