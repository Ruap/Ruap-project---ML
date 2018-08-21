using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV; //
using Emgu.CV.Structure; //
using System.Net.Http; //
using System.Net.Http.Headers; //
using System.Drawing.Imaging; //
using System.IO; //


namespace Interface
{
    public partial class Form1 : Form
    {
        Image File; //za sliku
        OpenFileDialog current; //za ucitanu sliku, request

        //crtanje
        Graphics draw;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        Bitmap bmp;
       
        Image<Bgr, byte> colored; //dorada prepoznavanja slike u boji

        public Form1()
        {
            InitializeComponent();

            draw = panel1.CreateGraphics();
            draw.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 25);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            bmp = new Bitmap(panel1.Width, panel1.Height);
            draw = Graphics.FromImage(bmp);
            panel1.BackgroundImage = bmp;
            panel1.BackgroundImageLayout = ImageLayout.None;

            radioBtnNormal.Checked = true;
        }


        private void btn_open_Click(object sender, EventArgs e)
        {
            var pixeli = new Dictionary<string, string>();
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";

                current = file;

                lbl_result_title.Text = "Result:";
                lbl_result.Font = new Font(lbl_result_title.Font, FontStyle.Bold);
                lbl_result.Text = "waiting for request...";
                lbl_result.Font = new Font(lbl_result.Font, FontStyle.Bold);


                if (file.ShowDialog() == DialogResult.OK)
                {
                    File = Image.FromFile(file.FileName);
                    canvas.Image = File;
                }
          
            }
            catch (Exception)
            {
                MessageBox.Show("Error is occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void btn_request_Click(object sender, EventArgs e)
        {
            var pixeli = new Dictionary<string, string>();
            try
            {
                OpenFileDialog file = current;
                var Image = new Image<Gray, byte>(file.FileName);

                colored = new Image<Bgr, byte>(file.FileName); //dorada prepozavanja slike u boji

                lbl_result.Text = "waiting for request...";
                lbl_result.Font = new Font(lbl_result.Font, FontStyle.Bold);
                lbl_result_title.Text = "Number:";


                if (file != null)
                {
                    var resized = Image.Resize(28, 28, Emgu.CV.CvEnum.Inter.Cubic);
                    for (int i = 0; i < resized.Bytes.Length; i++)
                    {
                        if(radioBtnNormal.Checked)
                            pixeli.Add("pixel" + i, (255 - resized.Bytes[i]).ToString()); // invert vrijednosti pixela slike kako bi bio uskladen s treniranim skupom podataka
                        if(radioBtnInverse.Checked)
                            pixeli.Add("pixel" + i, (resized.Bytes[i]).ToString());
                    }

                    //Console.WriteLine(resized.Bytes);

                    ///dorada za boju
                    var col = colored.Resize(28, 28, Emgu.CV.CvEnum.Inter.Cubic);
                    int sumR = 0, sumG = 0, sumB = 0;
                    bool flagNotColored = false;

                    for (int i = 0; i < col.Width; i++)
                    {
                        for (int j = 0; j < col.Height; j++)
                        {
                            sumR += (int)col.Data[i, j, 2];
                            sumG += (int)col.Data[i, j, 1];
                            sumB += (int)col.Data[i, j, 0];
                        }
                    }
                   // Console.WriteLine("Sum of red channel: {0}", sumR);
                   // Console.WriteLine("Sum of green channel: {0}", sumG);
                   // Console.WriteLine("Sum of blue channel: {0}", sumB);

                    if (sumR == sumG && sumG == sumB && sumR == sumB)
                        flagNotColored = true;

                    ///kraj za boje

                    //// Web service
                    using (var client = new HttpClient())
                    {
                        var scoreRequest = new
                        {
                            Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                            {
                            "input1",
                            new List<Dictionary<string, string>>(){
                                pixeli                                  
                                }
                            },
                        },
                            GlobalParameters = new Dictionary<string, string>()
                            {
                            }
                        };


                        const string apiKey = "SUVjw6dB/CuWyEFHXKH2q0d18QNrisxvWltQxERkeVaYoTjoY2jBPP2ktGujAVa4a9O2Q1V2uyRTkn9KTWo64g=="; // Replace this with the API key for the web service
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                        client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/70f52eba71314efeb7ddf06882d4ac2c/services/b5c32c7f2acf4c939f327063a2c4533b/execute?api-version=2.0&format=swagger");

                        // WARNING: The 'await' statement below can result in a deadlock
                        HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                        if (response.IsSuccessStatusCode)
                        {
                            string result = await response.Content.ReadAsStringAsync();
                            Console.WriteLine("Result: {0}", result);
                            string[] removeChar = { "{", "}", "[", "]", ":","Results","output1"," ", ",",/*"\"",*/ "Scored Labels", 
                                                  "Scored Probabilities for Class", "\"",/* "0\"", "1\"", "2\"", "3\"", "4\"",
                                                  "5\"", "6\"", "7\"", "8\"", "9\"",*/ "\\"};
                            string[] cleanedResult = result.Split(removeChar, System.StringSplitOptions.RemoveEmptyEntries);

                            double[] array = Array.ConvertAll(cleanedResult, Double.Parse);
                            if (flagNotColored)
                            {
                                if (array[1] > 0.01 || array[3] > 0.01 || array[5] > 0.01 || array[7] > 0.01 || array[9] > 0.01
                                    || array[11] > 0.01 || array[13] > 0.01 || array[15] > 0.01 || array[17] > 0.01 || array[19] > 0.01)
                                {
                                    lbl_result.Text = cleanedResult[20].ToString();
                                    lbl_result.Font = new Font(lbl_result.Font, FontStyle.Bold);
                                }
                                else 
                                {
                                    lbl_result.Text = "It's not a number.";
                                }

                            }
                            else
                            {
                                lbl_result.Text = "It's not a grayscale image.";
                            }
                        }
                        else
                        {
                            Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                            // Print the headers - they include the requert ID and the timestamp,
                            // which are useful for debugging the failure
                            Console.WriteLine(response.Headers.ToString());

                            string responseContent = await response.Content.ReadAsStringAsync(); 
                            Console.WriteLine(responseContent);

                        }

                    }

                    /////
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error is occurred. There is no picture loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && x != -1 && y != -1)
            {
                    draw.DrawLine(pen, new Point(x, y), e.Location);
                    x = e.X;
                    y = e.Y;
                    panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void btn_save_draw_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
                try
                {
                    
                    file.Filter = "PNG files(*.png)|*.png | jpg files(*.jpg) | *.jpg";



                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        //provjera ukoliko vec postoji isti podatak s istim imenom
                        if (System.IO.File.Exists(file.FileName))
                        {
                            System.IO.File.Delete(file.FileName);
                        }

                        bmp.Save(file.FileName); // spremanje slike
                    }
                }
                catch
                {
                    MessageBox.Show("It's not possible to save the picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
         
            
   
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
                draw.Clear(Color.White);
                panel1.BackgroundImageLayout = ImageLayout.None;
                panel1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
