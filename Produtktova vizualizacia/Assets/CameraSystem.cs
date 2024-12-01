using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private float _rotateSpeed;
    private bool _isDragging;
    private Quaternion _originalRotation;

    private void Awake()
    {
        _originalRotation = transform.rotation;
    }
    void Update()
    {
        Vector3 inputDir = new(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            inputDir.z = +1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputDir.z = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputDir.x = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputDir.x = +1f;
        }

        if (Input.GetMouseButtonDown(0))  // On mouse button down
        {
            _isDragging = true;
        }
        if (Input.GetMouseButtonUp(0))  // On mouse button up
        {
            _isDragging = false;
        }

        if (_isDragging)
        {
            float mouseY = Input.GetAxis("Mouse Y");
            float mouseX = Input.GetAxis("Mouse X");  // Get horizontal mouse movement
            transform.Rotate(mouseY * _rotateSpeed * Time.deltaTime, -1 * mouseX * _rotateSpeed * Time.deltaTime, 0);  // Rotate the object based on mouse movement
        }
        Vector3 moveDir = transform.forward * inputDir.z + transform.right * inputDir.x;
        transform.position += moveDir * _moveSpeed * Time.deltaTime;
    }

    public void ResetPlayer()
    {
        transform.position = new(-102f, 12f, 13.66f);
        transform.rotation = _originalRotation;
    }
}
