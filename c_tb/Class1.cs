/*using System;

namespace TwoDimensionalLocalizationAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // 随机产生输入数据
            Random rand = new Random();
            double x1 = rand.NextDouble() * 100;
            double y1 = rand.NextDouble() * 100;
            double r1 = rand.NextDouble() * 50;
            double x2 = rand.NextDouble() * 100;
            double y2 = rand.NextDouble() * 100;
            double r2 = rand.NextDouble() * 50;
            double x3 = rand.NextDouble() * 100;
            double y3 = rand.NextDouble() * 100;
            double r3 = rand.NextDouble() * 50;

            // 调用二维定位算法函数
            double[] result = Get_three_BS_Out_XY(x1, y1, r1, x2, y2, r2, x3, y3, r3);

            // 输出结果
            Console.WriteLine("Input:");
            Console.WriteLine($"x1: {x1}, y1: {y1}, r1: {r1}");
            Console.WriteLine($"x2: {x2}, y2: {y2}, r2: {r2}");
            Console.WriteLine($"x3: {x3}, y3: {y3}, r3: {r3}");
            Console.WriteLine("Output:");
            Console.WriteLine($"Point_x: {result[0]}, Point_y: {result[1]}");
        }

   }     
}
*/
/*using System;

namespace TwoDimensionalLocalizationAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                // 随机产生输入数据，转换为整数
                int x1 = rand.Next(10100); // 生成 0 到 100 之间的整数
                int y1 = rand.Next(10100);
                int r1 = rand.Next(5100); // 生成 0 到 50 之间的整数
                int x2 = rand.Next(10100);
                int y2 = rand.Next(10100);
                int r2 = rand.Next(5100);
                int x3 = rand.Next(10100);
                int y3 = rand.Next(10100);
                int r3 = rand.Next(5100);

                // 调用二维定位算法函数
                double[] result = Get_three_BS_Out_XY(x1, y1, r1, x2, y2, r2, x3, y3, r3);

                // 输出结果
                Console.WriteLine($"Round {i + 1}:");
                Console.WriteLine($"Input: x1: {x1}, y1: {y1}, r1: {r1}");
                Console.WriteLine($"       x2: {x2}, y2: {y2}, r2: {r2}");
                Console.WriteLine($"       x3: {x3}, y3: {y3}, r3: {r3}");
                Console.WriteLine($"Output: Point_x: {result[0]}, Point_y: {result[1]}");
                Console.WriteLine();
            }
        }

       
}
*/
/*using System;
using System.IO;

namespace TwoDimensionalLocalizationAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // 指定输出文件路径
            string filePath = "output.txt";

            // 打开输出文件，如果文件不存在则创建，如果文件存在则追加内容
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                Random rand = new Random();
                for (int i = 0; i < 20; i++)
                {
                    // 随机产生输入数据，转换为整数
                    int x1 = rand.Next(101); // 生成 0 到 100 之间的整数
                    int y1 = rand.Next(101);
                    int r1 = rand.Next(51); // 生成 0 到 50 之间的整数
                    int x2 = rand.Next(101);
                    int y2 = rand.Next(101);
                    int r2 = rand.Next(51);
                    int x3 = rand.Next(101);
                    int y3 = rand.Next(101);
                    int r3 = rand.Next(51);

                    // 调用二维定位算法函数
                    double[] result = Get_three_BS_Out_XY(x1, y1, r1, x2, y2, r2, x3, y3, r3);

                    // 写入输出结果到文件
                    writer.WriteLine($"Round {i + 1}:");
                    writer.WriteLine($"Input: x1: {x1}, y1: {y1}, r1: {r1}");
                    writer.WriteLine($"       x2: {x2}, y2: {y2}, r2: {r2}");
                    writer.WriteLine($"       x3: {x3}, y3: {y3}, r3: {r3}");
                    writer.WriteLine($"Output: Point_x: {result[0]}, Point_y: {result[1]}");
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Output has been written to file: " + filePath);
            Console.ReadKey(); // 保持控制台窗口打开
        }

       
    }
}
*/
/*
using System;
using System.IO;

namespace TwoDimensionalLocalizationAlgorithm
{
    class Program
    {
        // 定义全局变量
        static double[] x_last = new double[2];
        static double[] p_last = new double[2];

        static void Main(string[] args)
        {
            // 指定输出文件路径
            string filePath = "output5.txt";

            // 打开输出文件，如果文件不存在则创建，如果文件存在则追加内容
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                Random rand = new Random();
                int x1 = rand.Next(101) * 10; // 生成 0 到 100 之间的整数
                int y1 = rand.Next(101) * 10;
                int r1 = rand.Next(51) * 10; // 生成 0 到 50 之间的整数
                int x2 = rand.Next(101) * 10;
                int y2 = rand.Next(101) * 10;
                int r2 = rand.Next(51) * 10;
                int x3 = rand.Next(101) * 10;
                int y3 = rand.Next(101) * 10;
                int r3 = rand.Next(51) * 10;
                for (int i = 0; i < 20; i++)
                {
                    // 随机产生输入数据，转换为整数
                    x1 += rand.Next(11)*10; // 生成 0 到 100 之间的整数
                     y1 += rand.Next(11)*10;
                     r1 += rand.Next(11)*10; // 生成 0 到 50 之间的整数
                     x2 += rand.Next(11)*10;
                     y2 += rand.Next(11)*10;
                     r2 += rand.Next(11)*10;
                     x3 += rand.Next(11)*10;
                     y3 += rand.Next(11)*10;
                     r3 += rand.Next(11)*10;

                    // 调用二维定位算法函数
                    double[] result = Get_three_BS_Out_XY(x1, y1, r1, x2, y2, r2, x3, y3, r3);

                    // 调用卡尔曼滤波函数，对结果进行滤波
                    double filteredX = KalmanFilter(result[0], 3, 10, 0); // 使用第一个传感器的数据进行滤波
                    double filteredY = KalmanFilter(result[1], 3, 10, 1); // 使用第二个传感器的数据进行滤波

                    // 写入输出结果到文件
                    writer.WriteLine($"Round {i + 1}:");
                    writer.WriteLine($"Input: x1: {x1}, y1: {y1}, r1: {r1}");
                    writer.WriteLine($"       x2: {x2}, y2: {y2}, r2: {r2}");
                    writer.WriteLine($"       x3: {x3}, y3: {y3}, r3: {r3}");
                    writer.WriteLine($"Output: Point_x: {result[0]}, Point_y: {result[1]}");
                    writer.WriteLine($"Filtered Output: Point_x: {filteredX}, Point_y: {filteredY}");
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Output has been written to file: " + filePath);
            Console.ReadKey(); // 保持控制台窗口打开
        }

        
    }
}//乘-1的random次方
*/
//最终版三基站
using System;
using System.IO;

