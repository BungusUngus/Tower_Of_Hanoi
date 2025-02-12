using UnityEngine;

public class TileAnimations : MonoBehaviour
{

    //Get the Animator componant from the thing you want animated
    private Animator myAni;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        myAni = GetComponent<Animator>();
    }

    void Start()
    {

    }

    /*Trigger the rising animation
     *Prompted in game
    */


    public void StartRise()
    {
        myAni.SetTrigger("Rise");
    }

    /*Trigger the Falling animation
     *Prompted in game
    */

    public void StartFall()
    {
        myAni.SetTrigger("Fall");
    }
}
