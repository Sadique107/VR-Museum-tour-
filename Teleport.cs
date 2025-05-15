using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Teleport : MonoBehaviour,IPointerDownHandler
{
    public Transform player;

    public void OnPointerDown(PointerEventData eventData)
    {
        player.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
    }
}
