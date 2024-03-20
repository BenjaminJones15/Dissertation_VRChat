using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipTeleportScript : MonoBehaviour
{
    public GameObject Player;
    public Transform FrontTarget;
    public Transform MainDeckTarget;
    public string ScenePath;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            if (FrontTarget != null)
            {
                Player.transform.position = FrontTarget.transform.position;
            }
            else if (MainDeckTarget != null)
            {
                Player.transform.position = MainDeckTarget.transform.position;
            }
            else
            {
                SceneManager.LoadSceneAsync(ScenePath);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
