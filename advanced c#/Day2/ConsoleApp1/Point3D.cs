using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point3D
    {
        public int x;
        public int y; 
        public int z;

        public Point3D(int x=0,int y=0,int z=0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({x},{y},{z})";
        }

        public static Point3D parse(in int x=0, in int y=0, in int z=0)
        {
            return new Point3D(x,y,z);
        }

        public override bool Equals(object? obj)
        {
            Point3D p = (Point3D) obj;
            return (this.x == p.x && this.y == p.y && this.z == p.z);
        }

        public static void sort (Point3D[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                for(int j = 0; j < p.Length; j++)
                {
                    if (p[i].x > p[j].x)
                    {
                        Point3D.swap(ref p[i],ref p[j]);
                    }
                    else if (p[i].y > p[j].y)
                    {
                        Point3D.swap(ref p[i], ref p[j]);
                    }
                    else if (p[i].z > p[j].z)
                    {
                        Point3D.swap(ref p[i], ref p[j]);
                    }
                }
            }
        }

        private static void swap (ref Point3D p1,ref Point3D p2) {
            Point3D temp = p1;
            p1 = p2;
            p2 = temp;
            
        }



    }

 
}
