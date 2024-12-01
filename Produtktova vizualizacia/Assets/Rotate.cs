using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float _rotationSpeed = 30f;  // Speed of rotation

    private bool _isRotating = false;

    [SerializeField]
    private string _info;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (_isRotating)
        {
            transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
        }
    }

    public string GetInfo()
    {
        return _info;
    }

    public void ToggleRotation()
    {
        _isRotating = !_isRotating;
    }

    public void Show()
    {
        transform.rotation = Quaternion.identity;
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        if (_isRotating)
        {
            ToggleRotation();
        }
        gameObject.SetActive(false);
    }
}
