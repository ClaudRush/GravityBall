using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text _scoreUI;
    [SerializeField] TapBlocker _pauseTapBlocker;
    [SerializeField] GameObject _menu;
    [SerializeField] Image _imagePause, _imageResume;

    private void Start()
    {
        ToggleTimeScale();
        ShowMenu();
    }

    public void UpdateScore(int score)
    {
        _scoreUI.text = score.ToString();
    }

    public bool IsTapArea()
    {
        return _pauseTapBlocker.IsTapArea();
    }
    public void ShowMenu()
    {
        if (GameManager.Instance.GamePaused)
        {
            _menu.SetActive(true);
            _imagePause.gameObject.SetActive(false);
            _imageResume.gameObject.SetActive(true);
        }
        else
        {
            _menu.SetActive(false);
            _imagePause.gameObject.SetActive(true);
            _imageResume.gameObject.SetActive(false);
        }

    }
    public void ToggleTimeScale()
    {
        if (Time.timeScale > 0)
        {
            Time.timeScale = 0;
            GameManager.Instance.GamePaused = true;
        }
        else
        {
            Time.timeScale = 1;
            GameManager.Instance.GamePaused = false;
        }

    }
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
