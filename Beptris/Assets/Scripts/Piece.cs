using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public Board board {  get; private set; }
    public BeptrimoData data { get; private set; }
    public Vector3Int position { get; private set; }
    
    public void Initialize(Board board, Vector3Int postion, BeptrimoData data)
    {

    }
}
