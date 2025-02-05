using UnityEngine;
using UnityEngine.UI;

public class Tower : MonoBehaviour
{
    public Image towerBase, towerHeight;
    public Transform towerAnchor;

    /*
        Assign Colours to the tower base and height
        Colour is given by 'Game'
    */
    #region Colour
    public void AssignColour(Color newColor)
    {
        towerBase.color = newColor;
        towerHeight.color = newColor;
        //Change outline
        //Change background colour?

    }
    #endregion

    /*
        Use a ternary to return 
     */
    public Transform GetTopTile()
    {

        //takes condition and puts a query then if true do whats to the left and not true do to the right 
        return towerAnchor.childCount > 0 ? towerAnchor.GetChild(0) : null;
    }
}
