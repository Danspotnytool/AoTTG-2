using UnityEngine;

public class Blades : OdmgEquipment, Weapon
{
    [SerializeField] private GameObject myHero;
    private Hero myHeroScript;

    [SerializeField] private int maxBlades = 5;
    [SerializeField] private float maxBladeDurability = 100f;
    public int NumBlades { get; private set; }
    public float BladeDurability { get; private set; }

    protected override void Awake()
    {
        myHeroScript = myHero.GetComponent<Hero>();
        base.Initialize(myHeroScript);

        NumBlades = maxBlades;
        BladeDurability = maxBladeDurability;
    }

    protected override void Update()
    {
    }

    public void Attack()
    {

    }

    public void Reload()
    {

    }

    public new void Resupply()
    {
        base.Resupply();
    }
}
