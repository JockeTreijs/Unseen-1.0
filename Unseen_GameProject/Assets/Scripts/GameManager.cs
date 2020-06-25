using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Tilemap darkMap;
    public Tilemap blurredMap;
    public Tilemap backgroundMap;

    public Tile darkTile;
    public Tile blurredTile;

    private Button startButton;
    private Button exitButton;
    private Button mainMenuButton;
    private Button tryAgainButton;
    private Button quitButton;
    private Button beginButton;

    // Start is called before the first frame update
    void Start()
    {
        darkMap.origin = blurredMap.origin = backgroundMap.origin;
        darkMap.size = blurredMap.size = backgroundMap.size;

        foreach (Vector3Int p in darkMap.cellBounds.allPositionsWithin)
        {
            darkMap.SetTile(p, darkTile);
        }

        foreach (Vector3Int p in blurredMap.cellBounds.allPositionsWithin)
        {
            blurredMap.SetTile(p, blurredTile);
        }

        startButton = GameObject.Find("StartButton").GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);

        exitButton = GameObject.Find("ExitButton").GetComponent<Button>();
        exitButton.onClick.AddListener(ExitGame);

        mainMenuButton = GameObject.Find("MainMenuButton").GetComponent<Button>();
        mainMenuButton.onClick.AddListener(MainMenu);

        tryAgainButton = GameObject.Find("TryAgainButton").GetComponent<Button>();
        tryAgainButton.onClick.AddListener(BeginGame);

        quitButton = GameObject.Find("QuitButton").GetComponent<Button>();
        quitButton.onClick.AddListener(MainMenu);

        beginButton = GameObject.Find("BeginButton").GetComponent<Button>();
        beginButton.onClick.AddListener(BeginGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Story");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void FinishLevel()
    {
        SceneManager.LoadScene("End");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }

    public void BeginGame()
    {
        SceneManager.LoadScene("Game");
    }
}
