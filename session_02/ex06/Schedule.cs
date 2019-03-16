using System;
using System.Collections;

class Schedule
{

    private Hashtable table;

    public Schedule()
    {
        table = new Hashtable();
    }

    public string this[DateTime time]
    {

        get
        {
            return (string)table[time];
        }
    }

    public void addClass(DateTime date, string className)
    {
        table.Add(date, className);
    }


}