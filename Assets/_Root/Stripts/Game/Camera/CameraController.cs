using UnityEngine;
using JoostenProductions;

namespace Game
{
    internal class CameraController
    {
        private Camera _camera;
        private Transform _player;
        private float _offsetSmoothing = 2;
        private float _offset = -4f;
        private float _minX = -12f;
        private float _minY = 0f;

        public CameraController(Camera camera, Transform player)
        {
            _camera = camera;
            _player = player;
            Start();
        }
        private void Start()
        {
            UpdateManager.SubscribeToUpdate(Move);

        }

        public void Move()
        {
            var playerPosition = new Vector3(_player.position.x, _player.position.y, _player.position.z + _offset);
            if (_player.position.x<_minX)
            {
                playerPosition.x = _minX;
            }
            if (_player.position.y<_minY)
            {
                playerPosition.y = _minY;
            }

            _camera.transform.position = Vector3.Lerp(_camera.transform.position, playerPosition, _offsetSmoothing * Time.deltaTime);
        }
    }
}
