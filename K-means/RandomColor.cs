using System.Drawing;

namespace K_means
{
    class RandomColor
    {
      private int[] rgb;
      private int iternum;
      private int curcol;

      private void Not()
      {
         for (int i = 0; i < 3; i++)
         {
            if (rgb[i] == 0)
               rgb[i] = curcol - 1;
            else
               rgb[i] = 0;
         }
      }

      private void Mov()
      {
         int first = rgb[0];

         for (int i = 0; i < 2; i++)
            rgb[i] = rgb[i + 1];

         rgb[2] = first;
      }

      public RandomColor()
      {
         this.rgb = new int[3];

         for (int i = 0; i < 3; i++)
            this.rgb[i] = 0;

         this.rgb[2] = 255;
         iternum = 0;
         curcol = 256;
      }

      public Color Next()
      {
         if (iternum == 6)
         {
            iternum = 0;
            curcol = (int)(curcol / 2);

            for (int i = 0; i < 3; i++)
               if (rgb[i] != 0)
                  rgb[i] = (rgb[i] + 1) / 2 - 1;
               Not();
         }

         if (iternum % 2 == 0)
            Mov();
         else
            Not();

         iternum++;
         return Color.FromArgb(rgb[0],rgb[1],rgb[2]);
      }
    }
}
