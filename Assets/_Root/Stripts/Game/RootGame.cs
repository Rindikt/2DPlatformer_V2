using UnityEngine;
using Game;

public class RootGame : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _player;


    private CameraController _cameraController;

    private void Start()
    {
        _cameraController = new CameraController(_camera, _player);
    }
}
