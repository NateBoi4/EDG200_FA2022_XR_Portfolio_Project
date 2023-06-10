using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerCharge : MonoBehaviour
{
    [Range(-1.0f, 200.0f)]
    public float charge = 200.0f;

    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public Transform headPos;

    public float GetCharge() { return charge; }

    private void Start()
    {
        slider.maxValue = charge;
        slider.value = charge;
        fill.color = gradient.Evaluate(1.0f);
    }

    public void UseCharge(float amount)
    {
        charge -= amount;
    }

    public void RestoreCharge(float amount)
    {
        charge += amount;
    }

    private void Update()
    {
        charge = Mathf.Clamp(charge, -1.0f, 200.0f);
        slider.value = charge;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