namespace TwoDimensionalLocalizationAlgorithm
{
    class Program
    {
        // 定义全局变量
        static double[] x_last = new double[2];
        static double[] p_last = new double[2];

        static void Main(string[] args)
        {
            // 指定输出文件路径
            string filePath = "output17.txt";

            // 打开输出文件，如果文件不存在则创建，如果文件存在则追加内容
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                Random rand = new Random();
                int x1 = 0; // 生成 0 到 100 之间的整数
                int y1 = 0;
                int r1 = 1414; // 生成 0 到 50 之间的整数
                int x2 = 2000;
                int y2 = 0;
                int r2 = 1414;
                int x3 = 0;
                int y3 = 2000;
                int r3 = 1414;
                int y4 = 2000;
                int x4 = 2000;
                int r4 = 1414;
                for (int i = 0; i < 20; i++)
                {
                    // 随机产生输入数据，转换为整数
                   // x1 += rand.Next(11) ; // 生成 0 到 100 之间的整数
                   // y1 += rand.Next(11) ;
                    r1 += rand.Next(21) ; // 生成 0 到 50 之间的整数
                   // x2 += rand.Next(11) ;
                    //y2 += rand.Next(11) ;
                    r3 += rand.Next(21) ;
                    //  x3 += rand.Next(11) ;
                    //y3 += rand.Next(11) ;
                    // r3 += rand.Next(21) ;
                    FindPointC(r1, r2, x3, y3,x4,y4 ,ref r3, ref r4);

                    // 调用二维定位算法函数
                    double[] result1 = Get_three_BS_Out_XY(x1, y1, r1, x2, y2, r2, x3, y3, r3);
                    double[] result2 = Get_three_BS_Out_XY(x1, y1, r1, x2, y2, r2, x4, y4, r4);
                    double[] result3 = Get_three_BS_Out_XY(x1, y1, r1, x3, y3, r3, x4, y4, r4);
                    double[] result4 = Get_three_BS_Out_XY(x2, y2, r2, x3, y3, r3, x4, y4, r4);
                    double fa = (result1[0] + result2[0] + result3[0] + result4[0]) / 4;
                    double sa = (result1[1] + result2[1] + result3[1] + result4[1]) / 4;
                    double[] result = new double[2];
                    result[0] = fa;
                    result[1] = sa;
                    // 调用卡尔曼滤波函数，对结果进行滤波
                    double filteredX = KalmanFilter(result[0], 3, 10, 0); // 使用第一个传感器的数据进行滤波
                    double filteredY = KalmanFilter(result[1], 3, 10, 1); // 使用第二个传感器的数据进行滤波

                    // 写入输出结果到文件
                    writer.WriteLine($"Round {i + 1}:");
                    writer.WriteLine($"Input: x1: {x1}, y1: {y1}, r1: {r1}");
                    writer.WriteLine($"       x2: {x2}, y2: {y2}, r2: {r2}");
                    writer.WriteLine($"       x3: {x3}, y3: {y3}, r3: {r3}");
                    writer.WriteLine($"       x4: {x4}, y4: {y4}, r4: {r4}");
                    writer.WriteLine($"Output: Point_x: {result[0]}, Point_y: {result[1]}");
                    writer.WriteLine($"Filtered Output: Point_x: {filteredX}, Point_y: {filteredY}");
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Output has been written to file: " + filePath);
            Console.ReadKey(); // 保持控制台窗口打开
        }
        static double[] Get_three_BS_Out_XY(int x1, int y1, int r1,
                                    int x2, int y2, int r2,
                                    int x3, int y3, int r3)
        {
            double[,] A = new double[2, 2];
            double[,] B = new double[2, 2];
            double[] C = new double[2];
            double[] Point_xy = new double[2];
            A[0, 0] = 2 * (x1 - x2); A[0, 1] = 2 * (y1 - y2);
            A[1, 0] = 2 * (x1 - x3); A[1, 1] = 2 * (y1 - y3);

            double det = 0;
            det = A[0, 0] * A[1, 1] - A[1, 0] * A[0, 1];

            if (det != 0)
            {
                B[0, 0] = A[1, 1] / det;
                B[0, 1] = -A[0, 1] / det;
                B[1, 0] = -A[1, 0] / det;
                B[1, 1] = A[0, 0] / det;

                C[0] = r2 * r2 - r1 * r1 - x2 * x2 + x1 * x1 - y2 * y2 + y1 * y1;
                C[1] = r3 * r3 - r1 * r1 - x3 * x3 + x1 * x1 - y3 * y3 + y1 * y1;

                Point_xy[0] = B[0, 0] * C[0] + B[0, 1] * C[1];
                Point_xy[1] = B[1, 0] * C[0] + B[1, 1] * C[1];

                return Point_xy;
            }
            else
            {
                Point_xy[0] = 0;
                Point_xy[1] = 0;

                return Point_xy;
            }
        }
        static double KalmanFilter(double ResrcData, double ProcessNoise_Q, double MeasureNoise_R, int db)
        {
            double R = MeasureNoise_R;
            double Q = ProcessNoise_Q;
            double x_mid = x_last[db];
            double x_now;
            double p_mid;
            double p_now;
            double kg;

            x_mid = x_last[db];                       // x_last=x(k-1|k-1),x_mid=x(k|k-1)
            p_mid = p_last[db] + Q;                     // p_mid=p(k|k-1),p_last=p(k-1|k-1),Q=??
            kg = p_mid / (p_mid + R);                 // kg?kalman filter,R ???
            x_now = x_mid + kg * (ResrcData - x_mid);   // ???????
            p_now = (1 - kg) * p_mid;                 // ??????covariance
            p_last[db] = p_now;                     // ??covariance ?
            x_last[db] = x_now;                     // ????????	
            return x_now;
        }
        static void FindPointC(double rac, double rbc, double xTarget1, double yTarget2, double xTarget2, double yTarget1 ,ref int r3, ref int r4)
        {
            double xC, yC;

            // 求解xC和yC
            xC = (rac * rac - rbc * rbc ) / 4000.0+1000;
            yC = Math.Sqrt(rac * rac - xC * xC);

            // 计算点C到指定点的距离
            double distanceToTarget1 = Math.Sqrt(Math.Pow(xC - xTarget1, 2) + Math.Pow(yC - yTarget1, 2));
            double distanceToTarget2 = Math.Sqrt(Math.Pow(xC - xTarget2, 2) + Math.Pow(yC - yTarget2, 2));
            // 将计算得到的距离值赋给r3
            r3 = Convert.ToInt32(distanceToTarget1);
            r4 = Convert.ToInt32(distanceToTarget2);
        }

    }

}//乘-1的random次方 坐标变化速率大幅减小
//两r定一点（zrt的问题实际可以简化）

/*using System;
using System.IO;

namespace TwoDimensionalLocalizationAlgorithm
{
    class Program
    {
        // 定义全局变量
        static double[] x_last = new double[2];
        static double[] p_last = new double[2];

        static void Main(string[] args)
        {
            // 指定输出文件路径
            string filePath = "output8.txt";

            // 打开输出文件，如果文件不存在则创建，如果文件存在则追加内容
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                Random rand = new Random();
                int x1 = rand.Next(101) * 10; // 生成 0 到 100 之间的整数
                int y1 = rand.Next(101) * 10;
                int r1 = rand.Next(51) * 10; // 生成 0 到 50 之间的整数
                int x2 = rand.Next(101) * 10;
                int y2 = rand.Next(101) * 10;
                int r2 = rand.Next(51) * 10;
                int x3 = rand.Next(101) * 10;
                int y3 = rand.Next(101) * 10;
                int r3 = rand.Next(51) * 10;
                int i;
                int r1_tmp, r2_tmp, r3_tmp;
                    for (i = 0; i < 20; i++)
                    {
                    r1_tmp = r1;
                    r2_tmp = r2;
                    r3_tmp = r3;
                    if (((r1 + r2) * (r1 + r2)) > ((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)) && ((r1 + r3) * (r1 + r3)) > ((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3)) && (r2 + r3) * (r2 + r3) > (x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3))
                    {
                        // 随机产生输入数据，转换为整数
                        //  x1 += rand.Next(1); // 生成 0 到 100 之间的整数
                        //  y1 += rand.Next(1);
                        r1 += rand.Next(1); // 生成 0 到 50 之间的整数
                                            //  x2 += rand.Next(1);
                                            // y2 += rand.Next(1);
                        r2 += rand.Next(1);
                        // x3 += rand.Next(1);
                        // y3 += rand.Next(1);
                        r3 += rand.Next(1);
                    }
                else
                {
                    r1 = r1_tmp;
                        r2 = r2_tmp;
                        r3 = r3_tmp;
                        i = i - 1;
                    }            
                    // 调用二维定位算法函数
                    double[] result = Get_three_BS_Out_XY(x1, y1, r1, x2, y2, r2, x3, y3, r3);

                    // 调用卡尔曼滤波函数，对结果进行滤波
                    double filteredX = KalmanFilter(result[0], 3, 10, 0); // 使用第一个传感器的数据进行滤波
                    double filteredY = KalmanFilter(result[1], 3, 10, 1); // 使用第二个传感器的数据进行滤波

                    // 写入输出结果到文件
                    writer.WriteLine($"Round {i + 1}:");
                    writer.WriteLine($"Input: x1: {x1}, y1: {y1}, r1: {r1}");
                    writer.WriteLine($"       x2: {x2}, y2: {y2}, r2: {r2}");
                    writer.WriteLine($"       x3: {x3}, y3: {y3}, r3: {r3}");
                    writer.WriteLine($"Output: Point_x: {result[0]}, Point_y: {result[1]}");
                    writer.WriteLine($"Filtered Output: Point_x: {filteredX}, Point_y: {filteredY}");
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Output has been written to file: " + filePath);
            Console.ReadKey(); // 保持控制台窗口打开
        }

        static double[] Get_three_BS_Out_XY(int x1, int y1, int r1,
                                    int x2, int y2, int r2,
                                    int x3, int y3, int r3)
        {
            double[,] A = new double[2, 2];
            double[,] B = new double[2, 2];
            double[] C = new double[2];
            double[] Point_xy = new double[2];
            A[0, 0] = 2 * (x1 - x2); A[0, 1] = 2 * (y1 - y2);
            A[1, 0] = 2 * (x1 - x3); A[1, 1] = 2 * (y1 - y3);

            double det = 0;
            det = A[0, 0] * A[1, 1] - A[1, 0] * A[0, 1];

            if (det != 0)
            {
                B[0, 0] = A[1, 1] / det;
                B[0, 1] = -A[0, 1] / det;
                B[1, 0] = -A[1, 0] / det;
                B[1, 1] = A[0, 0] / det;

                C[0] = r2 * r2 - r1 * r1 - x2 * x2 + x1 * x1 - y2 * y2 + y1 * y1;
                C[1] = r3 * r3 - r1 * r1 - x3 * x3 + x1 * x1 - y3 * y3 + y1 * y1;

                Point_xy[0] = B[0, 0] * C[0] + B[0, 1] * C[1];
                Point_xy[1] = B[1, 0] * C[0] + B[1, 1] * C[1];

                return Point_xy;
            }
            else
            {
                Point_xy[0] = 0;
                Point_xy[1] = 0;

                return Point_xy;
            }
        }
        static double KalmanFilter(double ResrcData, double ProcessNoise_Q, double MeasureNoise_R, int db)
        {
            double R = MeasureNoise_R;
            double Q = ProcessNoise_Q;
            double x_mid = x_last[db];
            double x_now;
            double p_mid;
            double p_now;
            double kg;

            x_mid = x_last[db];                       // x_last=x(k-1|k-1),x_mid=x(k|k-1)
            p_mid = p_last[db] + Q;                     // p_mid=p(k|k-1),p_last=p(k-1|k-1),Q=??
            kg = p_mid / (p_mid + R);                 // kg?kalman filter,R ???
            x_now = x_mid + kg * (ResrcData - x_mid);   // ???????
            p_now = (1 - kg) * p_mid;                 // ??????covariance
            p_last[db] = p_now;                     // ??covariance ?
            x_last[db] = x_now;                     // ????????	
            return x_now;
        }
    }
}*///坐标不变，数据高达3.9GB！
/*using System;
using System.IO;

namespace TwoDimensionalLocalizationAlgorithm
{
    class Program
    {
        // 定义全局变量
        static double[] x_last = new double[2];
        static double[] p_last = new double[2];

        static void Main(string[] args)
        {
            // 指定输出文件路径
            string filePath = "output10.txt";

            // 打开输出文件，如果文件不存在则创建，如果文件存在则追加内容
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                Random rand = new Random();
                //int i = 0;
                // while (i < 20)
                //{
                int x1 = rand.Next(101) * 10; // 生成 0 到 100 之间的整数
                int y1 = rand.Next(101) * 10;
                int r1 = rand.Next(51) * 10; // 生成 0 到 50 之间的整数
                int x2 = rand.Next(101) * 10;
                int y2 = rand.Next(101) * 10;
                int r2 = rand.Next(51) * 10;
                int x3 = rand.Next(101) * 10;
                int y3 = rand.Next(101) * 10;
                int r3 = rand.Next(51) * 10;
                int r1_tmp, r2_tmp, r3_tmp;
               // int i = 0;

                r1_tmp = r1;
                r2_tmp = r2;
                r3_tmp = r3;
                for (int i=0; i < 20; i++)
                {
                    r1 += rand.Next(21) * 10;
                    r2 += rand.Next(21) * 10;
                    r3 += rand.Next(21) * 10;
                    if (((r1 + r2) * (r1 + r2)) > ((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)) && ((r1 + r3) * (r1 + r3)) > ((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3)) && (r2 + r3) * (r2 + r3) > (x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3))
                    {
                        //i += 1;
                        r1_tmp = r1;
                        r2_tmp = r2;
                        r3_tmp = r3;
                        double[] result = Get_three_BS_Out_XY(x1, y1, r1, x2, y2, r2, x3, y3, r3);

                        // 调用卡尔曼滤波函数，对结果进行滤波
                        double filteredX = KalmanFilter(result[0], 3, 10, 0); // 使用第一个传感器的数据进行滤波
                        double filteredY = KalmanFilter(result[1], 3, 10, 1); // 使用第二个传感器的数据进行滤波

                        // 写入输出结果到文件
                        writer.WriteLine($"Round {i + 1}:");
                        writer.WriteLine($"Input: x1: {x1}, y1: {y1}, r1: {r1}");
                        writer.WriteLine($"       x2: {x2}, y2: {y2}, r2: {r2}");
                        writer.WriteLine($"       x3: {x3}, y3: {y3}, r3: {r3}");
                        writer.WriteLine($"Output: Point_x: {result[0]}, Point_y: {result[1]}");
                        writer.WriteLine($"Filtered Output: Point_x: {filteredX}, Point_y: {filteredY}");
                        writer.WriteLine();

                    }
                    else
                    {
                        r1 = r1_tmp;
                        r2 = r2_tmp;
                        r3 = r3_tmp;
                        i--;
                    }
                }
                // 调用二维定位算法函数
            }
            Console.WriteLine("Output has been written to file: " + filePath);
            Console.ReadKey(); // 保持控制台窗口打开
        }

        static double[] Get_three_BS_Out_XY(int x1, int y1, int r1,
                                    int x2, int y2, int r2,
                                    int x3, int y3, int r3)
        {
            double[,] A = new double[2, 2];
            double[,] B = new double[2, 2];
            double[] C = new double[2];
            double[] Point_xy = new double[2];
            A[0, 0] = 2 * (x1 - x2); A[0, 1] = 2 * (y1 - y2);
            A[1, 0] = 2 * (x1 - x3); A[1, 1] = 2 * (y1 - y3);

            double det = 0;
            det = A[0, 0] * A[1, 1] - A[1, 0] * A[0, 1];

            if (det != 0)
            {
                B[0, 0] = A[1, 1] / det;
                B[0, 1] = -A[0, 1] / det;
                B[1, 0] = -A[1, 0] / det;
                B[1, 1] = A[0, 0] / det;

                C[0] = r2 * r2 - r1 * r1 - x2 * x2 + x1 * x1 - y2 * y2 + y1 * y1;
                C[1] = r3 * r3 - r1 * r1 - x3 * x3 + x1 * x1 - y3 * y3 + y1 * y1;

                Point_xy[0] = B[0, 0] * C[0] + B[0, 1] * C[1];
                Point_xy[1] = B[1, 0] * C[0] + B[1, 1] * C[1];

                return Point_xy;
            }
            else
            {
                Point_xy[0] = 0;
                Point_xy[1] = 0;

                return Point_xy;
            }
        }
        static double KalmanFilter(double ResrcData, double ProcessNoise_Q, double MeasureNoise_R, int db)
        {
            double R = MeasureNoise_R;
            double Q = ProcessNoise_Q;
            double x_mid = x_last[db];
            double x_now;
            double p_mid;
            double p_now;
            double kg;

            x_mid = x_last[db];                       // x_last=x(k-1|k-1),x_mid=x(k|k-1)
            p_mid = p_last[db] + Q;                     // p_mid=p(k|k-1),p_last=p(k-1|k-1),Q=??
            kg = p_mid / (p_mid + R);                 // kg?kalman filter,R ???
            x_now = x_mid + kg * (ResrcData - x_mid);   // ???????
            p_now = (1 - kg) * p_mid;                 // ??????covariance
            p_last[db] = p_now;                     // ??covariance ?
            x_last[db] = x_now;                     // ????????	
            return x_now;
        }
    }
}//标签变，基站不变
*/
/*using System;
using System.IO;

namespace TwoDimensionalLocalizationAlgorithm
{
    class Program
    {
        // 定义全局变量
        static double[] x_last = new double[2];
        static double[] p_last = new double[2];

        static void Main(string[] args)
        {
            // 指定输出文件路径
            string filePath = "output15.txt";

            // 打开输出文件，如果文件不存在则创建，如果文件存在则追加内容
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                Random rand = new Random();
                int x1 = 0; // 生成 0 到 100 之间的整数
                int y1 = 0;
               // int r1 = 1414; // 生成 0 到 50 之间的整数
                int x2 = 2000;
                int y2 = 2000;
               // int r2 = 1414;
                int x3 = 0;
                int y3 = 2000;
               // int r3 = 1414;
                int x4 =2000;
                int y4 = 0;
              //  int r4 =1414;
                int z1 = 0;
                int z2 = 0;
                int z3 = 2000;
                int z4 = 2000;
                int xzb= rand.Next(101) * 10;
                int yzb= rand.Next(101) * 10;
                int zzb= rand.Next(101) * 10;
                int r1=0, r2=0, r3=0, r4=0;
                for (int i = 0; i < 20; i++)
                {
                    // 随机产生输入数据，转换为整数
                    // x1 += rand.Next(11) ; // 生成 0 到 100 之间的整数
                    // y1 += rand.Next(11) ;
                    xzb += rand.Next(21); // 生成 0 到 50 之间的整数
                                          // x2 += rand.Next(11) ;
                                          //y2 += rand.Next(11) ;
                    yzb += rand.Next(21);
                    zzb += rand.Next(21);
                    //  x3 += rand.Next(11) ;
                    //y3 += rand.Next(11) ;
                    // r3 += rand.Next(21) ;
                    FindPointC(x1, y1, z1, xzb, yzb, zzb, ref r1);
                    FindPointC(x2, y2, z2, xzb, yzb, zzb, ref r2);
                    FindPointC( x3,y3,z3,xzb,yzb,zzb,ref r3);
                    FindPointC( x4, y4,z4, xzb, yzb, zzb, ref r4);
                    // 调用二维定位算法函数
                    double[] result = Get_three_BS_Out_XY(x1, y1, r1, x2, y2, r2, x3, y3, r3);

                    // 调用卡尔曼滤波函数，对结果进行滤波
                    double filteredX = KalmanFilter(result[0], 3, 10, 0); // 使用第一个传感器的数据进行滤波
                    double filteredY = KalmanFilter(result[1], 3, 10, 1); // 使用第二个传感器的数据进行滤波

                    // 写入输出结果到文件
                    writer.WriteLine($"Round {i + 1}:");
                    writer.WriteLine($"Input: x1: {x1}, y1: {y1}, r1: {r1}");
                    writer.WriteLine($"       x2: {x2}, y2: {y2}, r2: {r2}");
                    writer.WriteLine($"       x3: {x3}, y3: {y3}, r3: {r3}");
                    writer.WriteLine($"       x4: {x4}, y4: {y4}, r4: {r4}");
                    writer.WriteLine($"Output: Point_x: {result[0]}, Point_y: {result[1]}");
                    writer.WriteLine($"Filtered Output: Point_x: {filteredX}, Point_y: {filteredY}");
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Output has been written to file: " + filePath);
            Console.ReadKey(); // 保持控制台窗口打开
        }
        static double[] Get_three_BS_Out_XY(int x1, int y1, int r1,
                                    int x2, int y2, int r2,
                                    int x3, int y3, int r3)
        {
            double[,] A = new double[2, 2];
            double[,] B = new double[2, 2];
            double[] C = new double[2];
            double[] Point_xy = new double[2];
            A[0, 0] = 2 * (x1 - x2); A[0, 1] = 2 * (y1 - y2);
            A[1, 0] = 2 * (x1 - x3); A[1, 1] = 2 * (y1 - y3);

            double det = 0;
            det = A[0, 0] * A[1, 1] - A[1, 0] * A[0, 1];

            if (det != 0)
            {
                B[0, 0] = A[1, 1] / det;
                B[0, 1] = -A[0, 1] / det;
                B[1, 0] = -A[1, 0] / det;
                B[1, 1] = A[0, 0] / det;

                C[0] = r2 * r2 - r1 * r1 - x2 * x2 + x1 * x1 - y2 * y2 + y1 * y1;
                C[1] = r3 * r3 - r1 * r1 - x3 * x3 + x1 * x1 - y3 * y3 + y1 * y1;

                Point_xy[0] = B[0, 0] * C[0] + B[0, 1] * C[1];
                Point_xy[1] = B[1, 0] * C[0] + B[1, 1] * C[1];

                return Point_xy;
            }
            else
            {
                Point_xy[0] = 0;
                Point_xy[1] = 0;

                return Point_xy;
            }
        }
        static double KalmanFilter(double ResrcData, double ProcessNoise_Q, double MeasureNoise_R, int db)
        {
            double R = MeasureNoise_R;
            double Q = ProcessNoise_Q;
            double x_mid = x_last[db];
            double x_now;
            double p_mid;
            double p_now;
            double kg;

            x_mid = x_last[db];                       // x_last=x(k-1|k-1),x_mid=x(k|k-1)
            p_mid = p_last[db] + Q;                     // p_mid=p(k|k-1),p_last=p(k-1|k-1),Q=??
            kg = p_mid / (p_mid + R);                 // kg?kalman filter,R ???
            x_now = x_mid + kg * (ResrcData - x_mid);   // ???????
            p_now = (1 - kg) * p_mid;                 // ??????covariance
            p_last[db] = p_now;                     // ??covariance ?
            x_last[db] = x_now;                     // ????????	
            return x_now;
        }
        static void FindPointC(double xC, double yC, double zC, double xTarget, double yTarget, double zTarget, ref int r3)
        {
           // double xC, yC;

            // 求解xC和yC
            //xC = (rac * rac - rbc * rbc + 1000000) / 2000.0;
            //yC = Math.Sqrt(rac * rac - xC * xC);

            // 计算点C到指定点的距离
            double distanceToTarget = Math.Sqrt(Math.Pow(xC - xTarget, 2) + Math.Pow(yC - yTarget, 2)+Math.Pow(zC - zTarget, 2));
            // 将计算得到的距离值赋给r3
            r3 = Convert.ToInt32(distanceToTarget);
        }

    }

}*///乘-1的random次方 坐标变化速率大幅减小
 //两r定一点（zrt的问题实际可以简化）
 //真三维