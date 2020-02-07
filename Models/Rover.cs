using System;
using System.Drawing;

namespace MarsRover
{
    public class Rover
    {
      public Rover(Point point, Direction direction)
      {
          Point = point;
          Direction = direction;
      }

      public Point Point { get; set; }
      public Direction Direction { get; set; }
      public string CommandSet { get; set; }

      public string StartExplore() {
          foreach (var item in this.CommandSet.ToUpper())
          {
              if(Enum.IsDefined(typeof(Orientation),item.ToString())) {
                  if (item.ToString() == Orientation.L.ToString()) {
                      TurnLeft();
                  }
                  else {
                      TurnRight();
                  }
              }
              else if (item == 'M') {
                  Move();
              }
          }
          return $"{this.Point.X} {this.Point.Y} {this.Direction.ToString()}";
      }

      private void TurnLeft() {
        switch (this.Direction)
        {
                          case Direction.N:
                          this.Direction = Direction.W;
                          break;
                          case Direction.W:
                          this.Direction = Direction.S;
                          break;
                          case Direction.S:
                          this.Direction = Direction.E;
                          break;
                          case Direction.E:
                          this.Direction = Direction.N;
                          break;
        }
    }

      private void TurnRight() {
        switch (this.Direction)
                      {
                          case Direction.N:
                          this.Direction = Direction.E;
                          break;
                          case Direction.E:
                          this.Direction = Direction.S;
                          break;
                          case Direction.S:
                          this.Direction = Direction.W;
                          break;
                          case Direction.W:
                          this.Direction = Direction.N;
                          break;
                      }
      }

      private void Move() {
        switch (this.Direction)
                      {
                          case Direction.N:
                          this.Point = new Point(this.Point.X,this.Point.Y+1);
                          break;
                          case Direction.W:
                          this.Point = new Point(this.Point.X-1,this.Point.Y);
                          break;
                          case Direction.S:
                          this.Point = new Point(this.Point.X,this.Point.Y-1);
                          break;
                          case Direction.E:
                          this.Point = new Point(this.Point.X+1,this.Point.Y);
                          break;
                      }
        }
    }
}
