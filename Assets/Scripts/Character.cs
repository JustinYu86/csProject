using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int Health { get; set; }

    public Character()
    {
        Health = 100;
    }
}
