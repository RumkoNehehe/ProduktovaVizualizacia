using TMPro;
using UnityEngine;

public class ShowRoomController : MonoBehaviour
{
    [SerializeField]
    private Rotate _shipScript;
    [SerializeField]
    private Rotate _tankScript;
    [SerializeField]
    private Rotate _traktorScript;
    [SerializeField]
    private TextMeshProUGUI _textMeshProUGUI;

    private Rotate _current;
    private bool _isInfoShowing = false;

    public void ToggleInfo()
    {
        if (_isInfoShowing)
        {
            HideInfo();
        }
        else
        {
            ShowInfo();
        }
    }

    private void HideInfo()
    {
        _textMeshProUGUI.text = " ";
        _isInfoShowing = false;
    }

    private void ShowInfo()
    {
        _textMeshProUGUI.text = _current.GetInfo();
        _isInfoShowing = true;
    }

    public void ShipClicked()
    {
        _current = _shipScript;
        HideInfo();
        _shipScript.Show();
        _tankScript.Hide();
        _traktorScript.Hide();
    }

    public void TankClicked()
    {
        _current = _tankScript;
        HideInfo();
        _tankScript.Show();
        _shipScript.Hide();
        _traktorScript.Hide();
    }

    public void TraktorClicked()
    {
        _current = _traktorScript;
        HideInfo();
        _traktorScript.Show();
        _shipScript.Hide();
        _tankScript.Hide();
    }

    public void ToggleRotation()
    {
        _current.ToggleRotation();
    }
}
