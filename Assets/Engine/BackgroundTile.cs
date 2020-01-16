using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTile : MonoBehaviour {
	public int hitPoints;
	private SpriteRenderer sprite;

	private void Start()
	{
        sprite = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		
	}
}
