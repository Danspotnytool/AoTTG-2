using UnityEngine;

[RequireComponent(typeof(Interactable))]
public class SupplyStationInteractable : MonoBehaviour, IInteractable
{
    private void Start()
    {
        if (Minimap.instance != null)
        {
            Minimap.instance.TrackGameObjectOnMinimap(base.gameObject, Color.white, false, true, Minimap.IconStyle.SUPPLY);
        }
	}

    void IInteractable.Execute(GameObject target)
    {
        Hero hero = target.GetComponent<Hero>();
        if (hero && IN_GAME_MAIN_CAMERA.gametype == GAMETYPE.SINGLE || hero.photonView.isMine)
        {
            hero.getSupply();
        }
    }
}
