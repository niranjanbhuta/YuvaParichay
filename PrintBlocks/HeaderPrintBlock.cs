using System.Collections.Generic;
using System.Drawing;


namespace Printing.DataGridViewPrint.Sample.PrintBlocks
{
    /// <author>Blaise Braye</author>
    /// <summary>
    /// Sample of a header to print on each printed sheet
    /// </summary>
    public class HeaderPrintBlock : PrintBlock
    {
        float imgHeight = 75;


        public override SizeF GetSize(Graphics g, DocumentMetrics metrics)
        {
            return new SizeF(metrics.PrintAbleWidth, imgHeight + 2); //+2 for spacing with document
        }

        public override void Draw(System.Drawing.Graphics g, Dictionary<CodeEnum, string> codes)
        {
            GraphicsUnit units = GraphicsUnit.Pixel;
            RectangleF rec = Properties.Resources.logo.GetBounds(ref units);
            
            float scale = imgHeight / rec.Height;
            g.DrawImage(Properties.Resources.logo, new RectangleF(Rectangle.X, Rectangle.Y, rec.Width * scale, imgHeight));
        }
    }
}
