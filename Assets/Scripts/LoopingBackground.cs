using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;

    // Start is called before the first frame update
    void Start()
    {
        if (backgroundSpeed <= 0)
        {
            backgroundSpeed = 1.0f;
            Debug.Log("Speed was set incorrect, deafaulting to " + backgroundSpeed.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
