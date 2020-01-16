using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameState currentState = GameState.move;
    public Reducer reducer;

    [Header("Board Dimensions")]
    public int width;
    public int height;
    public int offSet;

    [Header("Prefabs")]
    public GameObject tilePrefab;
    public GameObject breakableTilePrefab;
    public GameObject lockTilePrefab;
    public GameObject concreteTilePrefab;
    public GameObject[] dots;
    public GameObject destroyParticle;

    [Header("Layout")]
    public TileType[] boardLayout;
    private bool[,] blankSpaces;
    private BackgroundTile[,] breakableTiles;
    public BackgroundTile[,] lockTiles;
    private BackgroundTile[,] concreteTiles;
    public GameObject[,] allDots;
    
    private void Awake()
    {
        width = 8;
        height = 8;
        //Layout missing
    }
    
    // Use this for initialization
    void Start()
    {
        breakableTiles = new BackgroundTile[width, height];
        lockTiles = new BackgroundTile[width, height];
        concreteTiles = new BackgroundTile[width, height];
        reducer = FindObjectOfType<Reducer>();
        blankSpaces = new bool[width, height];
        allDots = new GameObject[width, height];
        SetUp();
        currentState = GameState.pause;
    }

        public void GenerateBlankSpaces()
        {
            for (int i = 0; i < boardLayout.Length; i++)
            {
                if (boardLayout[i].tileKind == TileKind.Blank)
                {
                    blankSpaces[boardLayout[i].x, boardLayout[i].y] = true;
                }
            }
        }

        private void GenerateConcreteTiles()
        {
            //Missing LayOut
            for (int i = 0; i < boardLayout.Length; i++)
            {
                if (boardLayout[i].tileKind == TileKind.Concrete)
                {
                    Vector2 tempPosition = new Vector2(boardLayout[i].x, boardLayout[i].y);
                    GameObject tile = Instantiate(concreteTilePrefab, tempPosition, Quaternion.identity);
                    concreteTiles[boardLayout[i].x, boardLayout[i].y] = tile.GetComponent<BackgroundTile>();
                }
            }
        }

        private void SetUp()
        {
            GenerateBlankSpaces();
            GenerateConcreteTiles();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (!blankSpaces[i, j] && !concreteTiles[i, j])
                    {
                        Vector2 tempPosition = new Vector2(i, j + offSet);
                        Vector2 tilePosition = new Vector2(i, j);
                        GameObject backgroundTile = Instantiate(tilePrefab, tilePosition, Quaternion.identity) as GameObject;
                        backgroundTile.transform.parent = this.transform;
                        backgroundTile.name = "( " + i + ", " + j + " )";

                    }
                }

            }
        }
}

public enum GameState
{
    wait,
    move,
    win,
    lose,
    pause
}

public enum TileKind
{
    Blank,
    Concrete,
    Filled
}

[System.Serializable]
public class MatchType
{
    public int type;
    public string color;
}

[System.Serializable]
public class TileType
{
    public int x;
    public int y;
    public TileKind tileKind;
}
