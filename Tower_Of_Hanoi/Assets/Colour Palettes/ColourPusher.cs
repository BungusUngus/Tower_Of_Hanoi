using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ColourPusher : MonoBehaviour
{
    //Get all the coloured objects in our game.
    public Game gameRef;
    public Image tile1, tile2, tile3, tile4, tile5;
    public TMP_Text turnDisplay;

    //Colour PROPERTIES; when palette is changed, push update to coloured objects
    public ColourPalette currentPalette;

    public ColourPalette currentPaletteProperty
    {
        get
        {
            return currentPalette;
        }
        set
        {
            currentPalette = value;
            Camera.main.backgroundColor = currentPalette.backgroundColor;
            tile1.color = currentPalette.tile1Color;
            tile2.color = currentPalette.tile2Color;
            tile3.color = currentPalette.tile3Color;
            tile4.color = currentPalette.tile4Color;
            tile5.color = currentPalette.tile5Color;
            turnDisplay.color = currentPalette.textColor;
            gameRef.regularColour = currentPalette.towerColor;
            gameRef.highlightedColour = currentPalette.towerHighlight;
            gameRef.ApplyPalette();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentPaletteProperty = currentPalette;
    }
}
