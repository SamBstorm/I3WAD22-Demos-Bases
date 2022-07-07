using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Enumeration
{
    public struct TrafficLigth
    {
        public TrafficLigthColor currentColor;

        //public void ChangeColor()
        //{
        //    switch (this.currentColor)
        //    {
        //        case TrafficLigthColor.Red:
        //            this.currentColor = TrafficLigthColor.Green;
        //            break;
        //        case TrafficLigthColor.Green:
        //            this.currentColor = TrafficLigthColor.Orange;
        //            break;
        //        case TrafficLigthColor.Orange:
        //            this.currentColor = TrafficLigthColor.Red;
        //            break;
        //        default:
        //            this.currentColor = TrafficLigthColor.Red;
        //            break;
        //    }
        //}

        public void ChangeColor() {
            this.currentColor = (TrafficLigthColor)((int)(this.currentColor + 1)%3);
        }
    }
}
