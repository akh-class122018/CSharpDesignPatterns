using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace CSharpDesignPatterns
{
    public abstract class AbstractWheel : IWheel
    {
        private int _size;
        private bool _isWide;
        private Spokes _spokes;
        private Bearings _bearings;

        public int Size
        {
            get { return _size; }
        }

        public bool IsWide
        {
            get { return _isWide; }
        }

        public AbstractWheel(int size, bool isWide)
        {
            this._size = size;
            this._isWide = isWide;
            _spokes = new Spokes();
            _bearings = new Bearings();
        }

        public override string ToString()
        {
            return this.GetType().Name + " With a wheel size of " + _size + " inches";
        }

        public void AcceptVisitor(IWheelVisitor visitor)
        {
            _spokes.AcceptVisitor(visitor);
            _bearings.AcceptVisitor(visitor);
            visitor.Visit(this);
        }
    }
}
