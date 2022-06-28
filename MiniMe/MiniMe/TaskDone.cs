using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniMe
{
    public class TaskDone
    {
        public static void Done(TaskForMiniMe miniMe)
        {
            MyLvl myLvl = App.myLvl.GetLvl(1);
            myLvl.XPcount += miniMe.XPoint;
            App.myLvl.SaveItem(myLvl);
            App.Database.DeleteItem(miniMe.Id);
        }

        public static lvl GetLvl(int XPCount)
        {
            var lvls = App.lvlRepoitory.GetItems();
            foreach(var i in lvls)
            {
                if(XPCount < i.end_lvl)
                {
                    return i;
                }
            }
            return lvls.Last();
        }
    }
}
