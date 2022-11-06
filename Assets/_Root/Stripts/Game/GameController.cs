using UnityEngine;
using Profile;

namespace Game
{
    internal class GameController : BaseController
    {
        private const LevelState levelState = LevelState.LevelOne;
        private readonly ProfilePlayer _profilePlayer;
        private readonly Transform _placeForUI;
        private ProfileLevel _profileLevel;

        private GameControllerLevelOne _controllerLevelOne;
        private GameCopntrollerLevelTho _controllerLevelTho;
        public GameController(ProfilePlayer profilePlayer, Transform placeForUI)
        {

            _profilePlayer = profilePlayer;
            _placeForUI = placeForUI;
            _profileLevel = new ProfileLevel(levelState);
            _profileLevel.CurrentState.SubscribeOnChange(OnChangeLevelState);
            OnChangeLevelState(_profileLevel.CurrentState.Value);


        }
        protected override void OnDispose()
        {
            _controllerLevelOne.Dispose();
            _controllerLevelTho.Dispose();
        }

        public void OnChangeLevelState(LevelState levelState)
        {
            switch (levelState)
            {
                case LevelState.LevelOne:
                    _controllerLevelOne = new GameControllerLevelOne();
                    _controllerLevelTho.Dispose();
                    break;
                case LevelState.LevelTwo:
                    _controllerLevelTho = new GameCopntrollerLevelTho();
                    _controllerLevelOne.Dispose();
                    break;
                default:
                    break;
            }
        }
        
    }
}
