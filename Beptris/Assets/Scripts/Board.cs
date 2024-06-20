using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour
{
    public Tilemap tilemap {  get; private set; }
    public BeptrimoData[] beptrimos;

    private void Awake()
    {
        this.tilemap = GetComponentInChildren<Tilemap>();
        
        for (int i = 0; i < this.beptrimos.Length; i++)
        {
            this.beptrimos[i].Initialize();
        }
    }

    private void Start()
    {
        SpawnPiece();
    }

    private void SpawnPiece()
    {
        int random = Random.Range(0, this.beptrimos.Length);
        BeptrimoData data = this.beptrimos[random];
    }

    public void Set()
    {

    }
}
