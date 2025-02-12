using UnityEngine;

[CreateAssetMenu(fileName = "Colour Palette")]
public class ColourPalette : ScriptableObject
{
    public Color backgroundColor;
    public Color towerColor, towerHighlight;
    public Color tile1Color, tile2Color, tile3Color, tile4Color, tile5Color;
    public Color textColor;
}
