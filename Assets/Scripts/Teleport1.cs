using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Teleport1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportTo;
    public GameObject TeleportTo2;
    public GameObject TeleportTo3;
    public GameObject TeleportTo4;
    public GameObject TeleportTo5;
    public GameObject TeleportTo6;
    public GameObject TeleportTo7;
    public GameObject TeleportTo8;
    public GameObject TeleportTo9;
    public GameObject TeleportTo10;
    public GameObject TeleportTo11;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Teleporter")
        {
            Player.transform.position = TeleportTo.transform.position;
        }

        if (other.gameObject.tag == "Teleporter2")
        {
            Player.transform.position = TeleportTo2.transform.position;
        }

        if (other.gameObject.tag == "Teleporter3")
        {
            Player.transform.position = TeleportTo3.transform.position;
        }

        if (other.gameObject.tag == "Teleporter4")
        {
            Player.transform.position = TeleportTo4.transform.position;
        }

        if (other.gameObject.tag == "Teleporter5")
        {
            Player.transform.position = TeleportTo5.transform.position;
        }

        if (other.gameObject.tag == "Teleporter6")
        {
            Player.transform.position = TeleportTo6.transform.position;
        }

        if (other.gameObject.tag == "Teleporter7")
        {
            Player.transform.position = TeleportTo7.transform.position;
        }

        if (other.gameObject.tag == "Teleporter8")
        {
            Player.transform.position = TeleportTo8.transform.position;
        }

        if (other.gameObject.tag == "Teleporter9")
        {
            Player.transform.position = TeleportTo9.transform.position;
        }

        if (other.gameObject.tag == "Teleporter10")
        {
            Player.transform.position = TeleportTo10.transform.position;
        }

        if (other.gameObject.tag == "Teleporter11")
        {
            Player.transform.position = TeleportTo11.transform.position;
        }

    }
}
