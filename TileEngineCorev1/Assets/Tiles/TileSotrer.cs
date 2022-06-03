using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "TileStorer")]
public class TileSotrer : ScriptableObject
{
    public List<TileData> tiles;

    [System.Serializable]
    public class TileData
    {
        public string textureName;
        public Texture2D texture;
    }
}
