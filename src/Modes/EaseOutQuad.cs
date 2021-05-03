namespace Appalachia.Utility.Interpolation.Modes
{
    public struct EaseOutQuad : IInterpolationMode
    {
        public float Interpolate(float v0, float v1, float t)
        {
            return InterpolationFactory.EaseOutQuad(v0, v1, t);
        }
    }
}
