using Unity.Entities;
using Unity.Mathematics;

namespace TMG.Zombies

{

    public struct GraveyardProperties :IComponentData
    {
        public float2 FieldDimensions;
        public int NumberOfTombstonesToSpawn;
        public Entity TombstonePrefab;
    }
}