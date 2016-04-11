using UnityEngine;
using System.Collections;

public class Timing : MonoBehaviour
{
    [SerializeField] private bool canPress;
    private float time = 1;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll != null)
        {
            print("found floor!");
            StartCoroutine(PressingTime());
        }
    }

    IEnumerator PressingTime()
    {
        print("press now");
        canPress = true;

        yield return new WaitForSeconds(time);
        print("cant press");
        canPress = false;
    }
}
