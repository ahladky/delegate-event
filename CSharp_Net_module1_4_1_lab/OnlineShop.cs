﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    class OnlineShop
    {
        // 4) declare event of type EventHandler<GoodsInfoEventArgs>
        public string GoodsName;
        public event EventHandler<GoodsInfoEventArgs> NewGoodsInfo;

        public void NewGoods(string goodsName)
        {
            if (NewGoodsInfo != null)
            {
                NewGoodsInfo(this, new GoodsInfoEventArgs(goodsName));
                GoodsName = goodsName;
            }

        }
        
        // 5) declare method NewGoods for event initiation
        // use parameter string to get GoodsName
        
        // don't forget to check if event is not null
        // in true case intiate the event
        // use next line

        // your_event_name(this, new GoodsInfoEventArgs(GoodsName));

    }
}
