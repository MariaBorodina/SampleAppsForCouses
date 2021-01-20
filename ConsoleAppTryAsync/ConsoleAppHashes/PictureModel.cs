using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashes
{
    class PictureModel : IEquatable<PictureModel>
    {
        private string _name;
        private int _width;
        private int _height;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public Bitmap Bitmap { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as PictureModel);
        }

        public bool Equals(PictureModel other)
        {
            return other != null &&
                   _name == other._name &&
                   _width == other._width;
        }

        public override int GetHashCode()
        {
            int hashCode = -1622455617;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_name);
            hashCode = hashCode * -1521134295 + _width.GetHashCode();
           // hashCode = hashCode * -1521134295 + _height.GetHashCode();
            return hashCode;
        }
    }
}
