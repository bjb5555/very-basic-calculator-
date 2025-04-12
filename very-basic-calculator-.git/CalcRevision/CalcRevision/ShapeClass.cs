using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcRevision
{
    internal class ShapeClass
    {
        //going to be used for Pythagorean theorem, trigometry, finding the area of a circle, finding volumes and areas in general and more shape related stuff
        public double A;
        public double B;
        public double C;
        private double hypotenuse;
        private double adjacent;
        private double opposite;
        private double diamter;
        private double radius;
        private double area;
        private double volume;
        private double answer;

        public ShapeClass()
        {
            A = 0.0;
            B = 0.0;
            C = 0.0;
            hypotenuse = 0.0;
            adjacent = 0.0;
            opposite = 0.0;
            diamter = 0.0;
            radius = 0.0;
            area = 0.0;
            volume = 0.0;
            answer = 0.0;
        }

        public ShapeClass(double A, double B, double C, double answer)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.answer = answer;
        }


        public ShapeClass(double A, double B, double C, double hypotenuse, double adjacent, double opposite, double diamter, double radius, double area, double volume, double answer)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.hypotenuse = hypotenuse;
            this.adjacent = adjacent;
            this.opposite = opposite;
            this.diamter = diamter;
            this.radius = radius;
            this.area = area;
            this.volume = volume;
            this.answer = answer;
        }

        public double a
        {
            get { return A; }
            set { A = value; }
        }

        public double b
        {
            get { return B; }
            set { B = value; }
        }
        public double c
        {
            get { return C; }
            set { C = value; }
        }

        public double Hypotenuse
        {
            get { return hypotenuse;  }
            set { hypotenuse = value; }
        }

        public double Adjacent
        {
            get { return adjacent; }
            set { adjacent = value; }
        }

        public double Opposite
        {
            get { return opposite; }
            set { opposite = value; }
        }

        public double Diamter
        {
            get { return diamter; }
            set { diamter = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public double Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public void FindA()
        {
            double Csquared = C * C;
            double Bsquared = B * B;
            double Asquared = Csquared - Bsquared;
            A = Math.Sqrt(Asquared);
            answer = A;
            Console.WriteLine(A);
        }
        public void FindB()
        {
            double Asquared = A * A;
            double Csquared = C * C;
            double Bsquared = Csquared - Asquared;
            B = Math.Sqrt(Bsquared);
            answer = B;
            Console.WriteLine(B);
        }
        public void FindC()
        {
            double Asquared = A * A;
            double Bsquared = B * B;
            double Csquared = Bsquared + Asquared;
            C = Math.Sqrt(Csquared);
            answer = C;
            Console.WriteLine(C);
        }


    }
}
