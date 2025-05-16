using System;
using UnityEngine;

namespace StateMachine
{
    public class Entity : MonoBehaviour
    {
        protected StateMachine _stateMachine;

        protected virtual void Awake() => _stateMachine = new StateMachine();

        protected virtual void Update() => _stateMachine.Update();

        protected void FixedUpdate() => _stateMachine.FixedUpdate();
        
        protected void At(IState from, IState to, IPredicate condition) => _stateMachine.AddTransition(from, to, condition);
        protected void Any(IState to, IPredicate condition) => _stateMachine.AddAnyTransition(to, condition);

    }
}