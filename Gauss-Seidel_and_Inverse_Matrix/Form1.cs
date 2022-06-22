using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gauss_Seidel_and_Inverse_Matrix
{
    public partial class Form1 : Form
    {

        int matrixSize;
        static int N;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void cbOk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOk.Checked)
            {
                try
                {
                    matrixSize = int.Parse(tbInputNumber.Text);
                }
                catch
                {
                    MessageBox.Show("Masukkan nilai dengan benar!");
                    cbOk.Checked = false;
                    return;
                }
                tbInputNumber.ReadOnly = true;
                          
                label6.Text = matrixSize.ToString() + " X " + matrixSize.ToString();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();

                var colX1 = new DataGridViewColumn();
                colX1.HeaderText = "answer";
                colX1.CellTemplate = new DataGridViewTextBoxCell();
                colX1.Width = 70;
                dataGridView2.Columns.Add(colX1);



                for(int i=0; i < matrixSize + 1; i++)
                {
                    var column = new DataGridViewColumn();
                    column.HeaderText = (i == matrixSize ? "Y" : "X" + (i + 1).ToString());
                    column.CellTemplate = new DataGridViewTextBoxCell();
                    column.Width = 30;
                    dataGridView1.Columns.Add(column);

                    if(i != matrixSize)
                    {
                        dataGridView2.Rows.Add();
                    }
                }

                for(int j=0; j<matrixSize; j++)
                {
                    dataGridView1.Rows.Add();
                }


            }
            else
            {
                tbInputNumber.ReadOnly = false;
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbGauss.Checked)
            {
                double[][] x_eq = new double[matrixSize][];
                double[] y_eq = new double[matrixSize];
                double[] r_eq = new double[matrixSize];

                for(int i = 0; i < matrixSize; i++)
                {
                    x_eq[i] = new double[matrixSize];
                    r_eq[i] = 0;
                    y_eq[i] = double.Parse((string) dataGridView1.Rows[i].Cells[matrixSize].Value);
                    for(int j=0; j < matrixSize; j++)
                    {
                        x_eq[i][j] = double.Parse((string)dataGridView1.Rows[i].Cells[j].Value);
                        //Console.Write(x_eq[i][j] + "\t");
                    }
                    //Console.WriteLine();
                }

                r_eq = GaussSeidel(x_eq, y_eq, r_eq);

                if (Double.IsNaN(r_eq[0])){
                    MessageBox.Show("Doesn't convergence");
                }

                for (int i = 0; i < matrixSize; i++)
                {
                    Console.Write(r_eq[i] + "\t");
                    dataGridView2.Rows[i].Cells[0].Value = r_eq[i];
                }
            }
            else if(rbInverse.Checked)
            {
                double[] y_eq = new double[matrixSize];
                double[] r_eq = new double[matrixSize];

                double[,] x_eq = new double[matrixSize,matrixSize];
                double[,] inv_x_eq = new double[matrixSize,matrixSize];


                for (int i = 0; i < matrixSize; i++)
                {
                    y_eq[i] = double.Parse((string)dataGridView1.Rows[i].Cells[matrixSize].Value);
                    for (int j = 0; j < matrixSize; j++)
                    {
                        x_eq[i,j] = double.Parse((string)dataGridView1.Rows[i].Cells[j].Value);
                    }
                }
                //inv_x_eq = InverseMatrix(x_eq);
                N = x_eq.GetLength(0);
                //Console.WriteLine("N", N);
                inverse(x_eq, inv_x_eq);
                display(x_eq);
                Console.WriteLine();
                display(inv_x_eq);

                for(int i=0; i<matrixSize; i++)
                {
                    
                    for(int j=0; j<matrixSize; j++)
                    {
                        r_eq[i] += inv_x_eq[i, j] * y_eq[j];
                    }
                    Console.WriteLine(r_eq[i]);
                }

                for (int i = 0; i < matrixSize; i++)
                {
                    Console.Write(r_eq[i] + "\t");
                    dataGridView2.Rows[i].Cells[0].Value = r_eq[i];
                }



            }
        }


        public static double MaxError = .00000001;
        public static double MaxIteration = 1000000;
        public static double Lambda = .5;
        public static double[] GaussSeidel1(double[][] a, double[] b, double[] r)
        {
            int n = a.Length;
            double[] r_prev = new double[n];
            //declare r_prev to zero
            for(int i =0; i < n; i++)
            {
                r_prev[i] = 0.0;
            }

            for(int i=0; i < MaxIteration; i++) {
                for(int j=0; j < n; j++)
                {
                    r_prev[j] = r[j];
                }

                for(int j=0; j<n; j++)
                {
                    double sum = 0.0;
                    for(int k=0; k<n; k++)
                    {
                        if (k != j)
                        {
                            sum = sum + a[j][k] * r[k];
                        }
                    }
                    r[j] = (b[j] - sum) / a[j][j];

                }

                double diff1_norm = 0.0;
                double old_norm = 0.0;
                for(int j=0; j < n; j++)
                {
                    diff1_norm = diff1_norm + Math.Abs(r[j] - r_prev[j]);
                    old_norm = old_norm + Math.Abs(r_prev[j]);
                }
                if(old_norm == 0.0)
                {
                    old_norm = 1.0;
                }
                double norm = diff1_norm / old_norm;
                if(norm<MaxError && i != 0)
                {
                    //Console.Write("Sequence converges to [");
                    for(int j=0; j<n-1; j++)
                    {
                        //Console.Write(r[j]);
                    }
                    //Console.Write(r[n - 1]);
                    //Console.Write(" ]. Took ");
                    //Console.Write(i + 1);
                    //Console.WriteLine(" iterations.");
                    return r;
                }
            }
            Console.WriteLine("Doesnt converge");
            for(int i=0; i < n; i++)
            {
                r[i] = double.NaN;
            }
            return r;
        }

        public static double[] GaussSeidel(double[][] a, double[] b, double[] r)
        {
            int n = a.Length;

            //Division by the diagonal element to reduce calculation
            for (int i = 0; i < n; i++)
            {
                double d = a[i][i];
                for (int j = 0; j < n; j++)
                {
                    a[i][j] = a[i][j] / d;
                }
                b[i] = b[i] / d;
            }

            //Generation of initial values for roots
            for (int i = 0; i < n; i++)
            {
                double sum = b[i];
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        sum -= (a[i][j] * r[j]);
                    }
                }
                r[i] = sum;
            }

            //Iterations for converging to the real roots
            for (int itr = 1; itr < MaxIteration; itr++)
            {

                for (int i = 0; i < n; i++)
                {
                    double old = r[i];
                    double sum = b[i];

                    for (int j = 0; j < n; j++)
                    {
                        if (i != j)
                            sum -= (a[i][j] * r[j]);
                    }

                    r[i] = Lambda * sum + (1 - Lambda) * old;
                    if (r[i] != 0)
                    {
                        double ea = Math.Abs((r[i] - old) / r[i]) * 100;
                        if (ea < MaxError)
                            return r;
                    }
                }
            }

            return r;
        }


        //==============================================================

        static void getCofactor(double[,] A, double[,] temp, int p, int q, int n)
        {
            int i = 0, j = 0;

            // Looping for each element of the matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    // Copying into temporary matrix only those element
                    // which are not in given row and column
                    if (row != p && col != q)
                    {
                        temp[i, j++] = A[row, col];

                        // Row is filled, so increase row index and
                        // reset col index
                        if (j == n - 1)
                        {
                            j = 0;
                            i++;
                        }
                    }
                }
            }
        }

        
        static double determinant(double[,] A, int n)
        {
            double D = 0; // Initialize result

            // Base case : if matrix contains single element
            if (n == 1)
                return A[0, 0];

            double[,] temp = new double[N, N]; // To store cofactors

            int sign = 1; // To store sign multiplier

            // Iterate for each element of first row
            for (int f = 0; f < n; f++)
            {
                // Getting Cofactor of A[0,f]
                getCofactor(A, temp, 0, f, n);
                D += sign * A[0, f] * determinant(temp, n - 1);

                // terms are to be added with alternate sign
                sign = -sign;
            }
            return D;
        }


        static void adjoint(double[,] A, double[,] adj)
        {
            if (N == 1)
            {
                adj[0, 0] = 1;
                return;
            }

            // temp is used to store cofactors of [,]A
            int sign = 1;
            double[,] temp = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // Get cofactor of A[i,j]
                    getCofactor(A, temp, i, j, N);

                    // sign of adj[j,i] positive if sum of row
                    // and column indexes is even.
                    sign = ((i + j) % 2 == 0) ? 1 : -1;

                    // Interchanging rows and columns to get the
                    // transpose of the cofactor matrix
                    adj[j, i] = (sign) * (determinant(temp, N - 1));
                }
            }
        }


        static bool inverse(double[,] A, double[,] inverse)
        {
            // Find determinant of [,]A
            double det = determinant(A, N);
            if (det == 0)
            {
                Console.Write("Singular matrix, can't find its inverse");
                return false;
            }

            // Find adjoint
            double[,] adj = new double[N, N];
            adjoint(A, adj);

            // Find Inverse using formula "inverse(A) = adj(A)/det(A)"
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    inverse[i, j] = adj[i, j] / (float)det;

            return true;
        }


        static void display(double[,] A)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(A[i, j] + " ");
                Console.WriteLine();
            }
        }

    }

}
