using System.Globalization;

public static class PersianDate
{

    //convertor date to persian 
    public static string ToPersianDate(this DateTime value)
    {
        PersianCalendar pc = new PersianCalendar();
        return string.Format("{0}/{1}/{2}", pc.GetYear(value), pc.GetMonth(value), pc.GetDayOfMonth(value));
    }

    //convertor persian to date
    public static DateTime ToDate(this string value)
    {
        PersianCalendar pc = new PersianCalendar();
        // تقسیم رشته تاریخ به اجزای آن
        string[] dateParts = value.Split('/', '-');

        int year = int.Parse(dateParts[0]);
        int month = int.Parse(dateParts[1]);
        int day = int.Parse(dateParts[2]);

        return pc.ToDateTime(year, month, day, 0, 0, 0, 0);
    }
}