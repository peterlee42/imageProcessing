using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class ImageProcessingForm : Form
    {
        public ImageProcessingForm()
        {
            InitializeComponent();
        }

        Bitmap bitmapImage;

        // Image Array
        Color[,] ImageArray = new Color[320, 240];

        // Copy of Image Array for Reset
        Color[,] ImageArrayCopy = new Color[320, 240];

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

        //   openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Image Browser";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    Image newImage = Image.FromStream(myStream);
                    bitmapImage = new Bitmap(newImage, 320, 240);
                    picImage.Image = bitmapImage;
                    myStream.Close();
                }
            }

            SetArayFromBitmap();

        }
        private void SetBitmapFromAray()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    bitmapImage.SetPixel(row, col, ImageArray[row, col]);
                }
        }

        private void SetArayFromBitmap()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    ImageArray[row, col] = bitmapImage.GetPixel(row, col);
                    ImageArrayCopy[row, col] = bitmapImage.GetPixel(row, col);
                }
        }

        private void btnGreenFilter_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            int Green;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Green = col.G;

                    // Set new color to green element only
                    Color newColor = Color.FromArgb(255, 0, Green, 0);
                    ImageArray[i, j] = newColor;

                }
            }

            // Update image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        
    }

        private void btnBlueFilter_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            int Blue;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the blue channel of a pixel and assign the color only to blue channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the blue element of the color
                    Blue = col.B;

                    // Set new color to blue element only
                    Color newColor = Color.FromArgb(255, 0, 0, Blue);
                    ImageArray[i, j] = newColor;
                }
            }

            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;

        }

        private void btnRedFilter_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            int Red;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the red channel of a pixel and assign the color only to red channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the red element of the color
                    Red = col.R;

                    // Set new color to red element only
                    Color newColor = Color.FromArgb(255, Red, 0, 0);
                    ImageArray[i, j] = newColor;
                }
            }

            // Updates Image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnDarken_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;
            int newR, newG, newB;

            for(int i =0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    Color color = ImageArray[i, j];
                    
                    // Decreases value of RGB values by 10%
                    newR =Convert.ToInt32( color.R * 0.9);
                    newG = Convert.ToInt32(color.G *0.9);
                    newB = Convert.ToInt32(color.B *0.9);

                    // Updates array
                    Color darkenedColor = Color.FromArgb(255, newR, newG, newB);
                    ImageArray[i, j] = darkenedColor;
                }
            }

            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;

        }

        private void btnLighten_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;
            int newR, newG, newB;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color color = ImageArray[i, j];

                    // Increases RBG values by 10%
                    newR = Convert.ToInt32(color.R * 1.1);
                    newG = Convert.ToInt32(color.G * 1.1);
                    newB = Convert.ToInt32(color.B * 1.1);

                    // If any RGB values are greater than the max (255) after 10% increase, we set it to the max (255)
                    if (newR > 255)
                        newR = 255;
                    if (newG > 255)
                        newG = 255;
                    if (newB > 255)
                        newB = 255;

                    // Updates Array
                    Color lightenedColor = Color.FromArgb(255, newR, newG, newB);
                    ImageArray[i, j] = lightenedColor;
                }
            }
            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;
            int newR, newG, newB;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color color = ImageArray[i, j];

                    // Finds difference from max which is the inverted value
                    newR = 255 -  color.R;
                    newG = 255 - color.G;
                    newB = 255 - color.B;

                    // Updates array
                    Color invertedColor = Color.FromArgb(255, newR, newG, newB);
                    ImageArray[i, j] = invertedColor;
                }
            }

            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnSunset_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;
            int newR, newB;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color color = ImageArray[i, j];

                    // Increases Red by 10% and decreases blue by 10%
                    newR =Convert.ToInt32( color.R * 1.1);
                    newB =Convert.ToInt32( color.B * 0.9);

                    // If Red greater than max value, set to max value
                    if (newR > 255)
                        newR = 255;

                    // Updates array
                    Color sunsetColor = Color.FromArgb(255, newR, color.G, newB);
                    ImageArray[i, j] = sunsetColor;
                }
            }
            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;
            int R, G, B, averageValue;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color color = ImageArray[i, j];

                    // Finds average of RGB values which gives grey
                    R = Convert.ToInt32(color.R);
                    G = Convert.ToInt32(color.G);
                    B = Convert.ToInt32(color.B);
                    averageValue = (R + G + B) / 3;

                    // Updates array
                    Color greyColor = Color.FromArgb(averageValue, averageValue, averageValue);
                    ImageArray[i, j] = greyColor;
                    
                }
            }
            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnPolarize_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;
            int R, G, B, rAvg = 0, gAvg = 0,bAvg = 0;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    // Add RGB values to their respective variables
                    Color color = ImageArray[i, j];
                    rAvg += Convert.ToInt32(color.R);
                    gAvg += Convert.ToInt32(color.G);
                    bAvg += Convert.ToInt32(color.B);
                }
            }

            // Finds average of all R G B values of image
            rAvg /= width * height;
            gAvg /= width * height;
            bAvg /= width * height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color color = ImageArray[i, j];

                    // Retrieves RGB values
                    R = Convert.ToInt32(color.R);
                    G = Convert.ToInt32(color.G);
                    B = Convert.ToInt32(color.B);

                    // For each RBG value, if their value is greater than their average, make their value 225 or else make it 0
                    if (R >= rAvg)
                        R = 255;
                    else if (R < rAvg)
                        R = 0;
                    if (G >= gAvg)
                        G = 255;
                    else if (G < gAvg)
                        G = 0;

                    if (B >= bAvg)
                        B = 255;
                    else if (B < bAvg)
                        B = 0;

                    // Update array
                    Color polarizedColor = Color.FromArgb(R, G, B);
                    ImageArray[i, j] = polarizedColor;

                }
            }
            // Update Image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipHoriz_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;

            for (int i = 0; i < width/2; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color tempPixel;
                    tempPixel = ImageArray[i, j];

                    // Sets current pixel to opposite pixel
                    ImageArray[i, j] = ImageArray[width - 1 - i, j];
                    // Sets pixel opposite on horizontal axis to original pixel
                    ImageArray[width - 1 - i, j] = tempPixel;
                }
            }
            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipVert_Click(object sender, EventArgs e)
        {
            // Checks if image exists
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height/2; j++)
                {
                    Color tempPixel;
                    tempPixel = ImageArray[i, j];

                    // Sets current pixel to opposite pixel on horizontal axis
                    ImageArray[i, j] = ImageArray[i, height -1 - j];
                    // Sets pixel opposite on vertical axis to original pixel
                    ImageArray[i, height - 1-j] = tempPixel;
                }
            }
            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnRot180_Click(object sender, EventArgs e)
        {
            // Checks if image exists
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;

            for (int i = 0; i < width / 2; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color tempPixel;
                    tempPixel = ImageArray[i, j];
                    // Sets current pixel to opposite pixel on horizontal axis
                    ImageArray[i, j] = ImageArray[width - 1 - i, j];
                    // Sets pixel opposite on horizontal axis to original pixel
                    ImageArray[width - 1 - i, j] = tempPixel;
                }
            }
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height / 2; j++)
                {
                    Color tempPixel;
                    tempPixel = ImageArray[i, j];

                    // Sets current pixel to opposite pixel on vertical axis
                    ImageArray[i, j] = ImageArray[i, height - 1 - j];
                    // Sets pixel opposite on vertical axis to original pixel
                    ImageArray[i, height - 1 - j] = tempPixel;
                }
            }

            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipCorners_Click(object sender, EventArgs e)
        {
            // Checks if image exists
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;

            for (int i = 0; i < width / 2; i++)
            {
                for (int j = 0; j < height/2; j++)
                {
                    Color tempPixel;
                    tempPixel = ImageArray[i, j];

                    // Sets current pixel to pixel from bottom right quarter of image
                    ImageArray[i, j] = ImageArray[width/2 + i, height/2 + j];

                    // Sets pixel from bottom right quarter of image to current pixel
                    ImageArray[width / 2 + i, height / 2 + j] = tempPixel;
                }
            }

            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnPixellate_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;

            
            for (int i = 0; i < width; i+=8)
            {
                for (int j = 0; j < height; j+=8)
                {
                    // Finds color of top right pixel of an 8 by 8 section of image
                    Color topLeftColor = ImageArray[i, j];

                    for(int k = 0; k < 8; k++)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            // Sets each pixel of 8 by 8 section to top left pixel
                            ImageArray[i + k, j + l] = topLeftColor;
                        }
                    }
                  
                }
            }
            
            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnTile_Click(object sender, EventArgs e)
        {
            // Checks if image exists
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;

            Color[,] scaledImageArray = new Color[width/2,height/2];

            for (int i = 0; i < width; i+=2)
            {
                for (int j = 0; j < height; j+=2)
                {
                    // Finds average of 2 by 2 pixels for each RBG value

                    int R1, R2, R3, R4, avgR;
                    R1 = ImageArray[i, j].R;
                    R2 = ImageArray[i + 1, j].R;
                    R3 = ImageArray[i, j + 1].R;
                    R4 = ImageArray[i + 1, j + 1].R;
                    avgR = (R1 + R2 + R3 + R4) / 4;

                    int G1, G2, G3, G4, avgG;
                    G1 = ImageArray[i, j].G;
                    G2 = ImageArray[i + 1, j].G;
                    G3 = ImageArray[i, j + 1].G;
                    G4 = ImageArray[i + 1, j + 1].G;
                    avgG = (G1 + G2 + G3 + G4) / 4;

                    int B1, B2, B3, B4, avgB;
                    B1 = ImageArray[i, j].B;
                    B2 = ImageArray[i + 1, j].B;
                    B3 = ImageArray[i, j + 1].B;
                    B4 = ImageArray[i + 1, j + 1].B;
                    avgB = (B1 + B2 + B3 + B4) / 4;

                    // Sets average values to scaled image
                    scaledImageArray[i/2, j/2] = Color.FromArgb(avgR, avgG, avgB);
                }
            }
            
            for (int i = 0; i < width/2; i ++)
            {
                for (int j = 0; j < height/2; j ++)
                {
                    // Sets pixel for top left quarter
                    ImageArray[i, j] = scaledImageArray[i, j];

                    // Sets pixels for top right horizontally flipped image
                    ImageArray[width - i - 1, j] = scaledImageArray[i, j];

                    // Sets pixels for bottom right 180 deg rotated image
                    ImageArray[width - i - 1, height - j - 1] = scaledImageArray[i, j];

                    // Sets pixels for bottom left vertically flipped image
                    ImageArray[i, height - j - 1] = scaledImageArray[i, j];
                }
            }
            
            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            int width = 320;
            int height = 240;

            for (int i = 0; i < height; i++)
            {
                // Sort Row
                for (int j = 0; j < width; j++)
                {
                    // Takes average of RBG
                    int R, G, B;
                    R = ImageArray[j, i].R;
                    G = ImageArray[j, i].G;
                    B = ImageArray[j, i].B;
                    int iVal = (R + G + B) / 3;

                    // Insertion sort for the i'th row of image array
                    int k = j - 1;

                    while (k >= 0)
                    {
                        int iValBefore = (ImageArray[k, i].R + ImageArray[k, i].G+ ImageArray[k, i].B)/3;
                        if (iVal < iValBefore)
                            ImageArray[k + 1, i] = ImageArray[k, i];
                        else
                            break;
                        k--;
                    }
                    // Puts original color to correct place
                    ImageArray[k + 1, i] = Color.FromArgb(R, G, B);
                }
            }

            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            Color[,] ZoomImageArray = new Color [160, 120];

            int widthGap, heightGap;

            widthGap = 320 / 4;
            heightGap = 240 / 4;

            for(int i = 0; i < 160; i++)
            {
                for(int j = 0; j < 120; j++)
                {
                    // Get pixel from i, j with addition of width and height gap to get zoomed image pixel
                    ZoomImageArray[i, j] = ImageArray[i + widthGap - 1, j + heightGap - 1];
                }
            }
            
            for(int i = 0; i < 320; i+=2)
            {
                for(int j = 0; j < 240; j+=2)
                {
                    // Sets each 2 by 2 pixel block from image array to each pixel of zoomed image
                    ImageArray[i, j] = ZoomImageArray[i / 2, j / 2];
                    ImageArray[i + 1, j] = ZoomImageArray[i / 2, j / 2];
                    ImageArray[i, j + 1] = ZoomImageArray[i / 2, j / 2];
                    ImageArray[i + 1, j + 1] = ZoomImageArray[i / 2, j / 2];
                }
            }

            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Checks if there is an image
            if (bitmapImage == null)
                return;

            for (int i = 0; i < 320; i++)
            {
                for(int j = 0; j < 240; j++)
                {
                    // Sets pixel of image array to pixel of the copy to reset
                    ImageArray[i, j] = ImageArrayCopy[i, j];
                }
            }
            // Updates image
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }
    }
}
