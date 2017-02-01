﻿/* Tetris, By Joshua Ohm 2015
 * 
 * Notes: My project differs from Schimpf's in the following ways.
 * 
 *        - My grid is 10 wide x 22 tall, with the top 2 rows being invisible.
 *        - I start at a 750 tick rate instead of 500.
 *        - No home cheat code.
 *        - My controls are different (see About->Controls).
 *        
 * Known Issues: 
 * 
 *        - Moving a tetrimino horizontally into another locks it into place.
 *          I would prefer it keep descending, but ran out of time to figure this out.
 *        - Line blocks sometimes collide incorrectly, usually at the top of the screen right before you
 *          lose the game. I ran out of time to figure that out as well.
 */
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Tetris
{
    class SquareBlock : Tetrimino
    {
        public SquareBlock(System.Windows.Controls.Canvas gameCanvas, GameArray gameArray)
        {
            this.Type = "Square";
            this.CanMove = true;
            this.GameArray = gameArray;
            this.GameCanvas = gameCanvas;

            this.XCoord = 60;
            this.YCoord = 20;
            this.Orientation = 0;
        }

        public override int[] GenerateXArray(int x, int orientation)
        {
            return new int[] {x, x + 20, x, x + 20};
        }

        public override int[] GenerateYArray(int y, int orientation)
        {
            return new int[] {y, y, y + 20, y + 20};
        }
        public override void Draw()
        {
            int x = this.XCoord;
            int y = this.YCoord;

            
                if (this.CanMove == true)
                {

                    //then draw the shape
                    DrawBlock(x, y);
                    DrawBlock(x + 20, y);
                    DrawBlock(x, y + 20);
                    DrawBlock(x + 20, y + 20);
                }
                else
                {
                    PlaceBlock(x, y);
                    PlaceBlock(x + 20, y);
                    PlaceBlock(x, y + 20);
                    PlaceBlock(x + 20, y + 20);
                }
            

        }

        public override void Clear()
        {
            int x = this.XCoord;
            int y = this.YCoord;

            UnDraw();
            this.GameArray.ClearCurrent();
        }

        public override void DrawBlock(int x, int y)
        {
            Rectangle rect = new Rectangle();
            SolidColorBrush fillBrush = new SolidColorBrush();
            SolidColorBrush strokeBrush = new SolidColorBrush();
            fillBrush.Color = Color.FromArgb(255, 240, 230, 20);
            strokeBrush.Color = Color.FromArgb(255, 1, 1, 0);
            rect.Height = 20;
            rect.Width = 20;
            rect.StrokeThickness = 1;
            rect.Stroke = strokeBrush;
            rect.Fill = fillBrush;

            rect.Uid = "Current " + x + " " + y;
            this.GameArray.AddBlock(rect, x, y);
            //The first 2 y coordinates are invisible.

            if (y > 20)
            {

                y -= 40;
                this.GameCanvas.Children.Add(rect);
                Canvas.SetLeft(rect, x);
                Canvas.SetTop(rect, y);
            }
        }

        public override void PlaceBlock(int x, int y)
        {
            Rectangle rect = new Rectangle();
            SolidColorBrush fillBrush = new SolidColorBrush();
            SolidColorBrush strokeBrush = new SolidColorBrush();
            fillBrush.Color = Color.FromArgb(255, 180, 170, 20);
            strokeBrush.Color = Color.FromArgb(255, 1, 1, 0);
            rect.Height = 20;
            rect.Width = 20;
            rect.StrokeThickness = 1;
            rect.Stroke = strokeBrush;
            rect.Fill = fillBrush;

            rect.Uid = "Placed " + x + " " + y;
            this.GameArray.AddBlock(rect, x, y);

            if (y > 20)
            {
                //The first 2 y coordinates are invisible.

                y -= 40;
                this.GameCanvas.Children.Add(rect);
                Canvas.SetLeft(rect, x);
                Canvas.SetTop(rect, y);
            }

            this.GameArray.CheckRowsForTetris();

        }
    }
}
