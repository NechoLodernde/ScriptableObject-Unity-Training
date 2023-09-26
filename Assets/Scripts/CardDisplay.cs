using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{

    public Card card;

    public TMP_Text nameText;
    public TMP_Text descText;
    public TMP_Text attackText;
    public TMP_Text defenseText;
    public Image artworkImage;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.name;
        descText.text = card.description;

        artworkImage.sprite = card.artwork;

        attackText.text = card.attack.ToString();
        defenseText.text = card.defense.ToString();

    }

    
}
