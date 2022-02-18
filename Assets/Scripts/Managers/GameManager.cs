using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private Circle _circle;
    [SerializeField] private UIManager _uIManager;
    public bool GamePaused { get; set; }
    private int _score = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!_uIManager.IsTapArea())
                return;
            if (Time.timeScale <= 0)
                return;

            if (_circle != null)
                _circle.ToggleGravity();
        }
    }

    public void AddScore()
    {
        _score++;
        _uIManager.UpdateScore(_score);
    }
}
