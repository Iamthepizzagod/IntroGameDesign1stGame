using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public float waitToRespawn;

    public GameObject currentCheckpoint;

    //the name of the script you have attached to the player
    private playerController player;


    // Use this for initialization
    void Start () {
        player = FindObjectOfType<playerController>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnPlayer ()
    {
        StartCoroutine("RespawnCoroutine");
    }

    public IEnumerator RespawnCoroutine()
    {
        player.gameObject.SetActive(false);
        yield return new WaitForSeconds(waitToRespawn);
        player.gameObject.SetActive(true);
        player.transform.position = currentCheckpoint.transform.position;
    }

}
