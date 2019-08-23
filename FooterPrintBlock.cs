using System.Collections.Generic;
using System.Drawing;


namespace YuvaParichay.PrintBlocks
{
    /// <author>Blaise Braye</author>
    /// <summary>
    /// Sample of a footer to print on each printed sheet
    /// </summary>
    public class FooterPrintBlock : Printing.DataGridViewPrint.PrintBlock
    {
        Font font = new Font("Tahoma", 9, GraphicsUnit.Point);

        public override SizeF GetSize(Graphics g, Printing.DataGridViewPrint.DocumentMetrics metrics)
        {
            return g.MeasureString("Page X Of Y", font);
        }


        public override void Draw(System.Drawing.Graphics g, Dictionary<Printing.DataGridViewPrint.CodeEnum, string> codes)
        {
            StringFormat format = new StringFormat();
            format.Trimming = StringTrimming.Word;
            format.FormatFlags = StringFormatFlags.NoWrap;
            format.Alignment = StringAlignment.Far;

            g.DrawString(
                string.Format("Page {0} Of {1}", codes[Printing.DataGridViewPrint.CodeEnum.SheetNumber], codes[Printing.DataGridViewPrint.CodeEnum.SheetsCount]),
                font,
                new SolidBrush(Color.Black),
                Rectangle,
                format);
        }
    }
}
