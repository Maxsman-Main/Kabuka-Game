using Scriptable.Move;
using Services.InputService;
using UnityEngine;
using Zenject;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [Inject] private IInputService _inputService;
        [Inject] private Movement _movement;

        private Rigidbody2D _rigidbody2D;

        public void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        public void Update()
        {
            _movement.Move(_inputService.Axis, _rigidbody2D);
        }
    }
}