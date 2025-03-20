using UnityEngine;

namespace WildernessExplorer
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] float speed = 5f;     
        [SerializeField] float turnSpeed = 3f; 
        Rigidbody _rb;

        void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _rb.freezeRotation = true;
        }

        void FixedUpdate()
        {
            Vector3 moveDirection = Vector3.zero;

            if (Input.GetKey(KeyCode.W))
            {
                moveDirection += transform.forward;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up, -turnSpeed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up, turnSpeed);
            }

            var move = moveDirection * (speed * Time.fixedDeltaTime); 
            _rb.MovePosition(move + _rb.position);
        }
    }
}
