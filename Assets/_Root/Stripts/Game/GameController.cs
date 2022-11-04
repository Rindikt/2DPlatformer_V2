using UnityEngine;
using Profile;

namespace Game
{
    internal class GameController : BaseController
    {
        
        private readonly ProfilePlayer _profilePlayer;
        private readonly Transform _placeForUI;

        public GameController(ProfilePlayer profilePlayer, Transform placeForUI)
        {

            _profilePlayer = profilePlayer;

            _placeForUI = placeForUI;
        }

        public void OnChangeLevelState(LevelState levelState)
        {
            switch (levelState)
            {
                case LevelState.LevelOne:
                    break;
                case LevelState.LevelTwo:
                    break;
                default:
                    break;
            }
        }
    }
}
