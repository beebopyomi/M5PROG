using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    private InputSystem_Actions inputActions;
    private Vector2 moveDirection;
    [SerializeField] private float speed = 5f;
    void Awake()
    {
        inputActions = new InputSystem_Actions();
    }
    void OnEnable()
    {
        inputActions.Cube.Enable();
    }
    void OnDisable()
    {
        inputActions.Cube.Disable();
    }
    void Update()
    {
        moveDirection = inputActions.Cube.Cube.ReadValue<Vector2>();
        Vector3 move = new Vector3(moveDirection.x, 0, moveDirection.y);
        transform.Translate(move * (Time.deltaTime * speed));
    }
}