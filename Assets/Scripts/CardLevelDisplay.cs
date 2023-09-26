using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardLevelDisplay : MonoBehaviour
{
    public Image levelIcon;
    public CardDisplay cardInstance;
    private int levelNum;

    // Start is called before the first frame update
    void Start()
    {
        levelNum = cardInstance.card.level;
        Display();
    }

    public void Display()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < levelNum; i++)
        {
            Image newImage = Instantiate(levelIcon);
            newImage.transform.SetParent(transform, false);
        }
    }
}
