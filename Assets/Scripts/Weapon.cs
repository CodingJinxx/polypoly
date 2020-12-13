using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private static Transform SpawnedObjectContainer;
    [SerializeField]
    private Bullet Ammo;

    [SerializeField]
    private float Damage;
    [SerializeField]
    private FirstPersonController Player;
    [SerializeField]
    private Transform ProjectileOrigin;

    public void Start(){
        if(SpawnedObjectContainer == null){
            SpawnedObjectContainer = GameObject.FindGameObjectWithTag("SpawnedObjectContainer").transform;
        }
        Player.OnFireEvent += Trigger;
    }

    public void Trigger(){
        Instantiate(Ammo, ProjectileOrigin.position, ProjectileOrigin.rotation, SpawnedObjectContainer);
    }
}
