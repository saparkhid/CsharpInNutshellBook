using Ch3_1.UltraMath;

namespace Ch3_1.Raphson
{
    public class Raphson
    {
        MathHelper _helper;

        public Raphson()
        {
            _helper = new MathHelper();
        }
        public double Estimate() => MathHelper.Phi * 2.0;
      
        public double Estimate(int v) =>  MathHelper.Phi *v * 2.0;
        
        public double Estimate(double v)
        {
            return MathHelper.Phi * v * 2.0;
        }
    }
}