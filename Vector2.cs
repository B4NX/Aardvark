using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aardvark {
    public struct Vector2{
        private float x, y;

        public Vector2(float i) {
            this.x = i;
            this.y = i;
        }
        public Vector2(float x, float y) {
            this.x = x;
            this.y = y;
        }

        public float X {
            get { return this.x; }
            set { this.x = value; }
        }
        public float Y {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Length { get { return Math.Sqrt(this.x*this.x + this.y*this.y); } }
        public double LengthSquared { get { return this.Length * this.Length; } }

        /// <summary>
        /// Returns a representation of the vector as a string
        /// </summary>
        public override string ToString() {
            return String.Format("<{0},{1}>", this.x, this.y);
        }

        public static Vector2 operator +(Vector2 i, Vector2 j) {
            return new Vector2(i.x + j.x, i.y + j.y);
        }
        public static Vector2 operator -(Vector2 i, Vector2 j) {
            j.Negate();
            return i + j ;
        }
        public static Vector2 operator *(Vector2 v, float x) {
            return new Vector2(v.x * x, v.y * x);
        }
        public static float operator *(Vector2 i, Vector2 j) {//Dot Product
            return (i.x * j.x) + (i.y * j.y);
        }
        public static Vector2 operator /(Vector2 v, float x) {
            return new Vector2(v.x / x, v.y / x);
        }
        /// <summary>
        /// Gets the angle between the two given vectors
        /// </summary>
        /// <returns></returns>
        public static double AngleBetween(Vector2 u, Vector2 v) {
            return Math.Acos((u * v) / (u.Length * v.Length));
        }
        /// <summary>
        /// Negates the vector
        /// </summary>
        public void Negate() { /*this.x *= -1; this.y *= -1;*/ this = this * -1; }
        /// <summary>
        /// Normalizes the vector, turning it into a vector in the same direction with a magnitude of one.
        /// </summary>
        public void Normalize() { this = this / (float)this.Length; }

        /// <summary>
        /// Takes a string in the form "x,y" and converts it to a Vector
        /// </summary>
        /// <param name="s"> The string to construct the vector from.</param>
        [System.Obsolete]
        public static Vector2 Parse(String s) {//TODO
            return new Vector2();
        }
    } 
}
