using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.TopDownEngine;

public class AttackWithWeapon : CharacterAbility
{
    // Start is called before the first frame update
    void Start()
    {
        base.Initialization();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
		{
            this._animator.SetBool("SwordSlash1", true);
		}
    }
}
