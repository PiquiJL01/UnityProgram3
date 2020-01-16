using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameState currentState = GameState.move;
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

    // Start is called before the first frame update
    void Start()
    {
        //soundManager = FindObjectOfType<SoundManager>();
        //scoreManager = FindObjectOfType<ScoreManager>();
        //breakableTiles = new BackgroundTile[width, height];
        //lockTiles = new BackgroundTile[width, height];
        //concreteTiles = new BackgroundTile[width, height];
        //findMatches = FindObjectOfType<FindMatches>();
        //blankSpaces = new bool[width, height];
        //allDots = new GameObject[width, height];
        SetUp();
        currentState = GameState.pause;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetUp() { }
}
