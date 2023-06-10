using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI displayFPS;
    private float targetFPS = 90.0f;
    private float currentFPS = 0.0f;
    private float dt = 0.0f;

    public float updateDelay = 0.0f;

    private void Start()
    {
        displayFPS = GetComponent<TextMeshProUGUI>();
        StartCoroutine(DisplayFPS());
    }

    private void FixedUpdate()
    {
        GenerateFPS();
    }

    private void GenerateFPS()
    {
        dt += (Time.unscaledDeltaTime - dt) * 0.1f;
        currentFPS = 1.0f / dt;
    }

    private IEnumerator DisplayFPS()
    {
        while (true)
        {
            if(currentFPS >= targetFPS)
                displayFPS.color = Color.green;
            else
                displayFPS.color = Color.red;
            displayFPS.text = "FPS: " + currentFPS.ToString(".0");
            yield return new WaitForSeconds(updateDelay);
        }
    }
}
