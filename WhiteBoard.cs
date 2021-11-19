using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBoard : MonoBehaviour
{
    public Texture2D texture;

    public Vector2 textureSize = new Vector2(x: 2048, y: 2048);

    void Start()
    {
        var r = GetComponent<Renderer>();
        texture = new Texture2D((int)textureSize.x, (int)textureSize.y);
        e.material.mainTexture = texture;
    }
}
