using UnityEngine;

public class Game : MonoBehaviour
{
    //Which tower has the player just selected
    public Tower selectedTower;

    //Collection of all the towers
    public Tower[] towers;

    //Colour palette for our towers
    public Color regularColour, highlightedColour;


    void Start()
    {
        ApplyPalette();
    }


    /*
     * Triggered by our Unity Buttons
     * if I don't have a tower selected, be the tower we just clicked
     * if the tower I click is my selected tower, deselect ( set to null )
     * otherwise, perform a movement between the selectedTower and the new tower.
     * Trigger the 'ApplyPalette' function regardless of result.
     */
    public void SelectTower(Tower newTower)
    {
        if (selectedTower == null)
        {
            selectedTower = newTower;
            print("Selected tower is" + selectedTower.name);
        }
        else if (newTower == selectedTower)
        {
            selectedTower = null;
        }
        else
        {
            MoveTiles(selectedTower, newTower);
            selectedTower = null;
        }
        ApplyPalette();
    }

    /*
     * Take the top tile we want to move
     * if there isn't one, stop the function! (we can't move from empty tower)
     * Compare it with the tile at our target tower
     * If the target tower is empty, move
     * or if the top tile is < target tile, move
     * move = reassign parent as the targetTower's parent
     */
    public void MoveTiles(Tower fromTower, Tower toTower)
    {
        //print("Moving from" + fromTower.name + "to" + toTower.name);
        Transform topTile = fromTower.GetTopTile();
        if (topTile == null) return;



        Transform targetTile = toTower.GetTopTile();
        if (targetTile == null || topTile.GetComponent<RectTransform>().rect.width < targetTile.GetComponent<RectTransform>().rect.width)

        {
            topTile.SetParent(toTower.towerAnchor);
            topTile.SetSiblingIndex(0);
        }
    }

    /*
     * Every tower will change colour to 'regularColour'
     * selectedTower is overridden with 'highlightedColour'
     */
    public void ApplyPalette()
    {
        foreach (Tower tower in towers)
            tower.AssignColour(regularColour);

        if (selectedTower != null)
            selectedTower.AssignColour(highlightedColour);
    }
}
