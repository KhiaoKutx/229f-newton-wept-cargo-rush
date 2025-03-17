using System;
using TMPro;
using UnityEngine;

public class KM : MonoBehaviour
{
    public Transform a, b;
    public TMP_Text text;

    private void Update()
    {
        text.text = (a.position-b.position).magnitude.ToString("00 m");
    }
}
