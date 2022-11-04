using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


    internal abstract class BaseController : IDisposable
    {
        private List<BaseController> _baseController;
        private List<GameObject> _gameObjects;
        private bool _isDisposed;

        public void Dispose()
        {
            if (_isDisposed)
                return;

            _isDisposed = true;

            DisposeBaseController();
            DisposeGameObject();

            OnDispose();
        }

        protected virtual void OnDispose() { }

        private void DisposeGameObject()
        {
            if (_gameObjects == null)
                return;
            foreach (GameObject gameObject in _gameObjects)
            {
                Object.Destroy(gameObject);
            }
            _gameObjects.Clear();

        }

        private void DisposeBaseController()
        {
            if (_baseController == null)
                return;

            foreach (BaseController controller in _baseController)
            {
                controller.Dispose();
            }
            _baseController.Clear();
        }
        
        protected void AddController(BaseController baseController)
        {
            _baseController ??= new List<BaseController>();
            _baseController.Add(baseController);
        }

        protected void AddGameObject(GameObject gameObject)
        {
            _gameObjects ??= new List<GameObject>();
            _gameObjects.Add(gameObject);
        }
        
    }

