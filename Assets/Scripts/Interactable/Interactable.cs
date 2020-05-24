using UnityEngine;

public class Interactable : MonoBehaviour
{
    private CapsuleCollider collider;

    public int Radius = 7;

    [Tooltip("Text displayed on Interactable wheel")]
    public string Context = "";

    [Tooltip("Icon displayed on Interactable wheel button")]
    public UnityEngine.Sprite Icon;

    void Awake()
    {
		var interactableObject = new GameObject("Interactable");
        interactableObject.layer = LayerMask.NameToLayer(Layer.Interactable);
        collider = interactableObject.AddComponent<CapsuleCollider>();
        collider.radius = Radius;
        collider.isTrigger = true;
        interactableObject.transform.parent = transform;
        interactableObject.transform.localPosition = new Vector3();
        if(string.IsNullOrEmpty(Context))
            Context = name;
    }

    public void Action(GameObject target)
    {
        // Thought of caching this,
        // but the performance impact is negligible,
        // and caching may cause unintended effects - Wagner
        foreach (var interactable in this.GetComponents<IInteractable>())
        {
            interactable.Execute(target);
        }
    }
}
