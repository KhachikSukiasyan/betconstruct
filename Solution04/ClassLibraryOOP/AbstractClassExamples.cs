using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOOP
{
    public abstract class AbstractClass
    {
        public abstract void DoWork();

        public void DoAnotherWork()
        {

        }

        public virtual void F()
        {
            
        }

        public int x;
        public int Y { get; set; }
        public abstract int Z { get; set; }

        public AbstractClass()
        {

        }

        public AbstractClass(int x)
        {
            this.x = x;
        }

        // Wrong syntax
        //public abstract AbstractClass(int x, int y, int z);
    }

    public class InheritedClass1 : AbstractClass
    {
        public override int Z
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void DoWork()
        {
            throw new NotImplementedException();
        }
    }
}
