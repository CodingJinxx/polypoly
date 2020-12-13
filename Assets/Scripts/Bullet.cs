using UnityEngine;
using System;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    public float Speed = 10.0f;

    public void Update(){
        this.transform.localPosition += Speed * this.transform.forward * Time.deltaTime;
    }
}