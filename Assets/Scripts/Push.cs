using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float killTime;
    public float pushForce;

    private float currentTime;
    private void Start()
    {
        currentTime = 0;
    }
    private void Update()
    {
        currentTime += Time.deltaTime;
    }
    public void PushObj()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 0) * pushForce, ForceMode.Impulse);
        Debug.Log("push");
    }
    public void ReScaleObj()
    {
        transform.localScale = new Vector3(1, 1, 1);
        Debug.Log("scale");
    }
    public void KillMe()
    {
        Debug.Log("kill");
        Destroy(gameObject);
    }
}
