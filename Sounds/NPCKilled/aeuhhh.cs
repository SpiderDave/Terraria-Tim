using Microsoft.Xna.Framework.Audio;
using Terraria.ModLoader;

namespace Tim.Sounds.NPCKilled
{
    public class soundTest : ModSound
    {
        public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
        {
            soundInstance = sound.CreateInstance();
            soundInstance.Volume = volume;
            soundInstance.Pan = pan;
            soundInstance.Pitch = 0;
            return soundInstance;
        }
    }
}