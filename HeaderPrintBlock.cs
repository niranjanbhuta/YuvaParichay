using System.Collections.Generic;
using System.Drawing;

// namespace Printing.DataGridViewPrint.Sample.PrintBlocks
namespace YuvaParichay.PrintBlocks
{
    /// <author>Blaise Braye</author>
    /// <summary>
    /// Sample of a header to print on each printed sheet
    /// </summary>
  //  public class HeaderPrintBlock : PrintBlock
   public class HeaderPrintBlock : Printing.DataGridViewPrint.PrintBlock 
    {
        float imgHeight = 40; // 75;

        public override SizeF GetSize(Graphics g, Printing.DataGridViewPrint.DocumentMetrics metrics)
        {
            return new SizeF(metrics.PrintAbleWidth, imgHeight + 2); //+2 for spacing with document
        }
        public override void Draw(System.Drawing.Graphics g, Dictionary<Printing.DataGridViewPrint.CodeEnum, string> codes)
        {
            GraphicsUnit units = GraphicsUnit.Pixel;
        //    RectangleF rec = Properties.Resources.logo.GetBounds(ref units);
            RectangleF rec = Properties.Resources.HastMilap.GetBounds(ref units);

            float scale = imgHeight / rec.Height;
            g.DrawImage(Properties.Resources.HastMilap, new RectangleF(Rectangle.X, Rectangle.Y, rec.Width * scale, imgHeight));
        }
    }
}
