using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Interactable))]
public class PlayerInteractable : MonoBehaviour, IInteractable
{

    public List<Interactable> Collisions { get; set; } = new List<Interactable>();

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer(Layer.Interactable))
        {
            var interactable = col.gameObject.GetComponentInParent<Interactable>();
            if (Collisions.Any(x => x == interactable)) return;
            Collisions.Add(interactable);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer(Layer.Interactable))
        {
            Collisions.Remove(col.gameObject.GetComponentInParent<Interactable>());
        }
    }

    public void Execute(GameObject target)
    {
        //throw new System.NotImplementedException();
    }
}
