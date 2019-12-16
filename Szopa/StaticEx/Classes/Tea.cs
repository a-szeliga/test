using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEx.Classes
{
   public static class Tea
    {
        public static double Price { get; set; }
        public static string Name { get; set; }
    }

    public static class Coffee
    {
        public static int Quality { get; set; }
        public static string Country { get; set; }
/*
        StringBuilder builder = new StringBuilder();
        builder.Append("dgddgf");
            builder.toString();
            */
    }
    
    
    public class Home
    {
        public readonly string room;

        public string x (string room)
        {
           // room = room;
        }
        public static int RoomNumber { get; set; }

        public string Owner{ get; set; }

    }

    public static class Room
    {
        public static string Window;

    }

    

}
