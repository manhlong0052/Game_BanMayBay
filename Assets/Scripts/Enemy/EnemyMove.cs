using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float smoothing = 1f;
    public Transform target;
    public Transform target2;
    public Transform target3;
    public Transform target4;

    public float timeDelay = 1f;

    public bool isDone = false;
    public bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(myCorotine(target));
        
    }

    IEnumerator myCorotine(Transform target)
    {
        while (Vector3.Distance(transform.position, target.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);

            yield return null;
        }

        yield return new WaitForSeconds(this.timeDelay);

        while (Vector3.Distance(transform.position, target2.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target2.position, smoothing * Time.deltaTime);

            yield return null;
        }

        yield return new WaitForSeconds(this.timeDelay);

        while (Vector3.Distance(transform.position, target3.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target3.position, smoothing * Time.deltaTime);

            yield return null;
        }

        yield return new WaitForSeconds(this.timeDelay);

        while (Vector3.Distance(transform.position, target4.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target4.position, smoothing * Time.deltaTime);

            yield return null;
        }

        yield return new WaitForSeconds(2f);

        this.isDone = true;
    }
}
