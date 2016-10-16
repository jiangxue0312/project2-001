using UnityEngine;
using System.Collections;

public class Mole : MonoBehaviour {

    private static Animator animator;
    private bool showflag = false;

    private GameObject moles;
    private MoleManager t;



    // Use this for initialization
    void Start () {
       
        moles = GameObject.Find("Moles");
        t = moles.GetComponent<MoleManager>();
    }
	
	// Update is called once per frame
	void Update () {

        if (showflag)
        {
            float timeHide = t.HideDelay;
            StartCoroutine(Hide(timeHide));
        }
	
	}


    public void Show()
    {
        Debug.Log("Mole.cs_Show");
        if (showflag) return;
        //animator.SetTrigger("Show");
        GetComponent<Animator>().Play("Diglett_show");
        showflag = true;
    }

    void Hit()
    {
        Debug.Log("Mole.cs_Hit");
        showflag = false;
        GetComponent<Animator>().Play("Diglett_hit");
    }

    IEnumerator Hide(float timeHide)
    {
        Debug.Log("Mole.cs_Hide");
        showflag = false;
        yield return new WaitForSeconds(timeHide);

        GetComponent<Animator>().Play("Diglett_hide");
        //animator.SetTrigger("Hide");
    }


}
