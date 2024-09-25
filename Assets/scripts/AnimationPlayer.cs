using UnityEngine;
using SpatialSys.UnitySDK;

public class AnimationPlayer : MonoBehaviour
{

    public GameObject Arrow;
    public GameObject Weight;
    public void StartPunchAnimation()
    {
        SpatialBridge.actorService.localActor.avatar.PlayEmote(AssetType.EmbeddedAsset, "Punch");
    }
    public void StartFallAnimation()
    {
        SpatialBridge.actorService.localActor.avatar.Jump();
        SpatialBridge.actorService.localActor.avatar.PlayEmote(AssetType.EmbeddedAsset, "Fall");
    }

    public void StopAnimation()
    {
        SpatialBridge.actorService.localActor.avatar.StopEmote();
    }

    public void StartHoldDumbbell()
    {
        SpatialBridge.actorService.localActor.avatar.ClearAttachmentSlot(SpatialAvatarAttachment.Slot.RightHand);
        SpatialBridge.actorService.localActor.avatar.EquipAttachment(AssetType.EmbeddedAsset,"Dumbell");
    } 

    public void StartHoldBow()
    {
        SpatialBridge.actorService.localActor.avatar.ClearAttachmentSlot(SpatialAvatarAttachment.Slot.RightHand);
        SpatialBridge.actorService.localActor.avatar.EquipAttachment(AssetType.EmbeddedAsset,"Bow");
        SpatialBridge.actorService.localActor.avatar.EquipAttachment(AssetType.EmbeddedAsset,"ArrowSac");
    }    
       
    
    public void StartDumbbellAnimation()
    {
        //SpatialBridge.actorService.localActor.avatar.PlayEmote(AssetType.EmbeddedAsset, "Biceps");
        SpatialBridge.actorService.localActor.avatar.PlayEmote(AssetType.EmbeddedAsset, "Throw");
        Instantiate(Weight, SpatialBridge.actorService.localActor.avatar.position, SpatialBridge.actorService.localActor.avatar.rotation);
    }

    public void ExitHoldDumbbell()
    {
        SpatialBridge.actorService.localActor.avatar.ClearAttachmentSlot(SpatialAvatarAttachment.Slot.RightHand);
    }
    public void ExitHoldBow()
    {
        SpatialBridge.actorService.localActor.avatar.ClearAttachmentSlot(SpatialAvatarAttachment.Slot.LeftHand);
        SpatialBridge.actorService.localActor.avatar.ClearAttachmentSlot(SpatialAvatarAttachment.Slot.BodyBack);
    }
    public void StartShootAnimation()
    {
        SpatialBridge.actorService.localActor.avatar.PlayEmote(AssetType.EmbeddedAsset, "Shoot");
        Instantiate(Arrow, SpatialBridge.actorService.localActor.avatar.position, SpatialBridge.actorService.localActor.avatar.rotation);
    }

}
