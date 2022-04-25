using UnityEngine;

public class Enlarge : MonoBehaviour

{
    Animator anim;
    private Vector3 bigScale, smallScale;
    private bool isBig;

    private void Start()
    {
        
        bigScale = new Vector3(200f, 200f,200f);
        smallScale = new Vector3(50f, 50f, 50f);

        isBig = true;
    }
    private void OnMouseEnter()
    {

        transform.localScale = isBig ? smallScale : bigScale;

        isBig = !isBig;
        anim.SetTrigger("enlarge");

    }
    void OnMouseExit()
    {
        transform.localScale = isBig ? smallScale : bigScale;

        isBig = !isBig;
    }
}
