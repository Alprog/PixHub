
namespace PixHub
{
    public enum Flag
    {
        Disabled = 0,
        Enabled = 1
    }

    public enum HorizontalAlign
    {
        Left = 1,
        Middle = 2,
        Right = 3
    }

    public enum ItemType
    {
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_SECOND = 1,            // sceocnd , font should include digit
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_MIN = 2,               // min, font should include digit
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_HOUR = 3,              // hour, font should include digit
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_TIME_AM_PM = 4,        // am or pm, font should include a,m,p
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_HOUR_MIN = 5,          // hour：min , font should include digit
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_HOUR_MIN_SEC = 6,      // hour:min:sec, , font should include digit
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_YEAR = 7,              // year,, font should include digit
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_DAY = 8,               // day, font should include digit
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_MON = 9,               // month, font should include digit
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_MON_YEAR = 10,         // mon-year, font should include digit
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_ENG_MONTH_DOT_DAY = 11,// month, font should include english letters
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_DATE_WEEK_YEAR = 12,   // day:month:year, font should include digit
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_ENG_WEEK = 13,         // weekday-"SU","MO","TU","WE","TH","FR","SA", font should include english letters
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_ENG_WEEK_THREE = 14,   // weekday-"SUN","MON","TUE","WED","THU","FRI","SAT", font should include english letters
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_ENG_WEEK_ALL = 15,     // weekday-"SUNDAY","MONDAY","TUESDAY","WEDNESDAY","THURSDAY","FRIDAY","SATURDAY", font should include english letters
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_ENG_MON = 16,          // month-"JAN","FEB","MAR","APR","MAY","JUN","JUL","AUG","SEP","OCT","NOV","DEC", font should include english letters
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_TEMP_DIGIT = 17,       // temperature, font should include digit and c,f
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_TODAY_MAX_TEMP = 18,   // the max temperature, font should include digit and c,f
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_TODAY_MIN_TEMP = 19,   // the min temperature, font should include digit and c,f
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_WEATHER_WORD = 20,     // the weather, font should include english letters
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_NOISE_DIGIT = 21,      // the nosie value, font should include digit 
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_TEXT_MESSAGE = 22,     // the text string, font should include text information
        DIVOOM_DISP_CUSTOM_DIAL_SUPPORT_NET_TEXT_MESSAGE = 23, // the url request string, font should include url information, respone should be json encode including the "DispData" string element, eg:http://appin.divoom-gz.com/Device/ReturnCurrentDate?test=0 repone {"DispData": "2022-01-22 13:51:56"}
    }

}
