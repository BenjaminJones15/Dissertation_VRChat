using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTeleportScript : MonoBehaviour
{
    public GameObject Player;
    public Transform FrontTarget;
    public Transform MainDeckTarget;
    public Transform EgyptTarget;
    public Transform SafariTarget;
    public Transform JapanTarget;

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
            else if (EgyptTarget != null)
            {
                Player.transform.position = EgyptTarget.transform.position;
            }
            else if (SafariTarget != null)
            {
                Player.transform.position = SafariTarget.transform.position;
            }
            else if (JapanTarget != null)
            {
                Player.transform.position = JapanTarget.transform.position;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
