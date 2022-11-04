using UnityEngine;
using Object = UnityEngine.Object;

namespace Game
{
    internal class GameControllerOneLevel : BaseController
    {
        private readonly string resurcePath = "";

        private Transform _placeForLevel;
        private GameLevelOneView _view;

        public GameControllerOneLevel(Transform placeForLevel)
        {
            _view = LoadView(placeForLevel);
        }

        private GameLevelOneView LoadView(Transform placeForLevel)
        {
            GameObject prefab = Resources.Load<GameObject>(resurcePath);
            GameObject objectView = Object.Instantiate(prefab, placeForLevel);
            AddGameObject(objectView);

            return objectView.GetComponent<GameLevelOneView>();
        }

    }
}
