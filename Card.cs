using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matchingGame
{
    class Card
    {
        PictureBox picture;
        Bitmap back_image = new Bitmap("F:\\matchingGame\\matchingGame\\assets\\cardback_98.gif");
        Bitmap front_image;
        Boolean flipped = false;
        String image_path;

        public Card(PictureBox pic, String image_path)
        {
            this.picture = pic;
            this.front_image = new Bitmap(image_path);
            this.image_path = image_path;
        }

        public String getPath()
        {

            return this.image_path;
        }

        public PictureBox getPicture() {
            return this.picture;
        }

        public Boolean isFlipped() {
            return this.flipped;
        }

        public void swapImage() {
            if (this.isFlipped())
            {
                this.picture.Image = this.back_image;
                this.flipped = false;
            }
            else
            {
                this.picture.Image = this.front_image;
                this.flipped = true;
            }
        }
    }
}
