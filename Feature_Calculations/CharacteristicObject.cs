using System.Drawing;

namespace Feature_Calculations
{
    /// <summary>
    /// реализовать модели данных для данного класса
    /// </summary>
    public class CharacteristicObject
    {
        /// <summary>
        /// Определение ключевых точек контура иследуемого объекта
        /// </summary>
        /// <param name="list"> Массив точек контура иследуемого объекта</param>
        /// <returns> массив колличеста точек</returns>
        public static int[] SearchForConnectedPoints(Point[] list)
        {
            int dlN1 = 0;
            int dlN2 = 0;
            int dlN3 = 0;
            int dlN4 = 0;
            int dlN5 = 0;
            int dlN6 = 0;
            int dlN7 = 0;
            int dlN8 = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (i == list.Length - 1)
                {
                    if (list[i].X < list[0].X && list[i].Y == list[0].Y)
                    {
                        dlN1++;
                    }
                    if (list[i].X < list[0].X && list[i].Y < list[0].Y)
                    {
                        dlN2++;
                    }
                    if (list[i].X == list[0].X && list[i].Y < list[0].Y)
                    {
                        dlN3++;
                    }
                    if (list[i].X > list[0].X && list[i].Y < list[0].Y)
                    {
                        dlN4++;
                    }
                    if (list[i].X > list[0].X && list[i].Y == list[0].Y)
                    {
                        dlN5++;
                    }
                    if (list[i].X > list[0].X && list[i].Y > list[0].Y)
                    {
                        dlN6++;
                    }
                    if (list[i].X == list[0].X && list[i].Y > list[0].Y)
                    {
                        dlN7++;
                    }
                    if (list[i].X < list[0].X && list[i].Y > list[0].Y)
                    {
                        dlN8++;
                    }
                }
                else
                {
                    if (list[i].X < list[i + 1].X && list[i].Y == list[i + 1].Y)
                    {
                        dlN1++;
                    }
                    if (list[i].X < list[i + 1].X && list[i].Y < list[i + 1].Y)
                    {
                        dlN2++;
                    }
                    if (list[i].X == list[i + 1].X && list[i].Y < list[i + 1].Y)
                    {
                        dlN3++;
                    }
                    if (list[i].X > list[i + 1].X && list[i].Y < list[i + 1].Y)
                    {
                        dlN4++;
                    }
                    if (list[i].X > list[i + 1].X && list[i].Y == list[i + 1].Y)
                    {
                        dlN5++;
                    }
                    if (list[i].X > list[i + 1].X && list[i].Y > list[i + 1].Y)
                    {
                        dlN6++;
                    }
                    if (list[i].X == list[i + 1].X && list[i].Y > list[i + 1].Y)
                    {
                        dlN7++;
                    }
                    if (list[i].X < list[i + 1].X && list[i].Y > list[i + 1].Y)
                    {
                        dlN8++;
                    }
                }
            }
            int[] dln1_dln8 = new int[8];
            dln1_dln8[0] = dlN1;
            dln1_dln8[1] = dlN2;
            dln1_dln8[2] = dlN3;
            dln1_dln8[3] = dlN4;
            dln1_dln8[4] = dlN5;
            dln1_dln8[5] = dlN6;
            dln1_dln8[6] = dlN7;
            dln1_dln8[7] = dlN8;
            return dln1_dln8;
        }
        /// <summary>
        /// Расчет кривизны точек контура
        /// </summary>
        /// <param name="list">Массив точек контура иследуемого объекта<</param>
        /// <returns></returns>
        public static int[] Curvature_calculation_points_counter(Point[] list)
        {
            int dlvp90 = 0;
            int dlvg90 = 0;
            int dlvp135 = 0;
            int dlvg135 = 0;
            int cr0 = 0;
            for (int z = 0; z < list.Length - 1; z++)
            {

                if (z == 0)
                {
                    #region засчет кривизны в 0 градусов
                    /// Маска G2
                    if (list[z].X < list[z + 1].X && list[z].Y == list[z + 1].Y && list[z].X > list[list.Length - 1].X && list[z].Y == list[list.Length - 1].Y)
                    {
                        cr0++;//0
                    }
                    if (list[z].X < list[list.Length - 1].X && list[z].Y == list[list.Length - 1].Y && list[z].X > list[z + 1].X && list[z].Y == list[z + 1].Y)
                    {
                        cr0++;//0
                    }
                    /// Маска G1
                    if (list[z].X == list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X == list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y)
                    {
                        cr0++;//0
                    }
                    if (list[z].X == list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y && list[z].X == list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        cr0++;//0
                    }
                    /// Маска G3
                    if (list[z].X < list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X > list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y)
                    {
                        cr0++;//0
                    }
                    if (list[z].X < list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y && list[z].X > list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        cr0++;//0
                    }
                    /// Маска G4
                    if (list[z].X > list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X < list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y)
                    {
                        cr0++;//0
                    }
                    if (list[z].X > list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y && list[z].X < list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        cr0++;//0
                    }
                    #endregion
                    #region Расчет кривизны 90 градусов
                    /// Маска G5
                    if (list[z].X < list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X > list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y && list[z].X > list[z + 1].X && list[z].Y < list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G6
                    if (list[z].X < list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X < list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y && list[z].X < list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G7
                    if (list[z].X < list[z + 1].X && list[z].Y > list[z + 1].Y && list[z].X > list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y && list[z].X > list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G8
                    if (list[z].X > list[z + 1].X && list[z].Y > list[z + 1].Y && list[z].X > list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X > list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y && list[z].X > list[z + 1].X && list[z].Y < list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    #endregion
                    #region РАсчет кривизны 135 гразусов
                    /// Маска G9
                    if (list[z].X == list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X < list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X == list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y && list[z].X < list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G10
                    if (list[z].X < list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X == list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y && list[z].X == list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G11
                    if (list[z].X < list[z + 1].X && list[z].Y == list[z + 1].Y && list[z].X > list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[list.Length - 1].X && list[z].Y == list[list.Length - 1].Y && list[z].X > list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G12
                    if (list[z].X > list[z + 1].X && list[z].Y == list[z + 1].Y && list[z].X < list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X > list[list.Length - 1].X && list[z].Y == list[list.Length - 1].Y && list[z].X < list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G13
                    if (list[z].X > list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X == list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X > list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y && list[z].X == list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G14
                    if (list[z].X == list[z + 1].X && list[z].Y < list[z + 1].Y && (list[z].X > list[list.Length - 1].X && list[z].Y > list[list.Length - 1].Y))
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X == list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y && (list[z].X > list[z + 1].X && list[z].Y > list[z + 1].Y))
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G15
                    if (list[z].X < list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X > list[list.Length - 1].X && list[z].Y == list[list.Length - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y && list[z].X > list[z + 1].X && list[z].Y == list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G16
                    if (list[z].X < list[z + 1].X && list[z].Y == list[z + 1].Y && list[z].X > list[list.Length - 1].X && list[z].Y < list[list.Length - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[list.Length - 1].X && list[z].Y == list[list.Length - 1].Y && list[z].X > list[z + 1].X && list[z].Y < list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                }
                #endregion
                else if (z == list.Length - 1)
                {
                    #region Расчет кривизны в 0 градусов
                    /// Маска G2
                    if (list[z].X < list[0].X && list[z].Y == list[0].Y && list[z].X > list[z - 1].X && list[z].Y == list[z - 1].Y)
                    {
                        cr0++;
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y == list[z - 1].Y && list[z].X > list[0].X && list[z].Y == list[0].Y)
                    {
                        cr0++;
                    }
                    /// Маска G1
                    if (list[z].X == list[0].X && list[z].Y < list[0].Y && list[z].X == list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        cr0++;
                    }
                    if (list[z].X == list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X == list[0].X && list[z].Y > list[0].Y)
                    {
                        cr0++;
                    }
                    /// Маска G3
                    if (list[z].X < list[0].X && list[z].Y < list[0].Y && list[z].X > list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        cr0++;
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X > list[0].X && list[z].Y > list[0].Y)
                    {
                        cr0++;
                    }
                    /// Маска G4
                    if (list[z].X > list[0].X && list[z].Y < list[0].Y && list[z].X < list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        cr0++;
                    }
                    if (list[z].X > list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X < list[0].X && list[z].Y > list[0].Y)
                    {
                        cr0++;
                    }
                    #endregion
                    #region Расчет кривизны 90 градусов
                    /// Маска G5
                    if (list[z].X < list[0].X && list[z].Y < list[0].Y && list[z].X > list[z - 1].X && list[z].Y < list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X > list[0].X && list[z].Y < list[0].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G6
                    if (list[z].X < list[0].X && list[z].Y < list[0].Y && list[z].X < list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X < list[0].X && list[z].Y > list[0].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G7
                    if (list[z].X < list[0].X && list[z].Y > list[0].Y && list[z].X > list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y > list[z - 1].Y && list[z].X > list[0].X && list[z].Y > list[0].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G8
                    if (list[z].X > list[0].X && list[z].Y > list[0].Y && list[z].X > list[z - 1].X && list[z].Y < list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X > list[z - 1].X && list[z].Y > list[z - 1].Y && list[z].X > list[0].X && list[z].Y < list[0].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    #endregion
                    #region Расчет кривизны 135 градусов
                    /// Маска G9
                    if (list[z].X == list[0].X && list[z].Y < list[0].Y && list[z].X < list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X == list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X < list[0].X && list[z].Y > list[0].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G10
                    if (list[z].X < list[0].X && list[z].Y < list[0].Y && list[z].X == list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X == list[0].X && list[z].Y > list[0].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G11
                    if (list[z].X < list[0].X && list[z].Y == list[0].Y && list[z].X > list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;//РѕС‚СЂРёС†Р°С‚РµР»СЊРЅРѕ
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y == list[z - 1].Y && list[z].X > list[0].X && list[z].Y > list[0].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G12
                    if (list[z].X > list[0].X && list[z].Y == list[0].Y && list[z].X < list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X > list[z - 1].X && list[z].Y == list[z - 1].Y && list[z].X < list[0].X && list[z].Y > list[0].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G13
                    if (list[z].X > list[0].X && list[z].Y < list[0].Y && list[z].X == list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X > list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X == list[0].X && list[z].Y > list[0].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G14
                    if (list[z].X == list[0].X && list[z].Y < list[0].Y && (list[z].X > list[z - 1].X && list[z].Y > list[z - 1].Y))
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X == list[z - 1].X && list[z].Y < list[z - 1].Y && (list[z].X > list[0].X && list[z].Y > list[0].Y))
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G15
                    if (list[z].X < list[0].X && list[z].Y < list[0].Y && list[z].X > list[z - 1].X && list[z].Y == list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X > list[0].X && list[z].Y == list[0].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G16
                    if (list[z].X < list[0].X && list[z].Y == list[0].Y && list[z].X > list[z - 1].X && list[z].Y < list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y == list[z - 1].Y && list[z].X > list[0].X && list[z].Y < list[0].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    #endregion
                }
                else
                {
                    #region  Расчет кривизны в 0 градусов
                    /// Маска G2
                    if (list[z].X < list[z + 1].X && list[z].Y == list[z + 1].Y && list[z].X > list[z - 1].X && list[z].Y == list[z - 1].Y)
                    {
                        cr0++;
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y == list[z - 1].Y && list[z].X > list[z + 1].X && list[z].Y == list[z + 1].Y)
                    {
                        cr0++;
                    }
                    /// Маска G1
                    if (list[z].X == list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X == list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        cr0++;
                    }
                    if (list[z].X == list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X == list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        cr0++;
                    }
                    /// Маска G3
                    if (list[z].X < list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X > list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        cr0++;
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X > list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        cr0++;
                    }
                    /// Маска G4
                    if (list[z].X > list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X < list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        cr0++;
                    }
                    if (list[z].X > list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X < list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        cr0++;
                    }
                    #endregion
                    #region  Расчет кривизны 90 градусов
                    /// Маска G5
                    if (list[z].X < list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X > list[z - 1].X && list[z].Y < list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X > list[z + 1].X && list[z].Y < list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G6
                    if (list[z].X < list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X < list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X < list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G7
                    if (list[z].X < list[z + 1].X && list[z].Y > list[z + 1].Y && list[z].X > list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y > list[z - 1].Y && list[z].X > list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G8
                    if (list[z].X > list[z + 1].X && list[z].Y > list[z + 1].Y && list[z].X > list[z - 1].X && list[z].Y < list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X > list[z - 1].X && list[z].Y > list[z - 1].Y && list[z].X > list[z + 1].X && list[z].Y < list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp90++;
                                    break;
                                }
                                else
                                {
                                    dlvg90++;
                                    break;
                                }
                            }
                        }
                    }
                    #endregion
                    #region  Расчет кривизны 135 градусов
                    /// Маска G9
                    if (list[z].X == list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X < list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X == list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X < list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G10
                    if (list[z].X < list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X == list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X == list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G11
                    if (list[z].X < list[z + 1].X && list[z].Y == list[z + 1].Y && list[z].X > list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y == list[z - 1].Y && list[z].X > list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 2 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G12
                    if (list[z].X > list[z + 1].X && list[z].Y == list[z + 1].Y && list[z].X < list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X > list[z - 1].X && list[z].Y == list[z - 1].Y && list[z].X < list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 2 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 2 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G13
                    if (list[z].X > list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X == list[z - 1].X && list[z].Y > list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X > list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X == list[z + 1].X && list[z].Y > list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G14
                    if (list[z].X == list[z + 1].X && list[z].Y < list[z + 1].Y && (list[z].X > list[z - 1].X && list[z].Y > list[z - 1].Y))
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X == list[z - 1].X && list[z].Y < list[z - 1].Y && (list[z].X > list[z + 1].X && list[z].Y > list[z + 1].Y))
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].Y == list[z].Y + 1 && list[r].X != list[z].X + 1 || list[r].Y == list[z].Y - 1 && list[r].X != list[z].X - 1 || list[r].Y == list[z].Y && list[r].X != list[z].X)
                            {
                                if (list[r].X > list[z].X + 1 || list[r].X > list[z].X - 1 || list[r].X > list[z].X)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G15
                    if (list[z].X < list[z + 1].X && list[z].Y < list[z + 1].Y && list[z].X > list[z - 1].X && list[z].Y == list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y < list[z - 1].Y && list[z].X > list[z + 1].X && list[z].Y == list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    /// Маска G16
                    if (list[z].X < list[z + 1].X && list[z].Y == list[z + 1].Y && list[z].X > list[z - 1].X && list[z].Y < list[z - 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    if (list[z].X < list[z - 1].X && list[z].Y == list[z - 1].Y && list[z].X > list[z + 1].X && list[z].Y < list[z + 1].Y)
                    {
                        for (int r = 0; r < list.Length; r++)
                        {
                            if (list[r].X == list[z].X + 1 && list[r].Y != list[z].Y + 1 || list[r].X == list[z].X - 1 && list[r].Y != list[z].Y - 1 || list[r].X == list[z].X && list[r].Y != list[z].Y)
                            {
                                if (list[r].Y > list[z].Y + 1 || list[r].Y > list[z].Y - 1 || list[r].Y > list[z].Y)
                                {
                                    dlvp135++;
                                    break;
                                }
                                else
                                {
                                    dlvg135++;
                                    break;
                                }
                            }
                        }
                    }
                    #endregion
                }
            }
            int[] signs = new int[5];
            signs[0] = dlvp90;
            signs[1] = dlvg90;
            signs[2] = dlvp135;
            signs[3] = dlvg135;
            signs[4] = cr0;
            return signs;
        }
    }
}
