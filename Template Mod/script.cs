using UnityEngine;
namespace Mod{
    public class Mod{
        public static void Main(){
            ModAPI.Register(new Modification(){

                OriginalItem = ModAPI.FindSpawnable("Metal Cube"),
                NameOverride = "Blue Brick",DescriptionOverride = "A blue brick",
                CategoryOverride = ModAPI.FindCategory("Misc."),
                ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Blue-Brick-thumb.png"),
                AfterSpawn = (Instance) =>{Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/Blue-Brick.png");

                    Instance.FixColliders();
                }
            }
            );

            ModAPI.Register(new Modification(){OriginalItem = ModAPI.FindSpawnable("Stick"),

                NameOverride = "Sand",DescriptionOverride = "I hate sand",CategoryOverride = ModAPI.FindCategory("Misc."),
                ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/sand.png"),
                AfterSpawn = (Instance) =>{Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/sand.png");

                    Instance.FixColliders();
                        
                }
            }
           );
        }
    }
}