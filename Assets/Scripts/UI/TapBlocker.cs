using UnityEngine;

public class TapBlocker : MonoBehaviour
{
    private bool _isTapArea = true;
    private void OnMouseEnter()
    {
        _isTapArea = false;
    }
    private void OnMouseExit()
    {
        _isTapArea = true;
    }
    public bool IsTapArea()
    {
        return _isTapArea;
    }
}
