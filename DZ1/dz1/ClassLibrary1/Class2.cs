using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Episode
    {
        public int viewerNum=0;
        public double sum = 0;
        public double max = 0.00;
 

        public Episode(int v, double s, double m)
        {
            this.viewerNum = v;
            this.sum = s;
            this.max = m;
        }

        public Episode()
        {
        }

        //public double max =0.00;

        //SETTERI



        //END SETTERI
       
        public void AddView(double randomScore)
        {
            sum += randomScore;
            viewerNum++;
            if(randomScore >max)
            {
                max = randomScore;
            }
        }
        public double GetMaxScore()
        {
            return max;
        }
        public double GetAverageScore()
        {
            double average;
            average = sum / viewerNum;
            return average;
        }
        public int GetViewerCount()
        {
            return viewerNum;
        }
        
    }
}
