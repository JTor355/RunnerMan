using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanishingfloors : Traps
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void Trigger()
    {

        Destroy(this.gameObject);
    }
}
