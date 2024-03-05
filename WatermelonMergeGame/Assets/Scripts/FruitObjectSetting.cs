using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create FruitObjectSetting", fileName = "FruitObjectSetting", order = 0)]
public class FruitObjectSetting : ScriptableObject
{
    [SerializeField] private FruitObject prefab;
    [SerializeField] private List<Sprite> sprites;
    [SerializeField] private List<float> scales;

    public FruitObject spawnObject => prefab;
    public Sprite GetSprite(int index)
    {
        if (index < 0 || index >= sprites.Count)
        {
            Debug.LogError("Out of range");
        }
        return sprites[index];
    }
    public float GetScale(int index)
    {
        if (index < 0 || index >= scales.Count)
        {
            Debug.LogError("Out of range");
        }
        return scales[index];
    }

    [ContextMenu(nameof(SetScaleData))]
    public void SetScaleData()
    {
        scales.Clear();
        for (int i = 0; i < sprites.Count; i++)
        {
            scales.Add((i + 1) * .25f);
        }
    }
}
