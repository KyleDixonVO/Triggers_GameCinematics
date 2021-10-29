using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public GameObject light;
    public Collider lightCollider;
    public AudioSource triggerSound;
    public Collider soundCollider;
    public Transform TeleportTarget;
    public CharacterController cc;
    public GameObject player;
    public Collider TeleportCollider;
    public Camera playerCamera;
    public Transform TeleportCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == lightCollider)
        { 
            light.SetActive(false); 
        }

        if (other == soundCollider)
        {
            triggerSound.Play();
        }

        if (other == TeleportCollider)
        {
            cc.enabled = (false);
            player.transform.position = TeleportTarget.transform.position;
            cc.enabled = (true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == lightCollider)
        {
            light.SetActive(true);
        }
    }
}
