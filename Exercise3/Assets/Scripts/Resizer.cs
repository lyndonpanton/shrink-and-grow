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
    const float TotalResizeSeconds = 4;
    float elapsedResizeSeconds = 0;

    // resizing control fields
    const float ScaleFactorPerSecond = 4;
    int scaleFactorSignMultiplier = 1;

    // Update is called once per frame
    void Update()
    {
        Vector2 scale = transform.localScale;

        scale.x += Time.deltaTime * ScaleFactorPerSecond * scaleFactorSignMultiplier;
        scale.y += Time.deltaTime * ScaleFactorPerSecond * scaleFactorSignMultiplier;

        transform.localScale = scale;

        elapsedResizeSeconds += Time.deltaTime;

        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {
            elapsedResizeSeconds = 0;
            scaleFactorSignMultiplier *= -1;
        }
    }
}
