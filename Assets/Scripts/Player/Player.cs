using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 _movementVector;

    private Rigidbody2D _rb;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void InputHandler()
    {
        _movementVector = GameInput.Instance.GetMovementVector();
    }
}
