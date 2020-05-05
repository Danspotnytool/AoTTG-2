using UnityEngine;

public class Blades : OdmgEquipment, Weapon
{
    [SerializeField] private int maxBlades = 5;
    [SerializeField] private float maxBladeDurability = 100f;
    public int NumBlades { get; private set; }
    public float BladeDurability { get; private set; }

    protected override void Awake()
    {
        NumBlades = maxBlades;
        BladeDurability = maxBladeDurability;
    }

    protected override void Update()
    {
    }

    public void Resupply()
    {

    }

    #region Weapon Methods
    public void Attack()
    {

    }

    public void Reload()
    {

    }
    #endregion
}
