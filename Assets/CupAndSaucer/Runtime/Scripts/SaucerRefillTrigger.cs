using UdonSharp;
using UnityEngine;

public class SaucerRefillTrigger : UdonSharpBehaviour {
    public GameObject cup;

    public bool CanRefill { get; private set; }

    private void OnTriggerEnter(Collider other) {
        if(this.IsTriggeredByMyCup(other)) {
            this.CanRefill = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(this.IsTriggeredByMyCup(other)) {
            this.CanRefill = false;
        }
    }

    private bool IsTriggeredByMyCup(Collider other) {
        return this.cup == other.gameObject;
    }
}
