using UdonSharp;
using UnityEngine;

public class Cup : UdonSharpBehaviour {
    private Animator _anim;
    private readonly int _drinkState = Animator.StringToHash("DrinkState");

    [UdonSynced]
    private int _state;

    private void Start() {
        this._anim = this.GetComponent<Animator>();
    }

    public override void OnPickupUseDown() {
        this.UpdateState(this.GetNextState());
    }

    public void UpdateState(int state) {
        this._state = state;
        this._anim.SetInteger(this._drinkState, this._state);
    }

    private int GetNextState() {
        if(this._state == 3) {
            return 3;
        }
        return this._state + 1;
    }
}
