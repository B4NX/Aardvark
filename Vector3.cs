using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aardvark {
    public struct Vector3 {
        private float x, y, z;

        public Vector3(float i) {
            this.x = i;
            this.y = i;
            this.z = i;
        }
        public Vector3(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float X {
            get { return this.x; }
            set { this.x=value; }
        }
        public float Y {
            get { return this.y; }
            set { this.y = value; }
        }
        public float Z {
            get { return this.z; }
            set { this.z = value; }
        }
        public double Length { get { return Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z); } }
        public double LenghtSquared { get { return this.Length * this.Length; } }
        /// <summary>
        /// Creates and returns a string representation of the object.
        /// </summary>
        public override string ToString() {
            return String.Format("<{0},{1},{2}>", this.x, this.y, this.z);
        }

        public static Vector3 operator +(Vector3 u, Vector3 v) {
            return new Vector3(u.x + v.x, u.y + v.y, u.z + v.z);
        }
        public static Vector3 operator -(Vector3 u, Vector3 v) {
            v.Negate();
            return u + v;
        }
        public static Vector3 operator *(Vector3 v, float x) {
            return new Vector3(v.x * x, v.y * x, v.z * x);
        }
        public static float operator *(Vector3 v, Vector3 u) {
            return (v.x * u.x) + (v.y * u.Y) + (v.z * u.z);
        }
        public static Vector3 operator /(Vector3 v, float x) {
            return new Vector3(v.x / x, v.y / x, v.z / x);
        }

        /// <summary>
        /// Get the angle between the two given vectors.
        /// </summary>
        /// <param name="v">First vector</param>
        /// <param name="u">Second vector</param>
        public static double AngleBetween(Vector3 v, Vector3 u) {
            return Math.Acos((v * u) / (v.Length * u.Length));
        }
        /// <summary>
        /// Reverses the direction of the vector while keeping the magnitude the same.
        /// </summary>
        public void Negate() { this *= -1; }
        /// <summary>
        /// Turns the calling vector into a unit vector with the same angle/direction.
        /// </summary>
        public void Normalize() { this = this / (float)this.Length; }
        /// <summary>
        /// Takes a string and returns a vector from that string.
        /// </summary>
        /// <param name="s">The string to create the vector from.</param>
        public static Vector3 Parse(string s) {
            string[] numbers = s.Split(',');
            try {
                return new Vector3(float.Parse(numbers[0]), float.Parse(numbers[1]), float.Parse(numbers[2]));
            } catch (Exception e) {
                Console.WriteLine(e);
                return new Vector3();
            }
        }
    }
}
