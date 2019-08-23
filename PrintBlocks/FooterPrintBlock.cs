﻿using System.Collections.Generic;
using System.Drawing;


namespace Printing.DataGridViewPrint.Sample.PrintBlocks
{
    /// <author>Blaise Braye</author>
    /// <summary>
    /// Sample of a footer to print on each printed sheet
    /// </summary>
    public class FooterPrintBlock : PrintBlock
    {
        Font font = new Font("Tahoma", 9, GraphicsUnit.Point);

        public override SizeF GetSize(Graphics g, DocumentMetrics metrics)
        {
            return g.MeasureString("Page X Of Y", font);
        }


        public override void Draw(System.Drawing.Graphics g, Dictionary<CodeEnum, string> codes)
        {
            StringFormat format = new StringFormat();
            format.Trimming = StringTrimming.Word;
            format.FormatFlags = StringFormatFlags.NoWrap;
            format.Alignment = StringAlignment.Far;

            g.DrawString(
                string.Format("Page {0} Of {1}", codes[CodeEnum.SheetNumber], codes[CodeEnum.SheetsCount]),
                font,
                new SolidBrush(Color.Black),
                Rectangle,
                format);
        }
    }
}
