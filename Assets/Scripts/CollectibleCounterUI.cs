using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleCounterUI : MonoBehaviour
{
    public static CollectibleCounterUI Instance;
    public TextMeshProUGUI text;
    private int current = 0;
    private int total = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void SetTotal(int totalCollectibles)
    {
        total = totalCollectibles;
        UpdateText();
    }

    public void Increment()
    {
        current++;
        UpdateText();
    }

    private void UpdateText()
    {
        text.text = $"Collectibles: {current}";
    }
}
