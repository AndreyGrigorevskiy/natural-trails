using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    class Graph
    {
        public class point
        {            
            public Point Position { get; set; }

            public int PathLengthFromStart { get; set; }

            public point CameFrom { get; set;}
            
            public int HeuristicEstimatePathLength { get; set; }

            public int EstimateFullPathLength
            {
                get
                {
                    return this.PathLengthFromStart + this.HeuristicEstimatePathLength;
                }
            }
        }

        private char[,] graphArray = new char[100,100];
        private int[,] graphArrayInt = new int[100, 100];

        private Bitmap myBitmap;

        public Graph(Bitmap bitmap)
        {
            myBitmap = bitmap;

            for(int i = 2, gI = 0; i <bitmap.Width; i+=(bitmap.Width/99), gI++)
            {
                for(int j = 2, gJ = 0; j<bitmap.Height; j+=(bitmap.Height/99), gJ++)
                {
                    if((bitmap.GetPixel(i,j)==Color.Brown)|| (bitmap.GetPixel(i, j) == Color.FromKnownColor(KnownColor.ActiveCaptionText)))
                    {
                        graphArray[gI, gJ] = '#';
                        continue;
                    }

                    if(bitmap.GetPixel(i,j)==Color.AliceBlue)
                    {
                        graphArray[gI, gJ] = 'A';
                        continue;
                    }

                    if ((bitmap.GetPixel(i, j) == Color.FromKnownColor(KnownColor.ControlDark))|| (bitmap.GetPixel(i, j) == Color.Teal))
                    {
                        graphArray[gI, gJ] = '.';
                        continue;
                    }

                    if((bitmap.GetPixel(i, j) == Color.FromKnownColor(KnownColor.ControlDark)) || (bitmap.GetPixel(i, j) == Color.White))
                    {
                        graphArray[gI, gJ] = '-';
                        continue;
                    }
                }
            }
        } 

        public void shortiesWay()
        {

            List<point> points = new List<point>();
            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    if(graphArray[i,j] =='A')
                    {
                        point p = new point();
                        Point point = new Point(j,i);
                        p.Position = point;
                        points.Add(p);
                    }
                }
            }


            List<List<Point>> myPath = new List<List<Point>>();
            for (int i = 0; i<points.Count-1; i++)
            {
                myPath.Add(FindPath(charToInt(graphArray), points[i].Position, points[i + 1].Position));
            }

            for(int i = 0; i<myPath.Count; i++)
            {
                
                for(int j = 0; j<myPath[i].Count; j++)
                {
                    graphArray[myPath[i][j].X, myPath[i][j].Y] = '-';
                }
            }

            charArrayTobit();
        }

        private void charArrayTobit()
        {
            Color color = Color.Teal;
            Pen pen = new Pen(color);
            Graphics g = Graphics.FromImage(myBitmap);
            for (int i = 0; i<100; i++)
            {
                for(int j = 0; j<100; j++)
                {
                    switch (graphArray[i, j])
                    {
                        case '.':
                            color = Color.Brown; //Color.Teal;
                            break;
                        case '-':
                            color = Color.Brown;//Color.White;
                            break;
                        case 'A':
                            color = Color.Brown;//Color.AliceBlue;
                            break;
                        case '#':
                            color = Color.Brown;
                            break;
                    }
                    pen.Color = color;
                    g.FillRectangle(pen.Brush, (i * (myBitmap.Width / 99)), (j * (myBitmap.Height / 99)), (myBitmap.Width / 99), (myBitmap.Height / 99));

                }
            }
        }

        public Bitmap getBitmap()
        {
            return myBitmap;
        }


        private static int GetDistanceBetweenNeighbours()
        {
            return 1;
        }

        public static int GetHeuristicPathLength(Point from, Point to)
        {
            return Math.Abs(from.X - to.X) + Math.Abs(from.Y - to.Y );
        }

        private static List<Point> GetPathForNode(point pathNode)
        {
            var result = new List<Point>();
            var currentNode = pathNode;
            while (currentNode != null)
            {
                result.Add(currentNode.Position);
                currentNode = currentNode.CameFrom;
            }
            result.Reverse();
            return result;
        }

        private static Collection<point> GetNeighbours(point pathNode, Point goal, int[,] field)
        {
            var result = new Collection<point>();

            // Соседними точками являются соседние по стороне клетки.
            Point[] neighbourPoints = new Point[4];
            neighbourPoints[0] = new Point(pathNode.Position.X + 1, pathNode.Position.Y);
            neighbourPoints[1] = new Point(pathNode.Position.X - 1, pathNode.Position.Y);
            neighbourPoints[2] = new Point(pathNode.Position.X, pathNode.Position.Y + 1);
            neighbourPoints[3] = new Point(pathNode.Position.X, pathNode.Position.Y - 1);

            foreach (var point in neighbourPoints)
            {
                // Проверяем, что не вышли за границы карты.
                if (point.X < 0 || point.X >= field.GetLength(0))
                    continue;
                if (point.Y < 0 || point.Y >= field.GetLength(1))
                    continue;
                // Проверяем, что по клетке можно ходить.
                if ((field[point.X, point.Y] != 0) && (field[point.X, point.Y] != 1))
                    continue;
                // Заполняем данные для точки маршрута.
                var neighbourNode = new point()
                {
                    Position = point,
                    CameFrom = pathNode,
                    PathLengthFromStart = pathNode.PathLengthFromStart +
                    GetDistanceBetweenNeighbours(),
                    HeuristicEstimatePathLength = GetHeuristicPathLength(point, goal)
                };
                result.Add(neighbourNode);
            }
            return result;
        }


        public static List<Point> FindPath(int[,] field, Point start, Point goal)
        {
            // Co3дается 2 списка вершин — ожидающие рассмотрения и уже рассмотренные. В ожидающие добавляется точка старта, список рассмотренных пока пуст.
            var closedSet = new Collection<point>();
            var openSet = new Collection<point>();
            // ля каждой точки рассчитывается F = G + H. G — расстояние от старта до точки, H — примерное расстояние от точки до цели.
            point startNode = new point()
            {
                Position = start,
                CameFrom = null,
                PathLengthFromStart = 0,
                HeuristicEstimatePathLength = GetHeuristicPathLength(start, goal)
            };
            openSet.Add(startNode);
            while (openSet.Count > 0)
            {
                // Из списка точек на рассмотрение выбирается точка с наименьшим F. Обозначим ее X.
                var currentNode = openSet.OrderBy(node =>
                  node.EstimateFullPathLength).First();
                // Если X — цель, то мы нашли маршрут.
                if (currentNode.Position == goal)
                    return GetPathForNode(currentNode);
                // Переносим X из списка ожидающих рассмотрения в список уже рассмотренных.
                openSet.Remove(currentNode);
                closedSet.Add(currentNode);
                // Для каждой из точек, соседних для X (обозначим эту соседнюю точку Y), делаем следующее:
                foreach (var neighbourNode in GetNeighbours(currentNode, goal, field))
                {
                    // Если Y уже находится в рассмотренных — пропускаем ее.
                    if (closedSet.Count(node => node.Position == neighbourNode.Position) > 0)
                        continue;
                    var openNode = openSet.FirstOrDefault(node =>
                      node.Position == neighbourNode.Position);
                    // Если Y еще нет в списке на ожидание — добавляем ее туда, запомнив ссылку на X и рассчитав Y.G (это X.G + расстояние от X до Y) и Y.H.
                    if (openNode == null)
                        openSet.Add(neighbourNode);
                    else
                      if (openNode.PathLengthFromStart > neighbourNode.PathLengthFromStart)
                    {
                        // Если же Y в списке на рассмотрение — проверяем, если X.G + расстояние от X до Y < Y.G, значит мы пришли в точку Y более коротким путем, заменяем Y.G на X.G + расстояние от X до Y, а точку, из которой пришли в Y на X.
                        openNode.CameFrom = currentNode;
                        openNode.PathLengthFromStart = neighbourNode.PathLengthFromStart;
                    }
                }
            }
            // Если список точек на рассмотрение пуст, а до цели мы так и не дошли — значит маршрут не существует.
            return null;
        }

        int [,] charToInt(char[,] from)
        {
            int[,] to = new int[100, 100];
            for(int i  = 0; i<100; i++)
            {
                for(int j = 0; j<100; j++)
                {
                    switch(from[i,j])
                    {
                        case '.': to[i, j] = 0;
                            break;
                        case '#': to[i, j] = 1;
                            break;
                    }
                }
            }
            return to;
        }
    }
}
