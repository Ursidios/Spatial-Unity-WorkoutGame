using UnityEngine;
using SpatialSys.UnitySDK;

public class AnimationPlayer : MonoBehaviour
{
    public void StartPunchAnimation()
    {
        SpatialBridge.actorService.localActor.avatar.PlayEmote(AssetType.EmbeddedAsset, "Punch");
    }

    public void StopAnimation()
    {
        SpatialBridge.actorService.localActor.avatar.StopEmote();
    }

    public void StartHoldDumbbell()
    {
        SpatialBridge.actorService.localActor.avatar.EquipAttachment(AssetType.EmbeddedAsset,"Dumbell");
    }    
    
    public void StartDumbbellAnimation()
    {
        SpatialBridge.actorService.localActor.avatar.PlayEmote(AssetType.EmbeddedAsset, "Biceps");
    }

    public void ExitHoldDumbbell()
    {
        SpatialBridge.actorService.localActor.avatar.ClearAttachmentSlot(SpatialAvatarAttachment.Slot.RightHand);
    }
}
