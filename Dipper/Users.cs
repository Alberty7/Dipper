using System;

public class Viewer
{
    /*Viewer может только смотреть рассписание, фильтровать, распечатать */
    public Viewer()
    {

    }
}

public class Redactor : Viewer
{
    /*Redactor может изменять рассписание (создавать, удалять, редактировать), так же, просматривать его, фильтровать, распечатать*/
    private string password;

    public string Password
    {
        private set
        {
            
        }

    }

    public Redactor (string psw):base() 
    {
        Password = psw;
    }
}