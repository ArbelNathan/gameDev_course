using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldThePlayer : MonoBehaviour {
    [Tooltip("The number of seconds that the shield remains active")] [SerializeField] float duration;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("Shield triggered by player");
            var destroyComponent = other.GetComponent<DestroyOnTrigger2D>();
            GameObject sheild = other.transform.Find("shield").gameObject;
            if (destroyComponent) {
                destroyComponent.StartCoroutine(ShieldTemporarily(destroyComponent, sheild));
                // NOTE: If you just call "StartCoroutine", then it will not work, 
                //       since the present object is destroyed!
                Destroy(gameObject);  // Destroy the shield itself - prevent double-use
            }
        } else {
            Debug.Log("Shield triggered by "+other.name);
        }
    }
    private IEnumerator ShieldTemporarily(DestroyOnTrigger2D destroyComponent, GameObject shield) {
        shield.SetActive(true);
        destroyComponent.enabled = false;
        for (float i = duration; i > 0; i--) {
            Debug.Log("Shield: " + i + " seconds remaining!");
            yield return new WaitForSeconds(1);
        }
        Debug.Log("Shield gone!");
        destroyComponent.enabled = true;
        shield.SetActive(false);
    }
}
