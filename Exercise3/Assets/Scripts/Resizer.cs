using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Shrinks and grows the game object as time passes
/// </summary>
public class Resizer : MonoBehaviour
{
    // timer support fields
    const float TotalResizeSeconds = 1;
    float elapsedResizeSeconds = 0;

    // resizing control fields
    const float ScaleFactorPerSecond = 1;
    int scaleFactorSignMultiplier = 1;

    // Update is called once per frame
    void Update()
    {
        Vector2 scale = transform.localScale;

        scale.x += Time.deltaTime * ScaleFactorPerSecond;
        scale.y += Time.deltaTime * ScaleFactorPerSecond;

        transform.localScale = scale;

        elapsedResizeSeconds += Time.deltaTime;

        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {

        }
    }
}
