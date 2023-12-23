using System.Globalization;

namespace Framework.Application;

public static class Extension
{
    public static DateTime ToDateTime(this string date)
    {
        var pc = new PersianCalendar();
        var dateArray = date.Split('/');
        var year = int.Parse(dateArray[0]);
        var month = int.Parse(dateArray[1]);
        var day = int.Parse(dateArray[2]);
        var dateTime = pc.ToDateTime(year,month,day,0,0,0,0);
        return dateTime;
    }

    public static string ToShamsi(this DateTime dateTime)
    {
        var pc = new PersianCalendar();
        return pc.GetYear(dateTime) + "/" + pc.GetMonth(dateTime).ToString("00") + "/" +
               pc.GetDayOfMonth(dateTime).ToString("00");
    }
}