using System;

namespace day3
{
    class orientation
    {
        //enum contains landscape and portrait
        enum view
        {
            landscape,
            portrait
        }
        //getting input of width and height from user
        public void get_orientation()
        {
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            String result = width > height ? nameof(view.landscape) : nameof(view.portrait);
            Console.WriteLine("Your orientation is: " + result);
        }

    }
}