using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;



namespace image_changing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        Bitmap sourceBm, bufferBm;
        bool enable = false;
        OpenFileDialog openFile = new OpenFileDialog();
        private void openBtn_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK) {
                sourceImg.Image=Image.FromFile(openFile.FileName);
                sourceBm = new Bitmap(sourceImg.Image);
                bufferBm = new Bitmap(sourceImg.Image);
                resultImg.Image = sourceImg.Image;
                draw_graph(sourceBm, false);
                enable = true;
            }
        }

        Color cl;
       
       private void draw_graph(Bitmap image, bool target) {

            int theBiggest = 0;
            int[] red=new int[256];
            int[] green = new int[256];
            int[] blue = new int[256];

            for (int i = 0; i < image.Width; i++)
            {

                for (int j = 0; j < image.Height; j++)
                {

                    cl = image.GetPixel(i, j);
                    red[cl.R]++;
                    green[cl.G]++;
                    blue[cl.B]++;

                }
            }

            for (int j = 0; j < 256; j++)
            {


                red[j] /= 10;
                green[j] /= 10;
                blue[j] /= 10;

            }
            

            
            for (int x = 0; x < 255; x++)
            {
                if (red[x] > theBiggest) theBiggest=red[x];
                if (green[x] > theBiggest) theBiggest=green[x];
                if (blue[x] > theBiggest) theBiggest=blue[x];
            }


            Bitmap graphBm = new Bitmap(255, theBiggest);
            
            for (int i = 1; i < 255; i++)
            {

                for (int j = 1; j < ((red[i]*red[i])/theBiggest); j++)
                {

                    graphBm.SetPixel(i, graphBm.Height -j, Color.Red);

                }

                for (int j = 1; j < ((green[i] * green[i]) / theBiggest); j++)
                {

                    graphBm.SetPixel(i, graphBm.Height-j, Color.Green);

                }

                for (int j = 1; j < ((blue[i] * blue[i]) / theBiggest); j++)
                {

                    graphBm.SetPixel(i, graphBm.Height-j, Color.Blue);

                }


            }

            if (!target) graph1.Image = graphBm;
            else graph2.Image = graphBm;
        }

        private void filter_1() {

            Bitmap resultBm = new Bitmap(sourceBm.Width, sourceBm.Height);

            for (int i = 0; i < sourceBm.Width; i++) {

                for (int j = 0; j < sourceBm.Height; j++) {

                    cl=sourceBm.GetPixel(i, j);
                    //************************

                    cl = Color.FromArgb((cl.R + cl.G + cl.B) / 3, (cl.R + cl.G + cl.B) / 3, (cl.R + cl.G + cl.B) / 3);


                    //************************

                    resultBm.SetPixel(i, j, cl);
                
                }
            }
            bufferBm = resultBm;
            resultImg.Image = resultBm;
        }        

        private void filter_2()
        {

            Bitmap resultBm = new Bitmap(sourceBm.Width, sourceBm.Height);

            for (int i = 0; i < sourceBm.Width; i++)
            {

                for (int j = 0; j < sourceBm.Height; j++)
                {

                    cl = sourceBm.GetPixel(i, j);
                    //************************

                    cl = Color.FromArgb(cl.A, 255-cl.R, 255-cl.G, 255-cl.B);


                    //************************

                    resultBm.SetPixel(i, j, cl);

                }
            }
            bufferBm = resultBm;
            resultImg.Image = resultBm;
            
        }

        private void filter_3()
        {

            Bitmap resultBm = new Bitmap(sourceBm.Width, sourceBm.Height);

            for (int i = 0; i < sourceBm.Width; i++)
            {

                for (int j = 0; j < sourceBm.Height; j++)
                {

                    cl = sourceBm.GetPixel(i, j);
                    //************************

                    cl = Color.FromArgb(cl.A, (cl.R/64)*64, (cl.G/64)*64, (cl.B/64)*64);


                    //************************

                    resultBm.SetPixel(i, j, cl);

                }
            }
            bufferBm = resultBm;
            resultImg.Image = resultBm;
            
        }

        private void filter_4()
        {

            Bitmap resultBm = new Bitmap(sourceBm.Width, sourceBm.Height);

            for (int i = 0; i < sourceBm.Width; i++)
            {

                for (int j = 0; j < sourceBm.Height; j++)
                {

                    cl = sourceBm.GetPixel(i, j);
                    //************************

                    cl = Color.FromArgb(cl.A, (cl.R / 32) * 32, (cl.G / 32) * 32, (cl.B / 32) * 32);


                    //************************

                    resultBm.SetPixel(i, j, cl);

                }
            }
            bufferBm = resultBm;
            resultImg.Image = resultBm;
            
        }
        
        private void filter_5(int size)
        {

            Bitmap resultBm = new Bitmap(sourceBm.Width, sourceBm.Height);
            int r, g, b;
            for (int i = 0; i < sourceBm.Width-size; i+=size)
            {

                for (int j = 0; j < sourceBm.Height-size; j+=size)
                {
//перебор внутри квадрата будущего большого пикселя
                    r = 0;
                    g = 0;
                    b = 0;
                    for (int k = 0; k <= size; k++) {

                        for (int l = 0; l <= size; l++) { 
                        
                        cl = sourceBm.GetPixel(i+k, j+l);

                        r += cl.R;
                        g += cl.G;
                        b += cl.B;


                       
                        }
                    
                    }

//-------------------------------------------------
                    r /= size * size;
                    g /= size * size;
                    b /= size * size;

                        if (r >= 255) r = 255;
                        if (g >= 255) g = 255;
                        if (b >= 255) b = 255;

                        if (r <= 0) r = 0;
                        if (g <= 0) g = 0;
                        if (b <= 0) b = 0;

                        for (int k = 0; k <= size; k++)
                        {

                            for (int l = 0; l <= size; l++)
                            {
                                cl = Color.FromArgb(cl.A, r, g, b);
                                resultBm.SetPixel(i + k, j + l, cl);

                            }
                        }

                }
            }
            bufferBm = resultBm;
            resultImg.Image = resultBm;
        }

        private void filter_6(int power) {

            Bitmap resultBm = new Bitmap(sourceBm.Width, sourceBm.Height);
            int r, g, b,i=0,j=0;
            float bright=0, pbright=0;
            
            for (i = 0; i < sourceBm.Width; i++)
            {

                for (j = 0; j < sourceBm.Height; j++)
                {
                   cl = sourceBm.GetPixel(i, j);
                   bright += cl.GetBrightness();
                }
            }
            bright = (bright / (i * j));
            //rgbbright = (int)(bright*255);// средняя яркость фото 0-255


            for (i = 0; i < sourceBm.Width; i++)
            {

                for (j = 0; j < sourceBm.Height; j++)
                {
                    cl = sourceBm.GetPixel(i, j);
                    
                    //разница между средней яркостью фото и этим пикселем
 
                    pbright = bright - cl.GetBrightness();//разница в яркости между этим пикселем и яркостью фото


                    r = cl.R - power * ((int)(pbright * 1000)) / 100;
                    g = cl.G - power * ((int)(pbright * 1000)) / 100;
                    b = cl.B - power * ((int)(pbright * 1000)) / 100;


                    if (r >= 255) r = 255;
                    if (g >= 255) g = 255;
                    if (b >= 255) b = 255;

                    if (r <= 0) r = 0;
                    if (g <= 0) g = 0;
                    if (b <= 0) b = 0;

                    cl = Color.FromArgb(cl.A, r,g,b);
                    resultBm.SetPixel(i, j, cl);


                }
            }
           // MessageBox.Show("bright: "+ bright.ToString());
            bufferBm = resultBm;
            resultImg.Image = resultBm;

        }

        private void filter_7(int power)
        {

            Bitmap resultBm = new Bitmap(sourceBm.Width, sourceBm.Height);
            int r, g, b, i = 0, j = 0;
            int brightR = 0,brightG = 0,brightB = 0;

            for (i = 0; i < sourceBm.Width; i++)
            {

                for (j = 0; j < sourceBm.Height; j++)
                {
                    cl = sourceBm.GetPixel(i, j);
                    brightR += cl.R;
                    brightG += cl.G;
                    brightB += cl.B;
                }
            }


            brightR /= (i * j);
            brightG /= (i * j);
            brightB /= (i * j);
            


            for (i = 0; i < sourceBm.Width; i++)
            {

                for (j = 0; j < sourceBm.Height; j++)
                {
                    cl = sourceBm.GetPixel(i, j);


                    r = cl.R + power * (cl.R - (int)brightR) / 10;
                    g = cl.G + power * (cl.G - (int)brightG) / 10;
                    b = cl.B + power * (cl.B - (int)brightB) / 10;


                    if (r >= 255) r = 255;
                    if (g >= 255) g = 255;
                    if (b >= 255) b = 255;

                    if (r <= 0) r = 0;
                    if (g <= 0) g = 0;
                    if (b <= 0) b = 0;

                    cl = Color.FromArgb(cl.A, r, g, b);
                    resultBm.SetPixel(i, j, cl);


                }
            }

            bufferBm = resultBm;
            resultImg.Image = resultBm;

        }


        private void blur(int power)
        {

//            #region test1_blur

//            #region pixelize
//            int size = power;

//            Bitmap resultBm = new Bitmap(sourceBm.Width, sourceBm.Height);
//            int r, g, b;
//            for (int i = 0; i < sourceBm.Width - size; i += size)
//            {

//                for (int j = 0; j < sourceBm.Height - size; j += size)
//                {
//                    //перебор внутри квадрата будущего большого пикселя
//                    r = 0;
//                    g = 0;
//                    b = 0;
//                    for (int k = 0; k <= size; k++)
//                    {

//                        for (int l = 0; l <= size; l++)
//                        {

//                            cl = sourceBm.GetPixel(i + k, j + l);

//                            r += cl.R;
//                            g += cl.G;
//                            b += cl.B;



//                        }

//                    }

//                    //-------------------------------------------------
//                    r /= size * size;
//                    g /= size * size;
//                    b /= size * size;

//                    if (r >= 255) r = 255;
//                    if (g >= 255) g = 255;
//                    if (b >= 255) b = 255;

//                    if (r <= 0) r = 0;
//                    if (g <= 0) g = 0;
//                    if (b <= 0) b = 0;

//                    for (int k = 0; k <= size; k++)
//                    {

//                        for (int l = 0; l <= size; l++)
//                        {
//                            cl = Color.FromArgb(cl.A, r, g, b);
//                            resultBm.SetPixel(i + k, j + l, cl);

//                        }
//                    }

//                }
//            }
            
//#endregion

            
//            //сейчас в resultBm находится пикселизированная картинка, 
//            //каждый маленький пиксель исходной картинки будет суммироваться с большим пикселем 
//            //таким образом в пределах большого пикселя бутет усредняться цвет, посмотрим, что выйдет

//            //sourceBm = resultBm;
//            //теперь источник-это результат пикселизаци
//            Color cl2;
//            for (int i = 0; i < sourceBm.Width - size; i += size)
//            {

//                for (int j = 0; j < sourceBm.Height - size; j += size)
//                {
//                    //перебор внутри квадрата будущего большого пикселя
//                    r = 0;
//                    g = 0;
//                    b = 0;
//                    for (int k = 0; k <= size; k++)
//                    {

//                        for (int l = 0; l <= size; l++)
//                        {
//                            //тут внутри для каждого пикселя надо высчитывать среднее между ним и большим пикселем
//                            //между resultBM и sourceBm
//                            cl = sourceBm.GetPixel(i + k, j + l);
//                            cl2 = resultBm.GetPixel(i + k, j + l);

//                            r = (cl.R+cl2.R)/2;
//                            g = (cl.G+cl2.G)/2;
//                            b = (cl.B+cl2.B)/2;
//                            resultBm.SetPixel(i + k, j + l, Color.FromArgb(r,g,b));


//                        }

//                    }

//                    //-------------------------------------------------
             

                   

//                }
//            }

//            bufferBm = resultBm;
//            resultImg.Image = resultBm;
//            //результат странный, но предсказуемый, видны большие пиксели, при этом есть сглаживание между ними


//            #endregion







        }


        private void blur2(int power)
        {

            //теперь просто для каждой точки я буду искать среднее значение, в зависимости от соседних точек
            //причем, надо учесть, что чем ближе точка,тем больше она должна влиять=но это проверить позже
            //в зависимочти от силы-выбирается количество соседних точек для влияния на заданную точку
            Bitmap resultBm = new Bitmap(sourceBm.Width, sourceBm.Height);
            Color cl;
            long r=0, g=0, b=0;
            int amount = 0;
           

            


            for (int i = 0; i < resultBm.Width; i++)
            {
                for (int j = 0; j < resultBm.Height; j++)
                {
                    //перебор каждого пикселя в картинке

                    //cl = sourceBm.GetPixel(i, j);
                    //для каждого пикселя надо учесть соседние


                    //по горизонтали
                    amount = 0;
                    for (int k = (i - power > 0 ? i - power : 0); k < (i + power > sourceBm.Width ? sourceBm.Width : i + power); k++)
                    {

                        //внутрь вложен цикл по вертикали
                        for (int l = (j - power > 0 ? j - power : 0); l < (j + power > sourceBm.Height ? sourceBm.Height : j + power); l++)
                        {
                            cl = sourceBm.GetPixel(k, l);
                            r += cl.R;
                            g += cl.G;
                            b += cl.B;
                            amount++;
                        }


                        //получили сумму по цветам, теперь усредняем и записываем

                    }


                    r = r / amount;
                    g = g / amount;
                    b = b / amount;
                    if (r >= 255) r = 255;
                    if (g >= 255) g = 255;
                    if (b >= 255) b = 255;
                    resultBm.SetPixel(i, j, Color.FromArgb((int)r, (int)g,(int) b));


                }
            }


            bufferBm = resultBm;
            resultImg.Image = resultBm;
        }


        private void blur_parallel(int power) {
            //bluring возвращает лист цветов для каждой линии

            int wid=sourceBm.Width;
            Parallel.For(0, wid,i=>{
                Bitmap _sourceBm = new Bitmap(sourceBm);
               int[,] output = bluring(_sourceBm, power, i);

               

            });


                
            
        
        }


        internal static int[,] bluring(Bitmap btm, int power,int i)
        {
            Color cl;
            long r = 0, g = 0, b = 0;
            int amount = 0;
            int wid = btm.Width;
            int hei = btm.Height;
            //List<Color> pixelLine = new List<Color>();
            int[,] mass = new int[hei, 3];
            for (int j = 0; j < hei; j++)
            {
                
                amount = 0;
                for (int k = (i - power > 0 ? i - power : 0); k < (i + power > wid ? wid : i + power); k++)
                {

                    
                    for (int l = (j - power > 0 ? j - power : 0); l < (j + power > hei ? hei : j + power); l++)
                    {
                        cl = btm.GetPixel(k, l);
                        r += cl.R;
                        g += cl.G;
                        b += cl.B;
                        amount++;
                    }


                   

                }


                r = r / amount;
                g = g / amount;
                b = b / amount;
                if (r >= 255) r = 255;
                if (g >= 255) g = 255;
                if (b >= 255) b = 255;
                mass[j, 0] = (int)r;
                mass[j, 1] = (int)g;
                mass[j, 2] = (int)b;

                //pixelLine.Add(Color.FromArgb((int)r, (int)g, (int)b));

            }
            return mass;
        }


        private void filter1_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                filter_1();
                draw_graph(bufferBm, true);
            }
        }

        private void filter2_Click(object sender, EventArgs e)
        {
            if (enable)
            {
            
                filter_2();
                draw_graph(bufferBm, true);
            }
        }

        
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.gif";
                saveFile.Title = "Save an Image File";
                saveFile.ShowDialog();

                if (saveFile.FileName != "")
                {

                    System.IO.FileStream fs = (System.IO.FileStream)saveFile.OpenFile();

                    switch (saveFile.FilterIndex)
                    {
                        case 1:
                            resultImg.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            resultImg.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                        case 3:
                            resultImg.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                    }

                    fs.Close();
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (enable)
            {
                Bitmap resultBm = new Bitmap(sourceBm.Width, sourceBm.Height);

                for (int i = 0; i < sourceBm.Width; i++)
                {

                    for (int j = 0; j < sourceBm.Height; j++)
                    {

                        cl = bufferBm.GetPixel(i, j);
                        //************************

                        int r, g, b;

                        r = cl.R; g = cl.G; b = cl.B;

                        r += (int)numericUpDown1.Value;
                        g += (int)numericUpDown1.Value;
                        b += (int)numericUpDown1.Value;

                        if (r >= 255) r = 255;
                        if (g >= 255) g = 255;
                        if (b >= 255) b = 255;

                        if (r <= 0) r = 0;
                        if (g <= 0) g = 0;
                        if (b <= 0) b = 0;

                        cl = Color.FromArgb(cl.A, r, g, b);
                        //************************

                        resultBm.SetPixel(i, j, cl);

                    }
                }
                bufferBm = resultBm;
                resultImg.Image = resultBm;
                draw_graph(bufferBm, true);
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (enable)
            {
                Bitmap resultBm = new Bitmap(sourceBm.Width, sourceBm.Height);

                for (int i = 0; i < sourceBm.Width; i++)
                {

                    for (int j = 0; j < sourceBm.Height; j++)
                    {

                        cl = bufferBm.GetPixel(i, j);
                        //************************

                        int r, g, b;

                        r = cl.R; g = cl.G; b = cl.B;


                        if (r < 128) r -= (int)numericUpDown2.Value;
                        else r += (int)numericUpDown2.Value;

                        if (g < 128) g -= (int)numericUpDown2.Value;
                        else g += (int)numericUpDown2.Value;

                        if (b < 128) b -= (int)numericUpDown2.Value;
                        else b += (int)numericUpDown2.Value;



                        if (r >= 255) r = 255;
                        if (g >= 255) g = 255;
                        if (b >= 255) b = 255;

                        if (r <= 0) r = 0;
                        if (g <= 0) g = 0;
                        if (b <= 0) b = 0;

                        cl = Color.FromArgb(cl.A, r, g, b);
                        //************************

                        resultBm.SetPixel(i, j, cl);

                    }
                }
                bufferBm = resultBm;
                resultImg.Image = resultBm;
                draw_graph(bufferBm, true);
            }
        }

        private void filter3_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                filter_3();
                //draw_graph(bufferBm, true);
            }
        }

        private void filter4_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                filter_4();
                draw_graph(bufferBm, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                resultImg.Image = sourceImg.Image;
                draw_graph(bufferBm, true);
            }
        }

        private void filter5_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                filter_5((int)pixelSize.Value);
                draw_graph(bufferBm, true);
            }
        }

        private void filter6_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                filter_6((int)power.Value);
                draw_graph(bufferBm, true);
            }
        }

        private void hold_show_MouseDown(object sender, MouseEventArgs e)
        {
            if (enable) resultImg.Image = sourceImg.Image;
        }

        private void hold_show_MouseUp(object sender, MouseEventArgs e)
        {
            if (enable) resultImg.Image = bufferBm;
        }

        private void filter7_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                filter_7((int)power.Value);
                draw_graph(bufferBm, true);
            }
        }

        private void graph1_Click(object sender, EventArgs e)
        {

        }

        private void BlurBtn_Click(object sender, EventArgs e)
        {

            blur_parallel((int)BlurValue.Value);
            //draw_graph(bufferBm, true);
        }

        
    }
}
