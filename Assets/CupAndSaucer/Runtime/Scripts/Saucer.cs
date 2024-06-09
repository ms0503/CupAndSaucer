using UdonSharp;
using UnityEngine;

public class Saucer : UdonSharpBehaviour {
    [SerializeField]
    private GameObject refillTrigger;

    private bool _canRefill;

    public override void Interact() {
        var refillTriggerComponent = this.refillTrigger.GetComponent<SaucerRefillTrigger>();
        if(!refillTriggerComponent.CanRefill) {
            return;
        }
        refillTriggerComponent.cup.GetComponent<Cup>().UpdateState(0);
    }
}
