using UnityEngine;
using Object = UnityEngine.Object;

namespace Game
{
    internal class GameControllerLevelOne : BaseController
    {
        private readonly string resurcePath = "Prefabs/GameLevelOne";

        private Transform _placeForLevel;
        private GameLevelOneView _view;

        public GameControllerLevelOne()
        {
            _view = LoadView();
        }

        private GameLevelOneView LoadView()
        {
            GameObject prefab = Resources.Load<GameObject>(resurcePath);
            GameObject objectView = Object.Instantiate(prefab);
            AddGameObject(objectView);

            return objectView.GetComponent<GameLevelOneView>();
        }

    }
}
