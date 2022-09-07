using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendScript : MonoBehaviour
{
    public bool inColoredArea;
    public Color playerColor;
    public Color wallColor;
    public Renderer playerRender;
    // Start is called before the first frame update
    void Start()
    {
        playerRender.material.color = Color.white;
        playerRender = gameObject.GetComponent<SpriteRenderer>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        playerRender.material.color = Color.Lerp(playerRender.material.color, wallColor, 0.01f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
            wallColor = collision.gameObject.GetComponent<SpriteRenderer>().color;
        
    }
}
