using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace TMG.Zombies
{
    public class GraveyardMono : MonoBehaviour
    {
        public float2 FieldDimensions;
        public int NumberOfTombstonesToSpawn;
        public GameObject TombstonePrefab;
        public uint RandomSeed;
    }

    public class GraveyardBaker : Baker<GraveyardMono>
    {
        public override void Bake(GraveyardMono authoring)
        {
            var graveyardEntity = GetEntity(TransformUsageFlags.Dynamic);

            AddComponent(graveyardEntity, new GraveyardProperties
            {
                FieldDimensions = authoring.FieldDimensions,
                NumberOfTombstonesToSpawn = authoring.NumberOfTombstonesToSpawn,
                TombstonePrefab = GetEntity(authoring.TombstonePrefab, TransformUsageFlags.Dynamic),
            });
            AddComponent(graveyardEntity, new GraveyardRandom
            {
                Value = Unity.Mathematics.Random.CreateFromIndex(authoring.RandomSeed)
            });

        }
    }
}

