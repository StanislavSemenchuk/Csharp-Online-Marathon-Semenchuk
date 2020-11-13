using System;
using System.Collections.Generic;

namespace Task_04
{
    public interface IShape : ICloneable
    {
        public double Area() => 0;
    }
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area() => Length * Width;

        public object Clone()
        {
            return new Rectangle { Length = this.Length, Width = this.Width };
        }
    }

    public class Trapezoid : IShape 
    {
        public double Length1 { get; set; }
        public double Length2 { get; set; }
        public double Width { get; set; }
        public double Area() => (Width) * (Length1 + Length2)/2;

        public object Clone()
        {
            return new Trapezoid { Length1 = this.Length1, Length2 = this.Length2, Width = this.Width };
        }
    }

    public class Room<T> : ICloneable, IComparable where T : IShape 
    {
        public double Height { get; set; }
        public T Floor { get; set; }
        public double Volume() => Floor.Area() * Height;
        public object Clone()
        {
            return new Room<T> { Height = this.Height, Floor = (T)this.Floor.Clone() };
        }

        public int CompareTo(object obj)
        {
            Room<T> p = obj as Room<T>;
            if (p != null)
                return this.Floor.Area().CompareTo(p.Floor.Area());
            else
                throw new Exception("Imposible to compare this objects");
        }
    }

    public class RoomComparerByVolume<T> : IComparer<Room<T>> where T : IShape
    {
        public int Compare(Room<T> x, Room<T> y)
        {
            if (x.Volume() > y.Volume())
                return 1;
            else if (x.Volume() < x.Volume())
                return -1;
            else
                return 0;
        }
    }
}
