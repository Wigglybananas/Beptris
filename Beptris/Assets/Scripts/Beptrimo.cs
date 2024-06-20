using UnityEngine;
using UnityEngine.Tilemaps;

public enum Beptrimo
{
    I,
    O,
    T,
    J,
    L,
    S,
    Z,
}

[System.Serializable]
public struct BeptrimoData
{
    public Beptrimo beptrimo;
    public Tile tile;
    public Vector2Int[] cells { get; private set; }
    
    public void Initialize()
    {
        this.cells = Data.Cells[this.beptrimo];
    }
}