using UnityEngine;
using UnityEngine.InputSystem;

public class MovementCtrl : MonoBehaviour
{
    public InputActionAsset inputActionAsset;
    public InputActionMap _inputActionMap;
    private InputAction _move;
    private InputAction _jump;

    public float speed = 5f;
    public float jumpForce = 5f;
    private Rigidbody rb;

    void Start()
    {
        _inputActionMap = inputActionAsset.FindActionMap("Player");
        _move = _inputActionMap.FindAction("Move");
        _jump = _inputActionMap.FindAction("Jump");

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento
        Vector2 joystickmove = _move.ReadValue<Vector2>();

        Vector3 realmovement = new Vector3(
            joystickmove.x,
            0,
            joystickmove.y
        );

        rb.linearVelocity = new Vector3(
            realmovement.x * speed,
            rb.linearVelocity.y,
            realmovement.z * speed
        );

        // Salto
        if (_jump.WasPressedThisFrame())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

            //transform(hace referencia al atributo de transform de cualquier game object).translate(translate cambia la posicion del gameobject en la unidad que le pasemos, y no i,pprta cual sea el origen sino se centra en el destino) va a transportar 
            //el Time.deltaTime arregla los gaps en los que compus lentas se tarden mas, entonces uyna compu muy bueno y una muy mala terminarán al mismo tiempo. Estandarizar la velocidad de frames.
            //todo lo que incluye movimiento se va a multiplicar por esta variable 