﻿namespace Projektas_Restoranas
{
    public static class Reader
    {
        public static string[] FileReader(string path)
        {
            var read = File.ReadAllLines(path);
            return read;
        }
    }
}
