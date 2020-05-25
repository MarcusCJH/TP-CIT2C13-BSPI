﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SCMSystem.classes
{
    class UniqueIDGenerator
    {
        private static object instance = new object();

        public static string NewId()
        {
            lock (instance)
            {
                Thread.Sleep(1);
                long ticks = DateTime.Now.Ticks;
                return ConvertToBase(ticks, 36);
                //DateTime.Now.GetHashCode()
            }
        }

        private static String ConvertToBase(long num, int nbase)
        {
            String chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // check if we can convert to another base
            if (nbase < 2 || nbase > chars.Length)
                return "";

            long r;
            String newNumber = "";

            // in r we have the offset of the char that was converted to the new base
            while (num >= nbase)
            {
                r = num % nbase;
                newNumber = chars[(int)r] + newNumber;
                num = num / nbase;
            }
            // the last number to convert
            newNumber = chars[(int)num] + newNumber;

            return newNumber.ToLower();
        }
    }
}
