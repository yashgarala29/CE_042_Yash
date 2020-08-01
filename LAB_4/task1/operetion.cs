using System;
namespace operetion_namespace
{
    public class operetion_class
    {
        public string max(int x, int y)
        {
            if (x < y)
            {
                
                return y.ToString() ;
            }
            else if(y<x)
            {
                return x.ToString();
            }
            else
            {
                return "both are equeal";
            }

        }
        public string min(int x, int y)
        {
            if (x < y)
            {
                return x.ToString();
            }
            else if (y < x)
            {
                return y.ToString();
            }
            else
            {
                return "both are equeal";
            }

        }
        public int add(int x, int y)
        {
            return x + y;
        }
        public int sub(int x,int y)
        {
            return x - y;
        }
        public int mul(int x,int y)
        {
            return x * y;
        }

    }
}