using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleCrate : MonoBehaviour
{
    public void Damage()
    {
        Destroy(gameObject);
    }
}
