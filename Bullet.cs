using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	[SerializeField] private Rigidbody2D rb;
    public float timer = 1;
    float r;

    private void Update()
    {
        if(timer <= 0)
        {
            int ran = Random.Range(-1, 2);
            float Target = transform.rotation.eulerAngles.z + 90 * ran;
            float Angle = Mathf.SmoothDampAngle(transform.eulerAngles.z, Target, ref r, 0.5f);
            transform.rotation = Quaternion.Euler(0, 0,  Angle);
            timer = 1;
        }
        else
        {
            timer -= Time.deltaTime;
        }

    }
}
