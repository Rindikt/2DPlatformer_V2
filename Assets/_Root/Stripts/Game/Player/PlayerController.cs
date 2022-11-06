using System;
using UnityEngine;



namespace Game.Player
{
    internal class PlayerController
    {
        private PlayerView _playerView;
        
        private PlayerMove _playerMove;

        public PlayerController(PlayerView playerView)
        {
            _playerView = playerView;
            _playerMove = new PlayerMove(_playerView);

        }

       
    }
}
