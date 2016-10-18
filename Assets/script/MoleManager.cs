using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoleManager : MonoBehaviour {

    // Use this for initialization
    // List of the Mole 
    public List<GameObject> moleList = new List<GameObject>();
    // Time to wait before start the game, start to go time
    public float StartDelay;
    // Time before showing the mole 
    public float ShowDelay;
    // Time before hiding the mole
    public float HideDelay;

    private int totalNum = 5;

    // Maximum number of moles show in one term
    //public int MaxMole;

	void Start () {
        Debug.Log("ManagerStart");
        InvokeRepeating("MoleShow", StartDelay, ShowDelay);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void MoleShow()
    {
        int random = Random.Range(0, totalNum);
        Debug.Log("random: " + random);
        for (int i = 0; i < random; i++)
        {
            moleList[Random.Range(0, moleList.Count)].GetComponentInChildren<Mole>().Show();
        }

        //int random2 = Random.Range(0, moleList.Count);
        //while (random == random2)
        //{
        //    random2 = Random.Range(0, moleList.Count);
        //}
        //Debug.Log("random: " + random);
        //Debug.Log("random2: " + random2);
        //[random].GetComponentInChildren<Mole>().Show();
        //moleList[random2].GetComponentInChildren<Mole>().Show();
    }
}
