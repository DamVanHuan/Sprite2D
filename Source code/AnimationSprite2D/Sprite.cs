using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimationSprite2D
{
    public enum StateAction
    {
        Left, Right, Up, Down,
        Standing, Walking
    }

    class Sprite2D
    {
        //Vị trí ban đầu của player
        private int _x, _y;
        private int _dx, _dy;
        private int _width, _height;
        private int _zoom = 1;
        private StateAction _direction, _action;
        private int _maxCols = 4;
        private int _maxX, _maxY;

        public int MaxY
        {
            get { return _maxY; }
            set { _maxY = value; }
        }

        public int MaxX
        {
            get { return _maxX; }
            set { _maxX = value; }
        }

        public int MaxCols
        {
            get { return _maxCols; }
            set { _maxCols = value; }
        }

        public StateAction Action
        {
            get { return _action; }
            set { _action = value; }
        }

        public StateAction Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }

        public int Zoom
        {
            get { return _zoom; }
            set { _zoom = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Dy
        {
            get { return _dy; }
            set { _dy = value; }
        }

        public int Dx
        {
            get { return _dx; }
            set { _dx = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        
        //Index của từng frame trong tấm hình
        private int _indexColumn, _indexRow;

        public int IndexRow
        {
            get { return _indexRow; }
            set { _indexRow = value; }
        }

        public int IndexColumn
        {
            get { return _indexColumn; }
            set { _indexColumn = value; }
        }
        
        public void drawPlayer(BufferedGraphics buffer, Bitmap bm, int zoom)
        {
            Rectangle sizeSrcPlayer = new Rectangle(_indexColumn * _width, _indexRow * _height, _width, _height);
            Rectangle sizeDestPlayer = new Rectangle(_x, _y, _width * zoom, _height * zoom);

            buffer.Graphics.DrawImage(bm, sizeDestPlayer, sizeSrcPlayer, GraphicsUnit.Pixel);

            if (_dx > 0)
            {
                if (_maxX > _x + _dx)
                {
                    _x += _dx;
                }
                else _x = -_width * zoom;
            }
            else
            {
                if (_x + _dx > -_width * zoom)
                {
                    _x += _dx;
                }
                else _x = _maxX;
            }

            if (_dy > 0)
            {
                if (_maxY > _y + _dy)
                {
                    _y += _dy;
                }
                else _y = -_height * zoom;
            }
            else
            {
                if (_y + _dy > -_height * zoom)
                {
                    _y += _dy;
                }
                else _y = _maxY;
            }
        }

        public void movePlayer(BufferedGraphics buffer, Bitmap bm)
        {
            switch (_action)
            {
                case StateAction.Down:
                    _indexRow = 0;

                    if (_indexColumn >= 0 && _indexColumn < _maxCols - 1)
                        _indexColumn++;
                    else
                    {
                        _indexColumn = 0;
                        _dx = 0;
                        _dy = 10;
                        _direction = StateAction.Down;
                    }
                    break;

                case StateAction.Left:
                    _indexRow = 1;
                    if (_indexColumn >= 0 && _indexColumn < _maxCols - 1)
                        _indexColumn++;
                    else
                    {
                        _indexColumn = 0;
                        _dx = -10;
                        _dy = 0;
                        _direction = StateAction.Left;
                    }
                    break;

                case StateAction.Right:
                    _indexRow = 2;
                    if (_indexColumn >= 0 && _indexColumn < _maxCols - 1)
                        _indexColumn++;
                    else
                    {
                        _indexColumn = 0;
                        _dx = 10;
                        _dy = 0;
                        _direction = StateAction.Right;
                    }
                    break;

                case StateAction.Up:
                    _indexRow = 3;
                    if (_indexColumn >= 0 && _indexColumn < _maxCols - 1)
                        _indexColumn++;
                    else
                    {
                        _indexColumn = 0;
                        _dx = 0;
                        _dy = -10;
                        _direction = StateAction.Up;
                    }
                    break;

                case StateAction.Standing:
                    _dx = 0;
                    _dy = 0;
                    switch (_direction)
                    {
                        case StateAction.Down:
                            _indexColumn = 0;
                            _indexRow = 0;
                            break;

                        case StateAction.Left:
                            _indexColumn = 0;
                            _indexRow = 1;
                            break;

                        case StateAction.Right:
                            _indexColumn = 0;
                            _indexRow = 2;
                            break;

                        case StateAction.Up:
                            _indexColumn = 0;
                            _indexRow = 3;
                            break;

                        default:
                            break;
                    }
                    break;//case StateAction.Standing
            }//switch (Action)

            drawPlayer(buffer, bm, _zoom);
        }

    }
}
