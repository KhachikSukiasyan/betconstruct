using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Ellipsoid : Shape3D, IMovable
    {
        protected float a;
        protected float b;
        protected float c;

        public override float Area
        {
            get
            {
                float p = 1.6075f;
                return 4f * (float)Math.PI * (float)Math.Pow(Math.Pow(a * b, p) + Math.Pow(a * c, p) + Math.Pow(b * c, p), 1f / p);
            }
        }

        public override float Volume
        {
            get
            {
                return 4f / 3f * (float)Math.PI * a * b * c;
            }
        }

        public void MoveBy(float dx, float dy, float dz)
        {
            var p = new Point3D();

            p.X = this.Location.X + dx;
            p.Y = this.Location.Y + dy;
            p.Z = this.Location.Z + dz;

            this.Location = p;
        }

        public void MoveTo(Point3D p)
        {
            this.Location = p;
        }

        public void MoveTo(float x, float y, float z)
        {
            this.Location = new Point3D(x, y, z);
        }
    }
}
