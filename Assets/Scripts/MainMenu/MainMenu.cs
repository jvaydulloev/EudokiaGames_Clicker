using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _mainBackground;
    [SerializeField] private GameObject _recordsBackground;
    [SerializeField] private GameObject _titlesBackground;

    private void Start()
    {
        _mainBackground.SetActive(true);
        _recordsBackground.SetActive(false);
        _titlesBackground.SetActive(false);
    }
    private void OpenBackground(bool mainBackground,bool recordsBackground,bool titlesBackground) 
    {
        _mainBackground.SetActive(mainBackground);
        _recordsBackground.SetActive(recordsBackground);
        _titlesBackground.SetActive(titlesBackground);
    }

    public void StartGame() 
    {
        SceneManager.LoadScene(1);
    }

    public void RecordsClickButton() 
    {
        OpenBackground(false,true,false);
    }
    public void TitlesClickButton() 
    {
        OpenBackground(false,false,true);
    }
    public void BackClickButton() 
    {
        OpenBackground(true,false,false);
    }

    public void ExitGame() 
    {
        Application.Quit();
    }

}
