using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class TOrden
    {
        private int[] nums;
        private int dim;

        public TOrden(int[] s)
        {
            int n = s.Length;
            dim = 0;
            nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = s[i];
                dim++;
            }
        }

        public TOrden(string s)
        {
            s += " ";
            nums = new int[100];
            dim = 0;
            int i = 0;
            while (s != "")
            {
                int elm = Int32.Parse(s.Substring(0,s.IndexOf(" ")));
                s = s.Remove(0, s.IndexOf(" ")+1);
                nums[i] = elm;
                dim++;
                i++;
            }
        }
        public override string ToString()
        {
            string tmp = "";
            int n = dimension();
            for (int i = 0; i < n; i++)
            {
                if (i < n - 1) tmp += nums[i].ToString() + " ";
                else tmp += nums[i].ToString();
            }
            return tmp;
        }        

        public int dimension()
        {
            return dim;
        }
        
        public void swap(int n1, int n2)
        {
            int n = dimension(), pos1 = -1, pos2 = -1, tmp=-1, i=0;
            while ((pos1 == -1 || pos2 == -1) && (i < n))
            {
                if (nums[i] == n1) pos1 = i;
                else if (nums[i] == n2) pos2 = i;
                i++;
            }
            tmp = nums[pos1];
            nums[pos1] = nums[pos2];
            nums[pos2] = tmp;
        }

        public void perm()
        {
            int m = dimension() - 2;
            if (m > 0)
            {
                while (nums[m] > nums[m + 1])
                {
                    m--;
                }
                int k = dimension() - 1;
                while (nums[m] > nums[k])
                {
                    k--;
                }
                swap(nums[m],nums[k]);
                int p = m + 1, q = dimension() - 1;
                while (p < q)
                {
                    swap(nums[p], nums[q]);
                    p++;
                    q--;
                }
            }
        }
    }
}
