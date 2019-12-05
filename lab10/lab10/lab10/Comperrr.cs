using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class Comperrr : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Transport)x).CountMen.CompareTo(((Transport)y).CountMen);
        }
    }
}
